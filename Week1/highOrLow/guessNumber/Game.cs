class Game
{
    // Variables
	    Random rand = new Random();
		int targetNumber;
		int guessNumber = -1;
		int roundCount = 0;
		public string guessString {get; set;}= "";

	
	//constructos
   /* public Game()
    {
        targetNumber = rand.Next(11);
    }

    //setter
    public void setGuessNumber(int _guessNumber)
    {
        if(_guessNumber > 0)
        this.guessNumber =_guessNumber;
    }
    public int getNumber(){
        return this.guessNumber;
    }
*/
        //methods
    public int PlayGame()
    {
        roundCount = 0;
        
        do {
			//roundCount = roundCount + 1;
			//roundCount += 1;
			roundCount++;

			Console.Write( "Please enter a guess between -1 and 11: " );
			guessString = Console.ReadLine();

			guessNumber = Int32.Parse( guessString );

			if( guessNumber == targetNumber )
			{
				Console.WriteLine( "Hey, Nice Job!" );
			}
		
			else if( guessNumber > targetNumber )
			{
				Console.WriteLine( "Oops, too high!" );
			}
	
			else 
			{
				Console.WriteLine( "Oops, too low!" );
			}
		} while ( guessNumber != targetNumber );
        return roundCount;
    }    
}