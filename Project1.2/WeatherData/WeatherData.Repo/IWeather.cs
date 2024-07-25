using System;
using WeatherData.Model;
//using WeatherData;

namespace WeatherData.Repo;

   public interface IWeather
   {


          public string Condition { get; set; }
          public int Humidity { get; set; }
          public int Temprature { get; set; }
          public int Precipitation { get; set; }
          public int Visibility { get; set; }

          public void DisplayWeather();
          //public void ConverTemprature();
          public void GenerateWeatherData();
   }
