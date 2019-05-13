using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class StandardUserForm : Form
    {
        WeatherDBEntities db;
        public StandardUserForm(WeatherDBEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void StandardUserForm_Load(object sender, EventArgs e)
        {
            comboBoxCity.DataSource = db.City.ToList();
        }

        private void btnShowWeather_Click(object sender, EventArgs e)
        {
            string cityName = comboBoxCity.Text.Trim();
            List<vWeatherHistory> selectedCityWeatherHistory = (from vWeatherHistory in db.vWeatherHistory
                                                                where vWeatherHistory.CityName == cityName
                                                                select vWeatherHistory).ToList();
            dataGridViewWeather.DataSource = selectedCityWeatherHistory;
            chartTemperature.Series["Temperature"].Points.Clear();
            foreach(vWeatherHistory historyMember in selectedCityWeatherHistory)
            {
                chartTemperature.Series["Temperature"].Points.AddXY(historyMember.WeatherDate,historyMember.Temperature);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
