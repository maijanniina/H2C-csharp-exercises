using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.Write("Give a greeting: ");
            string answer = Console.ReadLine();
            Console.WriteLine(answer);
            Console.Write("Give one number: ");
            string userInput = Console.ReadLine();
            int intValue = Convert.ToInt32(userInput);
            Console.WriteLine(intValue);
            Console.Write("Give a double: ");
            userInput = Console.ReadLine();
            double doubleValue = Convert.ToDouble(userInput);
            Console.WriteLine(doubleValue);
            Console.Write("Give a boolean: ");
            string truth = "True"; 
            bool booleanValue = System.Convert.ToBoolean(truth);
            Console.WriteLine(booleanValue);
            Console.WriteLine("Your greeting: " + answer);
            Console.WriteLine("Your number is: " + intValue);
            Console.WriteLine("Your double is: " + doubleValue);
            Console.WriteLine("Your boolean is: " + booleanValue);

    }
  }
}
