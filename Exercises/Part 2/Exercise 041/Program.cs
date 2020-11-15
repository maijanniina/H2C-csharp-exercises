using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give a number ");
      int userInput = Convert.ToInt32(Console.ReadLine());
      
      int sum = userInput * userInput;

      Console.WriteLine(sum);
      
    }
  }
}
