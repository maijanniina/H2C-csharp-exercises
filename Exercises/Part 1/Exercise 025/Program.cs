using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a number: ");
            string userInput = Console.ReadLine();
            int intValue = Convert.ToInt32( userInput ); Console.WriteLine(userInput);
            if (intValue == 1984)
            {
                Console.WriteLine("Orwell");
            }
    }
  }
}
