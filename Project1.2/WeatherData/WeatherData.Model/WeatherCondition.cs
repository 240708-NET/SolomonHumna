using System;
//using.System.IO;
using WeatherData.Repo;
namespace WeatherData.Model
{


    class WeatherCondition
    {
        //this is my duck wher the object must be instantinated

        /*float celsius = 0;
        float fahrenheit = 0;
        string userInputF {get; set;};
        string userInputC {get; set;}; 
        string answerYes {get; set;};
        string answerNo {get; set;};
        string answer {get; set;};
        bool noMore = false;   */

        //fields
        public int ChamceOfPreciptation{get; set;}
        public string Condition {get; set;}
         public int Humidity {get; set;}
        public int Visibility{get; set;}
        public int Temprature{get; set;}

        //constructors
        public WeatherCondition(string condition, int temprature, int preciptation, int humidity, int visibility)
        {   
            this.Condition = condition;
            this.Temprature = temprature;
            this.Humidity = humidity;
            this.ChamceOfPreciptation = preciptation;
            this.Visibility = visibility;

        }

        public WeatherCondition(){}
        protected IWeather _weather;    
        public WeatherCondition(IWeather weather)
        {
                    
                    _weather = weather;
                    
                
        } 

        //methods

        public void GenerateWeatherData()
        {
            Console.WriteLine ($"Todays's Weather is {_weather.condition}It is {_weather.temprature}°C  with {_weather.humidity}% of humidity. There is a {_weather.preciptation}% chance of precipitation with {_weather.visibility} miles of visibility." );
        }
        
        
    } 
        /*public void displayWeather()
        {
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
                    if (tempCelsius > 29)
                    {   
                        _weather.condition = "Hot";
                        _weather.temprature = tempCelsius;
                        _weather.humidity = humidity;
                        Console.WriteLine ($"Today's Weather is {_weather.condition}. It is {_weather.temprature}°C  with {_weather.humidity}% of humidity." );
                    }
                    else if (tempCelsius < 10  && humidity < 100)
                    {   
                        _weather.condition = "Cold!";
                        _weather.temprature = tempCelsius;
                        _weather.humidity = humidity;
                        Console.WriteLine ($"Today's Weather is {_weather.condition}. It is {_weather.temprature}°C with {_weather.humidity}% of humidity." );
                    }
                    else 
                    {   
                        _weather.condition = "Great!";
                        _weather.temprature = tempCelsius;
                        _weather.humidity = humidity;
                        Console.WriteLine ($"Today's Weather is {_weather.condition}. It is {_weather.temprature}°C with {_weather.humidity}% of humidity." );
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
                            
                            if (tempTomorrow > 29)
                            {   
                                _weather.condition = "Hot";
                                _weather.temprature = tempTomorrow;
                                _weather.humidity = humidity2;
                                Console.WriteLine ($"Tomorrow's Weather is {_weather.condition}. It is {_weather.temprature}°C  with {_weather.humidity}% of humidity." );
                            }
                            else if (tempTomorrow < 10  && humidity2 < 100)
                            {   
                                _weather.condition = "Cold!";
                                _weather.temprature = tempTomorrow;
                                _weather.humidity = humidity2;
                                Console.WriteLine ($"Tomorrow's Weather is {_weather.condition}. It is {_weather.temprature}°C with {_weather.humidity}% of humidity." );
                            }
                            else 
                            {  
                                _weather.condition = "Great!";
                                _weather.temprature = tempTomorrow;
                                _weather.humidity = humidity2;
                                Console.WriteLine ($"Tomorrow's Weather is {_weather.condition}. It is {_weather.temprature}°C with {_weather.humidity}% of humidity." );
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
        }*/


    
}

