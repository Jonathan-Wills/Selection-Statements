using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number");
            var userinput = int.Parse(Console.ReadLine());
            if (userinput < favNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else if (userinput > favNumber)
            {
                Console.WriteLine("Too High!");
            }
            else if (userinput == favNumber)
            {
                Console.WriteLine("wow, you actually got it right!");
            }
            else
            {
                Console.WriteLine("nevermind");
            }

            Console.WriteLine("What's your favorite school subject?");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "English":
                    Console.WriteLine("You have terrible taste in classes");
                    break;
                case "Math":
                    Console.WriteLine("I'm a big fan of math as well");
                    break;
                case "Social Studies":
                    Console.WriteLine("This is quite an interesting class");
                    break;
                case "Science":
                    Console.WriteLine("Science was always my favorite class too!");
                    break;
                case "Art":
                    Console.WriteLine("Oh, so you can draw and paint? that's awesome!");
                    break;
                default:
                    Console.WriteLine("Well that one was a little unexpected");
                    break;


            }
        }
    }
}
