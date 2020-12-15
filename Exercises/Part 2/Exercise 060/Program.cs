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
        PrintSquare(4);
        PrintRectangle(17, 3);
        }
   

            public static void PrintStars(int number)
            {
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
                int n = number;
                while(n <= number * number) 
                {
                Console.Write("*");
                n += number;
                }

                Console.WriteLine(" "); 

            }
        

          public static void PrintSquare(int size)
          {
           int n = size;
           while(n <= size * size * size)
           {

            Console.Write("*");
            n += size;

           }

           Console.WriteLine(" "); 
          }  
          
           
        

        public static void PrintRectangle(int width, int height)
        {
            int n = height;
           while( n < width )
           {
             Console.Write("*");
              n += width;

           }

            Console.WriteLine(" "); 
        }

        public static void PrintTriangle(int size)
        {

        }
  }
}
