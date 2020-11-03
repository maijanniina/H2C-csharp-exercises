using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.Write("Give the first number! ");
          string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
            int intValue = Convert.ToInt32(userInput);
            Console.Write("Give the second number! ");
            string userInput2 = Console.ReadLine();
            Console.WriteLine(userInput2);
            int intValue2 = Convert.ToInt32(userInput2);
            double average = Convert.ToDouble( intValue + intValue2 ) /2;
            Console.WriteLine("The average is " + average);

    }
  }
}
