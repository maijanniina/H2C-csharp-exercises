﻿using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      int number = 86400;
            Console.Write("How many days? ");
            string userInput = Console.ReadLine();
            int intValue = Convert.ToInt32(userInput);
            Console.WriteLine(number * intValue);

    }
  }
}
