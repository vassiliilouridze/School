using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5.Model
{
    public class WeatherForecast
    {
        private DateTime _date;
        private double _maxTemp;
        private double _minTemp;
        private double _windSpeed;

        public double WindSpeed
        {
            get { return _windSpeed; }
            set { _windSpeed = value; }
        }


        public double MinTemp
        {
            get { return _minTemp; }
            set { _minTemp = value; }
        }


        public double MyProperty
        {
            get { return _maxTemp; }
            set { _maxTemp = value; }
        }

        private string _weatherDescription;

        public string MyProperty
        {
            get { return _weatherDescription; }
            set { _weatherDescription = value; }
        }


        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}
