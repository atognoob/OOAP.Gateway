using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Threading;

namespace NoGateway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = "1e10f2b729048455df20de23781dae68";
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
                }
                catch (Exception ex)
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            getWeather();
        }
    }
}
