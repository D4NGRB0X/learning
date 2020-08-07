using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("SCI");
            book.AddGrade(89.5);
            book.AddGrade(91.5);
            book.AddGrade(95.75);
            book.AddGrade(100);

            //Console.WriteLine($"Grades = {book.get_Grades()}");
            Console.WriteLine($"Average grade is {book.ComputeAverageGrade():N2}.");
        }
    }

}
