using System;

namespace exercise_22
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
            Console.Write("Give the third number! ");
            string userInput3 = Console.ReadLine();
            Console.WriteLine(userInput3);
            int intValue3 = Convert.ToInt32(userInput3);
            double average = Convert.ToDouble( intValue + intValue2 + intValue3 ) /3;
            Console.WriteLine("The average is " + average);

    }
  }
}
