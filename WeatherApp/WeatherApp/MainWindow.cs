using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class MainWindow : Form
    {
        WeatherDBEntities db;
        public MainWindow(WeatherDBEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
        private string urlForCity(string cityName)
        {
            string stringBeforeCityName = "http://api.openweathermap.org/data/2.5/weather?q=";
            string stringAfterCityName = "&APPID=ad07b432fe5dcef1e82ab02420df1208&units=metric&cnt6";
            string completeUrl = String.Format(stringBeforeCityName + cityName + stringAfterCityName);
            return completeUrl;
        }
        private JsonToCssMap.root Call_API(string cityName)
        {          
            WebRequest requestObjectGet = WebRequest.Create(urlForCity(cityName));
            requestObjectGet.Method = "GET";
            HttpWebResponse responseObjectGet;
            responseObjectGet = (HttpWebResponse)requestObjectGet.GetResponse();
            string webResult;
            JsonToCssMap.root currentWeather;
            using (Stream stream = responseObjectGet.GetResponseStream())
                {
                StreamReader streamRead = new StreamReader(stream);
                webResult = streamRead.ReadToEnd();
                streamRead.Close();
                currentWeather = JsonConvert.DeserializeObject<JsonToCssMap.root>(webResult);
                }
            return currentWeather;
        }
        private void btnCallApi_Click(object sender, EventArgs e)
        {
            List<City> citiesToRefresh = db.City.ToList();
            foreach(City city in citiesToRefresh)
            {
                WeatherHistory newHistoryWeather = new WeatherHistory();
                newHistoryWeather.city = city.Cityid;
                JsonToCssMap.root weatherData = Call_API(city.CityName);
                newHistoryWeather.Temperature = weatherData.main.temp;
                newHistoryWeather.Pressure = weatherData.main.pressure;
                newHistoryWeather.Humidity = weatherData.main.humidity;
                newHistoryWeather.WindSpeed = weatherData.wind.speed;
                newHistoryWeather.WeatherDate = DateTime.Now;
                db.WeatherHistory.Add(newHistoryWeather);
                db.SaveChanges();
            }
            MessageBox.Show("Refresh success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewHistoryWeather.DataSource = db.vWeatherHistory.ToList();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dataGridViewHistoryWeather.DataSource = db.vWeatherHistory.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
