using System;
//using System.IO;
using WeatherData.Model;


namespace WeatherData.Repo
{

//all methods must be here
    public class Weather : IWeather{

        
        //Fields

       
          public string Condition { get; set; }
          public int Humidity { get; set; }
          public int Temprature { get; set; }
          public int Precipitation { get; set; }
          public int Visibility { get; set; }

          //public void DisplayWeather();
          public void DisplayWeather();
          public void GenerateWeatherData();

        
        public Weather(string condition, int temprature, int humidity, int precipitation, int visibility)
        {
            this.condition = condition;
            this.temprature = temprature;
            this.humidity = humidity;
            this.Precipitation = precipitation;
            this.Visibility = visibility;
            
        }
        
        public void DisplayWeather(){
            Console.WriteLine ($"Todays's Weather is {condition}It is {temprature}°C  with {humidity}% of humidity. There is a {preciptation}% chance of precipitation with {visibility} miles of visibility." );
        }

        public void GenerateWeatherData()
        {
            float celsius = 0;
            float fahrenheit = 0;
            string userInputF {get; set;}= "f";
            string userInputC {get; set;}= "c"; 
            string answerYes {get; set;}= "y";
            string answerNo {get; set;}= "n";
            string answer {get; set;}= "";
            bool noMore = false;   
        do
        {    
                Console.Write("Do you want todays weather condition? ");
                answer = Console.ReadLine();
                if(answer == answerYes)
                {
                    Random randomTemp = new Random();
                    int tempCelsius = randomTemp.Next(-50, 50);
                    Console.WriteLine(tempCelsius);
                    Random randomHumid = new Random();
                    int humidity = randomHumid.Next(0, 100);
                    Console.WriteLine(humidity);
                    Random randomRain = new Random();
                    int precipitation = randomRain.Next(0, 100);
                    Console.WriteLine(precipitation);
                     Random randomLook = new Random();
                    int visibility = randomLook.Next(0, 10);
                    Console.WriteLine(visibility);
                    if (tempCelsius > 29)
                    {   
                        _weather.condition = "Hot";
                        _weather.temprature = tempCelsius;
                        _weather.humidity = humidity;
                        _weather.precipitation = precipitation;
                        _weather.visibility = visibility;
                        Console.WriteLine Console.WriteLine ($"Todays's Weather is {_weather.condition}It is {_weather.temprature}°C  with {_weather.humidity}% of humidity. There is a {_weather.preciptation}% chance of precipitation with {_weather.visibility} miles of visibility." );
                    }
                    else if (tempCelsius < 10  && humidity < 100)
                    {   
                        _weather.condition = "Cold!";
                        _weather.temprature = tempCelsius;
                        _weather.humidity = humidity;
                        _weather.precipitation = precipitation;
                        _weather.visibility = visibility;
                        Console.WriteLine ($"Todays's Weather is {_weather.condition}It is {_weather.temprature}°C  with {_weather.humidity}% of humidity. There is a {_weather.preciptation}% chance of precipitation with {_weather.visibility} miles of visibility." );
                    }
                    else 
                    {   
                        _weather.condition = "Great!";
                        _weather.temprature = tempCelsius;
                        _weather.humidity = humidity;
                        _weather.precipitation = precipitation;
                        _weather.visibility = visibility;
                        Console.WriteLine ($"Todays's Weather is {_weather.condition}It is {_weather.temprature}°C  with {_weather.humidity}% of humidity. There is a {_weather.preciptation}% chance of precipitation with {_weather.visibility} miles of visibility." );
                    }
                }else
                {
                    break;
                }

                //user story 1
                    //Ask the user which temprature types they want convert from?
                do{ //loop again
                    
                    do{        
                            //user must have an option to choose between celsius, and Fahrenheit
                        Console.Write("Do you want to convert the temprature in °F ? ");
                        answer = Console.ReadLine().ToLower();		
                        if(answer == answerYes) // check the if the input is in celcius
                        {
                            
                            fahrenheit = ((_weather.temprature * 9/5) +32); //calculate the conversion
                            fahrenheit = (float)Math.Round(fahrenheit, 1);
                            Console.WriteLine("The temp in Fahrenheit is {0}", fahrenheit); //printout the result
                        }
                        else
                        {
                            break; //if the answer is no, nothing to display
                        } 
                        Console.WriteLine(); //spacing
                            //user story 3
                            //ask the user to do it again
                        Console.WriteLine("Do you want to check Tomorrow weather? ");
                        answer = Console.ReadLine().ToLower();
                        if(answer == answerYes.ToLower())
                        {
                            Random random = new Random();
                            int tempTomorrow = random.Next(-50, 50);
                            Console.WriteLine(tempTomorrow);
                            Random humidTomorrow = new Random();
                            int humidity2 = humidTomorrow.Next(0, 100);
                            Console.WriteLine(humidity2);
                            Random randomRain2 = new Random();
                            int precipitation2 = randomRain.Next(0, 100);
                            Console.WriteLine(precipitation2);
                            Random randomLook2 = new Random();
                            int visibility2 = randomLook.Next(0, 10);
                            Console.WriteLine(visibility2);
                            
                            
                            if (tempTomorrow > 29)
                            {   
                                _weather.condition = "Hot";
                                _weather.temprature = tempTomorrow;
                                _weather.humidity = humidity2;
                                _weather.precipitation = precipitation2;
                                _weather.visibility = visibility2;
                                Console.WriteLine ($"Tomorrow's Weather is expected to be {_weather.temprature}°C and {_weather.condition} with {_weather.humidity}% of humidity. There is a {_weather.preciptation}% chance of precipitation with {_weather.visibility} miles of visibility." );
                            }
                            else if (tempTomorrow < 10  && humidity2 < 100)
                            {   
                                _weather.condition = "Cold!";
                                _weather.temprature = tempTomorrow;
                                _weather.humidity = humidity2;
                                _weather.precipitation = precipitation2;
                                _weather.visibility = visibility2;
                                Console.WriteLine ($"Tomorrow's Weather is expected to be {_weather.temprature}°C and {_weather.condition} with {_weather.humidity}% of humidity. There is a {_weather.preciptation}% chance of precipitation with {_weather.visibility} miles of visibility." );
                            }
                            else 
                            {  
                                _weather.condition = "Great!";
                                _weather.temprature = tempTomorrow;
                                _weather.humidity = humidity2;
                                _weather.precipitation = precipitation2;
                                _weather.visibility = visibility2;
                                Console.WriteLine ($"Tomorrow's Weather is expected to be {_weather.temprature}°C and {_weather.condition} with {_weather.humidity}% of humidity. There is a {_weather.preciptation}% chance of precipitation with {_weather.visibility} miles of visibility." );
                            }
                            Console.Write("Do you want to convert the temprature in °F ? ");
                            answer = Console.ReadLine().ToLower();		
                            if(answer == answerYes) // check the if the input is in celcius
                            {
                                
                                fahrenheit = ((_weather.temprature * 9/5) +32); //calculate the conversion
                                fahrenheit = (float)Math.Round(fahrenheit, 1);
                                Console.WriteLine("The temp in Fahrenheit is {0}", fahrenheit); //printout the result
                            }
                                break;
                        }
                    }while (answer == answerYes.ToLower());
                    break;   

                }while(answer == answerYes.ToLower());
                break;
            }while(answer == answerNo.ToLower());
        //Console.WriteLine ($"Today's Weather is {condition}. It is {temprature}°F with {humidity}% of humidity." );
        
        }
    }
}