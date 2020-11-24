using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
       Console.WriteLine("Give numbers: ");
       int sum = 0;
       int givenNumbers = 0;
       int amount= 0;
       int average = 0;

           while(true)
           {
           
                int userInput = Convert.ToInt32(Console.ReadLine());

                if ( userInput == -1)

                {
                   Console.WriteLine("Thx! Bye! ");
                   Console.WriteLine("Sum " + sum);
                   Console.WriteLine("Numbers " + amount);
                   Console.WriteLine("average " + sum / amount);
                  
                   break;
                }

                if (userInput != -1) 

                {
                    sum += userInput;
                    amount = givenNumbers + 1;
                    givenNumbers++;
                    continue;

                }
          

           }
          
    }
  }
}
