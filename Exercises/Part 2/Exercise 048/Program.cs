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

           while(true)
           {
           
                int userInput = Convert.ToInt32(Console.ReadLine());

                if ( userInput == -1)

                {
                   Console.WriteLine("Thx! Bye! ");
                   Console.WriteLine(sum);
                   break;
                }

                if (userInput != -1) 

                {
                    sum += userInput;
                    givenNumbers++;
                    continue;

                }            
 

           }
          
    }
  }
}
