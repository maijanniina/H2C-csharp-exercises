using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give the first string: ");
            string userWord = Console.ReadLine();
            Console.WriteLine(userWord);
            string a = userWord;
       Console.Write("Give the second string: ");
            string usermessage = Console.ReadLine();
            string b = usermessage;
            Console.WriteLine(usermessage);
     if ( a == b )
     {
                Console.Write("Echo! ");
     }
     else
     {
                Console.Write("Nope! ");
     }

    }
  }
}
