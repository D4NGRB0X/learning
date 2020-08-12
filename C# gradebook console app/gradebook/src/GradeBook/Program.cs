using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("Adam","SCI");           
            while(true){
                Console.WriteLine("Please enter a grade or q to quit and compute.");
                var userInput = Console.ReadLine();
                if(userInput == "q"){
                    break;
                }
                try {
                var grade = double.Parse(userInput);
                book.AddGrade(grade);
                }
                catch(ArgumentException invalidGradeException){
                    Console.WriteLine(invalidGradeException.Message);
                }
                catch(FormatException invalidFormatException){
                    Console.WriteLine(invalidFormatException.Message);
                }
                finally{
                    Console.WriteLine("*****");//This will run no matter what
                }
                
            };

            var stats = book.GetStats();

            Console.WriteLine(Book.INSTRUCTOR);
            Console.WriteLine($"Lowest grade = {stats.Low}");
            Console.WriteLine($"Highestest grade = {stats.High}");
            Console.WriteLine($"Average grade = {stats.Average}");
            Console.WriteLine($"Overall letter grade is {stats.Letter}");
        }
    }

}
