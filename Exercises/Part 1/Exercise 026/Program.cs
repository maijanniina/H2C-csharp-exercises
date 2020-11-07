using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("What is your birth year?: ");
            string userInput = Console.ReadLine(); 
            Console.WriteLine(userInput);
            int intValue = Convert.ToInt32(userInput);
            if ( intValue <= 1900)
            {
                Console.Write("You're old!");
            }
              else if (intValue > 1901)
            {
                Console.Write("You're in the best age of your life!");
            }
    }
  }
}
