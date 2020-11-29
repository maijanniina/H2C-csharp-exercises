using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      int number = Convert.ToInt32(Console.ReadLine());
      PrintUntilNumber(number);

    }

        // Write your method here:
        public static void PrintUntilNumber(int PrintUntilNumber) 
        {
            int i = 0;
            while (i <= PrintUntilNumber)
            {
                Console.WriteLine(i);
                i++;

            }
        }
  }
}
