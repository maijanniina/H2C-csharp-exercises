using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
        {
        PrintStars(5);
        PrintStars(3);
        PrintStars(9);
        }
   

       public static void PrintStars(int number)
       {
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
            int printable = number;
            while(printable <= number * number) 
            {
                Console.Write("*");
                printable += number;
            }

            Console.WriteLine(" ");

       }
       

          public static void PrintSquare(int size)
          {
        
          }     
           
           
  

            public static void PrintRectangle(int width, int height)
            {

            }

            public static void PrintTriangle(int size)
            {

            }
  }
}
