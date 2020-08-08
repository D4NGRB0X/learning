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
            book.AddGrade(83.25);
            book.AddGrade(65.5);
            book.AddGrade(74);
            book.showStats();
        }
    }

}
