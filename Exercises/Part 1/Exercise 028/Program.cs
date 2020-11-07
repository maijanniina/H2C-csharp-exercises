using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("How old are you? ");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
            int intValue = Convert.ToInt32(userInput);
            if (intValue < 18)
            {
                Console.WriteLine("You're under age! ");
            }
            else if (intValue >= 18)
            {
                Console.WriteLine("You're an adult! ");
            }

    }
  }
}
