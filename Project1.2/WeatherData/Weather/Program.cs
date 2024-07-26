using System;
using WeatherData.Repo;
using WeatherData.Model;

namespace Weather

{
    public class Program
    {
        public static void Main(string[] args)

        {
            string path = @"./Weather.txt";
            IWeather temp = new WeatherData.Repo.WeatherData();
            temp.GenerateWeatherData();
            //IWeather temprature = new Serialization();
            

            // WeatherCondition BadOrGoodWeather = new WeatherCondition();
            // temprature.SaveWeather(BadOrGoodWeather, path);
            // //temp.DisplayWeather();

            // string jsonWeather = JsonSerializer.Serialize(temp);
            // jsonWeather.Serialize(temp);
        }
    }
}





