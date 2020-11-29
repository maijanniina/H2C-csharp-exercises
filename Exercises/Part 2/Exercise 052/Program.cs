using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      int numberStart = Convert.ToInt32(Console.ReadLine());
      int numberEnd = Convert.ToInt32(Console.ReadLine());
      PrintFromNumberToOne(numberStart, numberEnd);

    }

         // Write your method here:
          public static void PrintFromNumberToOne(int numberStart,int numberEnd)
          {
                while ( numberStart <= numberEnd)
                {
                    Console.WriteLine(numberStart);
                    numberStart++;
                }
        
          }

  }
}
