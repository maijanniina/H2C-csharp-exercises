using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
        int sum1 = 0;
        int sum2 = 0;
        int amount = 0;
        int amount1 = 0;

        while(true)
        {
                Console.WriteLine("Give a number" );
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }

                if (number < 0)
                {
                    sum1 = sum1 + number; 
                    amount = amount + 1;
                }

                if (number > 0)
                {
                    sum2 = sum2 + number; 
                    amount1 = amount1 + 1;
                }
        }

        Console.WriteLine("Total amount of numbers: " + (amount + amount1)); Console.Write("& the sum of the numbers: " + (sum1 + sum2));
      
    }
  }
}
