using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give your percent [0 - 100]: ");
            string userInput = Console.ReadLine(); Console.WriteLine(userInput);
            int intValue = Convert.ToInt32(userInput);
            if (intValue < 0 )
            {
                Console.Write("Impossible ");
            }
            else if ( intValue >= 0 && intValue <= 49 )
            {
                Console.Write("Fail ");
            }
            else if (intValue >= 50 && intValue <= 59)
            {
                Console.Write("Grade 1 ");
            }
            else if (intValue >= 60 && intValue <= 69)
            {
                Console.Write("Grade 2 ");
            }
            else if ( intValue >= 70 && intValue <= 79)
            {
                Console.Write("Grade 3 ");
            }
            else if ( intValue >= 80 && intValue <= 89)
            {
                Console.Write("Grade 4 ");
            }
            else if ( intValue >= 90 && intValue <= 100)
            {
                Console.Write("Grade 5 ");
            }
            else if ( intValue > 100)
            {
                Console.Write("Outstanding! ");
            }
    }
  }
}
