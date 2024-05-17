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

namespace PatternGateway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            weatherGateway = new WeatherGateway();
        }
        
        private WeatherGateway weatherGateway;
        private void getWeather()
        {
            try
            {
                var Info = weatherGateway.GetWeather(TbCity.Text);
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
        private DateTime convertDateTime(long millisec)         //Преобразуйте время Unix в DateTime.
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
