class Program
{
	static void Main(String[] args)
	{
		TempConverter temp = new TempConverter();
		temp.ConvertTemp();

			//user story
		//user must have an option to choose between celsius, and Fahrenheit
		//convert temprature between celsius and Fahrenheit
		//ask the user to do it again
		//if the user says "y" continue converting
		//the program ends when the user enter "n"


		//variables
		/*float celsius = 0;
		float fahrenheit = 0;
		var userInputF = "f";
		var userInputC = "c"; 
		var answerYes = "y";
		var answerNo = "n";
		var answer = "";

			//Ask the user which temprature types they want convert from?
		do{
			Console.WriteLine("Do yo want to convert unit of measurment? ");
			answer = Console.ReadLine();
			if(answer == answerYes){
				
				
				Console.WriteLine("Which type of temprature type you want convert? ");
				var tempType = Console.ReadLine();		
				if(tempType == userInputF) //checking the input information
				{
					Console.Write("Enter temp in fahrenheit ");
					var k = Convert.ToSingle(Console.ReadLine()); //convert the string into float
					celsius = ((k - 32)*5/9); //convert the 
					Console.WriteLine("The temp in Celsius is {0}",  celsius); //printout the result
				}
				else if(tempType == userInputC) // check the if the input is in celcius
				{
					Console.Write("Enter temprature in celsius "); // ask user to input the temprature
					var j = Convert.ToSingle(Console.ReadLine()); //convert the string to float
					fahrenheit = ((j * 9/5) +32); 
					Console.WriteLine("The temp in Fahrenheit is {0}",  fahrenheit); //printout the result
				}
				else
				{
					Console.WriteLine("You entered wrong data type!"); //exception check
				}
			}	
		}while(answer == answerNo);	
		Console.WriteLine("Have a good day!");*/
	}
}
