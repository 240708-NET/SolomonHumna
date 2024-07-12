class TempConverter
{
        //user story
		//user must have an option to choose between celsius, and Fahrenheit
		//convert temprature between celsius and Fahrenheit
		//ask the user to do it again
		//if the user says "y" continue converting
		//the program ends when the user enter "n"


        //variables
		float celsius = 0;
		float fahrenheit = 0;
		string userInputF {get; set;}= "f";
		string userInputC {get; set;}= "c"; 
		string answerYes {get; set;}= "y";
		string answerNo {get; set;}= "n";
		string answer {get; set;}= "";
        bool noMore = false;


            //method
        public void ConvertTemp(){

        
            //Ask the user which temprature types they want convert from?
            do{ //loop again
                
               do{        
                        Console.WriteLine("Which type of temprature type you want convert? ");
                        var tempType = Console.ReadLine().ToLower();		
                        if(tempType == userInputF) //checking the input information
                        {
                            Console.Write("Enter temp in fahrenheit ");
                            var k = Convert.ToSingle(Console.ReadLine()); //convert the string into float
                            celsius = ((k - 32)*5/9); //calculate to convert
                            Console.WriteLine("The temp in Celsius is {0}",  celsius); //printout the result
                        }
                        else if(tempType == userInputC) // check the if the input is in celcius
                        {
                            Console.Write("Enter temprature in celsius "); // ask user to input the temprature
                            var j = Convert.ToSingle(Console.ReadLine()); //convert the string to float
                            fahrenheit = ((j * 9/5) +32); //calculate the conversion
                            Console.WriteLine("The temp in Fahrenheit is {0}",  fahrenheit); //printout the result
                        }
                        else
                        {
                            Console.WriteLine("You entered wrong data type!"); //exception check
                        }      
                       Console.WriteLine("Do you want to check again? ");
                        answer = Console.ReadLine();
                    
                }while (answer == answerYes.ToLower());
                break;   

            }while(answer == answerNo.ToLower());
        }

}