using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
       int countSum = 0;

       while (true) 
       {

            Console.WriteLine("Give a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0 )
            {
                   break;
            }

            if (number <0)
            {
                        
                countSum = countSum + 1;
          
            }

            if (number >0)
            {

                    countSum = countSum + 1;

            }
            
       }

       Console.WriteLine("Total amount of numbers " + countSum);
    }
  }
}
