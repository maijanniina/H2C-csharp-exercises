using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a number: ");
            string userInput = Console.ReadLine();
            int intValue = Convert.ToInt32(userInput);
            Console.Write(intValue % 2 == 0 ? "Your integer ({0}) is even." : "Your integer ({0}) is odd.", intValue);

    }
  }
}
