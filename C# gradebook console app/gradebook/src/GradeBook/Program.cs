using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("SCI");
            var quit = false;
            while(!quit){
                Console.WriteLine("Please enter a grade or q to quit and compute.");
                var userInput = Console.ReadLine();
                if(userInput == "q"){
                    quit=true;
                }
                else {
                var grade = double.Parse(userInput);
                book.AddGrade(grade);}
                
            };

            var stats = book.GetStats();
        
            Console.WriteLine($"Lowest grade = {stats.Low}");
            Console.WriteLine($"Highestest grade = {stats.High}");
            Console.WriteLine($"Average grade = {stats.Average}");
            Console.WriteLine($"Overall letter grade is {stats.Letter}");
        }
    }

}
