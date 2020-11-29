using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      int numerator = Convert.ToInt32(Console.ReadLine());
      int deminator = Convert.ToInt32(Console.ReadLine());
      Division(numerator,deminator);

    }

        // Write your method here:
        public static void Division(int numerator, int denominator)
        {
            double division = Convert.ToDouble(numerator)/denominator;
            Console.WriteLine(division);
        }

  }
}
