using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("What is your name?");
                string userName = Console.ReadLine();
                Console.WriteLine($"Hello {userName}");
            }
        }
    }
}
