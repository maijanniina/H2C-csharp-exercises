using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give the first number! ");
            string userInput = Console.ReadLine(); Console.WriteLine(userInput);
            int intValue = Convert.ToInt32(userInput);
            Console.Write("Give the second number! ");
            string userInput2 = Console.ReadLine(); Console.WriteLine(userInput2);
            int intValue2 = Convert.ToInt32(userInput2);
            bool isFirstLargerThanSecond = intValue > intValue2;
            bool isFirstSmallerThanSecond = intValue < intValue2;
            bool truthValue = intValue == intValue2;
            if (isFirstLargerThanSecond)
            {
                Console.Write("The larger number is "+ intValue);
            }
            else if (isFirstSmallerThanSecond)
            {
                Console.WriteLine("The larger number is " + intValue2);
            }
            else if (truthValue)
            {
                Console.WriteLine("They are equal! ");
            }

    }
  }
}
