/*using System;
namespace Project1;*/

   public interface IWeather
   {


        public string condition { get; set; }
        public int humidity { get; set; }
        public int temprature { get; set; }

        public void displayWeather();
   }
