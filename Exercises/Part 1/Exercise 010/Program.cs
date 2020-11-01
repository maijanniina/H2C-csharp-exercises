using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("I will tell a story, but I need some information.\n" + "Give a name for main character:");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.Write("Give the character a profession:");
            string answer = Console.ReadLine();
            Console.WriteLine("Here is the story:\n" + "Once upon a time there was a " + answer + "called " + name);
            Console.WriteLine("On her way to work, " + name + "often pondered what being " + answer + "meant to them.");
            Console.WriteLine("When you work as a " + answer + " you meet interesting people.\n" + name + " enjoys their work as " + answer + ", The end.");
        }
    }
}
