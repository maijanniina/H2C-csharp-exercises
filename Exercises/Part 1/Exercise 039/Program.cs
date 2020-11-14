using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
       int sum1 = 0;
       int sum2 = 0;
       
       while (true)
       {
            Console.Write("Give a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                    break;
            }

            if ( number < 0)
            {
                    sum1 = sum1 + number;
            }

            if ( number > 0)
            {
                    sum2 = sum2 + number;
            }
       }

        Console.WriteLine("Total sum of numbers: " + (sum1 + sum2));
    }

  }
}
