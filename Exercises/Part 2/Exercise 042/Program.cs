using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      int first = Convert.ToInt32(Console.ReadLine());
      int second = Convert.ToInt32(Console.ReadLine());
      
      int sum = first + second;

      int number = sum;
      double squareRoot = Math.Sqrt(number);
            
      Console.WriteLine(squareRoot);
    }
  }
}
