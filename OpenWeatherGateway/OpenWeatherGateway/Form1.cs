using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Threading;

namespace OpenWeatherGateway
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
       
        string APIKey = "1e10f2b729048455df20de23781dae68";
        

        private void btn_search_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKey);
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    picIcon.ImageLocation = "http://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    lab_condition.Text = Info.weather[0].main;
                    lab_detail.Text = Info.weather[0].description;
                    lab_sunset.Text = convertDateTime(Info.sys.sunset).ToString();
                    lab_sunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                    lab_windspeed.Text = Info.wind.speed.ToString();
                    lab_pressure.Text = Info.main.pressure.ToString();
                    lab_country.Text = Info.sys.country.ToString();
                    Tb_link.Text = "http://localhost:8080/?city=" + TbCity.Text;
                } catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }
               
        private HttpServer _server;
        public string GetWeatherData(string city)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, APIKey);
                    var json = web.DownloadString(url);
                    WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    var weatherData = new
                    {
                        condition = info.weather[0].main,
                        detail = info.weather[0].description,
                        icon = "http://openweathermap.org/img/w/" + info.weather[0].icon + ".png",
                        sunrise = convertDateTime(info.sys.sunrise).ToString(),
                        sunset = convertDateTime(info.sys.sunset).ToString(),
                        windspeed = info.wind.speed,
                        pressure = info.main.pressure,
                        country = info.sys.country
                    };

                    return JsonConvert.SerializeObject(weatherData);
                }
                catch (Exception ex)
                {
                    return JsonConvert.SerializeObject(new { error = ex.Message });
                }
            }
        }
        public class HttpServer
        {
            private readonly HttpListener _listener;
            private readonly Form1 _form;
            public HttpServer(Form1 form, string[] prefixes)
            {
                _form = form;
                _listener = new HttpListener();
                foreach (string prefix in prefixes)
                {
                    _listener.Prefixes.Add(prefix);
                }
            }
            public void Start()
            {
                _listener.Start();
                ThreadPool.QueueUserWorkItem(o =>
                {
                    try
                    {
                        while (_listener.IsListening)
                        {
                            ThreadPool.QueueUserWorkItem(c =>
                            {
                                var ctx = c as HttpListenerContext; try
                                {
                                    if (ctx.Request.HttpMethod == "GET")
                                    {
                                        string city = ctx.Request.QueryString["city"];
                                        if (!string.IsNullOrEmpty(city))
                                        {
                                            var weatherData = _form.GetWeatherData(city);
                                            byte[] buf = System.Text.Encoding.UTF8.GetBytes(weatherData);
                                            ctx.Response.ContentLength64 = buf.Length;
                                            ctx.Response.OutputStream.Write(buf, 0, buf.Length);
                                        }
                                        else
                                        {
                                            ctx.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                                        }
                                    }
                                    else
                                    {
                                        ctx.Response.StatusCode = (int)HttpStatusCode.MethodNotAllowed;
                                    }
                                }
                                catch { }
                                finally
                                {
                                    ctx.Response.OutputStream.Close();
                                }
                            }, _listener.GetContext());
                        }
                    }
                    catch { }
                });
            }
            public void Stop()
            {
                _listener.Stop();
                _listener.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] prefixes = { "http://localhost:8080/" };               // http://localhost:8080/?city=
            _server = new HttpServer(this, prefixes);
            _server.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _server.Stop();
        }
        
    }
}
