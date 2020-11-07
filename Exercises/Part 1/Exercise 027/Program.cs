using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a number: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
            int intValue = Convert.ToInt32(userInput);
            if (intValue >= 0)
            {
                Console.WriteLine("It is positive ");
            }
            else if (intValue < -1)
            {
                Console.WriteLine("It is not positive ");
            }

    }
  }
}
