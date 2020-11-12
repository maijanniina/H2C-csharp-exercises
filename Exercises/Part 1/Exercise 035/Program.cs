using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
     while(true)
     {
        Console.WriteLine("Give a number: ");
         int command = Convert.ToInt32(Console.ReadLine());
            if (command == 42)
            {
                   break;
            }


            Console.WriteLine("You gave " + command);
      }

     Console.WriteLine("This number wins!");
    }
  }
}
