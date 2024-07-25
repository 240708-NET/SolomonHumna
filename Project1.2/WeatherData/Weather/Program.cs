using System;
using WeatherData.Repo;
using WeatherData.Model;
namespace Weather
{
    public static void Main(string[] args)
    {
        IWeather temp = new Weather();
        temp.GenerateWeatherData();
        temp.DisplayWeather();
    }
}
/*IWeather Today = new Weather("Hot", 27, 80);
WeatherCondition temp = new WeatherCondition(Today);
//Iweather convert = new ConvertTemprature(convert);



temp.displayWeather();
//convert.ConvertTemp();*/