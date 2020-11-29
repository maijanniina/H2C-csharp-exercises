using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
    Console.WriteLine("How many times? ");
    int UserInput = Convert.ToInt32(Console.ReadLine());
     PrintPhrase(UserInput);
    
    }

          // Write your method here:
           public static void PrintPhrase(int numOfTimes)       
           {    
                int i = 0;
                while ( i < numOfTimes)
                {
                    Console.WriteLine("In a hole in the ground there lived a method"); 
                    i++;
                }
           }

           
    
  }
}
