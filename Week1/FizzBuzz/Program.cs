
class Program
{
    static void Main(string[] args)
    {   
       /*int num = 21;
        int Fizz = 3;
        int Buzz= 5;
        int FizzBuzz = 9;
        int i = 1;*/
    
       /* int counter = 0;
       for (int i = 0; i < num; i++)
        {
            counter = 0;
           /*  if(i % 3 == 0 && i % 5 == 0)
            {
                System.Console.Write("FizzBuzz");
            }
           if(i % Fizz == 0)
            {
                System.Console.WriteLine("Fizz");
                counter++;
            }
            if(i % Buzz == 0)
            {
                System.Console.WriteLine("Buzz");
                counter++;
            }
            if(i % FizzBuzz == 0)
            {
                System.Console.WriteLine("FizzBuzz");
            }
            else
            {
                System.Console.WriteLine(i);
            }
        }  
    */
       /* while(i <= num)
        {
            if(i % Fizz == 0)
            {
                System.Console.WriteLine("Fizz");
                i++;
            }
            if(i % Buzz == 0)
            {
                System.Console.WriteLine("Buzz");
                i++;
            }
            if(i % FizzBuzz == 0)
            {
                System.Console.WriteLine("FizzBuzz");
                i++;
            }
            else
            {
                System.Console.WriteLine(i);
            }
            i++;
        
        }*/

        //using dictionary
        Dictionary<int, string> wordVals = new Dictionary<int, string>();
        wordVals.Add (3, "Fizz");
        wordVals.Add (5, "Buzz" );
        wordVals.Add (7, "Bang");
        wordVals.Add (9, "Dang");

       
        int counter = 0; 
        for (int i = 1; i <= 25; i++)
        {
            counter = 0;
            foreach (KeyValuePair<int, string> x in wordVals)
            {
                if(i % x.Key == 0){
                    Console.Write(x.Value);
                    counter++;
                }
                
            }
            if (counter == 0)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    
    }
}
