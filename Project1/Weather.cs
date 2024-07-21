/*using System;
namespace Project1;*/
public class Weather : IWeather{

       

        public string condition { get; set; }
        public int humidity { get; set; }
        public int temprature { get; set; }

    
    public Weather(string condition, int temprature, int humidity)
    {
        this.condition = condition;
        this.temprature = temprature;
        this.humidity = humidity;
        
    }

    public void displayWeather(){

       
       //Console.WriteLine ($"Today's Weather is {condition}. It is {temprature}°F with {humidity}% of humidity." );
       
    }



}