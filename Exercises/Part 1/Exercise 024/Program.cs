using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.Write("Confirm your speed:");
            string userInput = Console.ReadLine();
            int intValue = Convert.ToInt32(userInput);
            Console.Write("Your speed is " + intValue + "\n" );
            if (intValue > 120)
            {
                Console.Write("You are speeding! \n");
            } 
            else
            {
                Console.Write("You are not speeding, good! \n");
            } 
      
    }
  }
}
