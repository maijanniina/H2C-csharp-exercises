using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.Write("Give the first number! ");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
            int intValue = Convert.ToInt32(userInput);
            Console.Write("Give the second number! ");
            string userInput2 = Console.ReadLine();
            Console.WriteLine(userInput2);
            int intValue2 = Convert.ToInt32(userInput2);
            int sum = intValue + intValue2;
            int substraction = intValue - intValue2;
            int multi = intValue * intValue2;
            double average = Convert.ToDouble( intValue + intValue2 ) /2;
            Console.Write( intValue + " + " + intValue2 ); Console.Write( " = " + sum + "\n");
            Console.Write( intValue + "-" + intValue2 ); Console.Write( " = " + substraction + "\n");
            Console.Write( intValue + " * " + intValue2 ); Console.Write( " = " + multi + "\n");
            Console.Write( intValue + " / " + intValue2 ); Console.Write( " = " + average );
          

    }
  }
}
