using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      int first = Convert.ToInt32(Console.ReadLine());
      int second = Convert.ToInt32(Console.ReadLine());
      if (first > second)
      {
                Console.Write( first + " is grEater than " + second);
      }

      if (first < second)
      {
                Console.Write(first + " is less than " + second);
      }

      if (first == second)
      {
                Console.Write(first + " is equal to " + second);

      }
    }
  }
}
