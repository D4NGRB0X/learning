using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() {12.3, 4.22, 17.19};
            grades.Add(22.45);

            double result = 0.0;
            foreach(double grade in grades){
                result += grade;
            }
            Console.WriteLine($"Average grade is {result/grades.Count:N2}.");

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
