using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.Write("Give the first number! ");
            string userInput = Console.ReadLine();
            int intValue = Convert.ToInt32(userInput);
            Console.Write("Give the second number! ");
            string userInput2 = Console.ReadLine();
            int intValue2 = Convert.ToInt32(userInput2);
            Console.WriteLine("The sum is " + (intValue + intValue2));

    }
  }
}
