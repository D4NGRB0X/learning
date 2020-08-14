using System;
using System.Collections.Generic;
using System.Linq;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thorrsday",
                "Friday",
                "Saturday",
                "Sunday",
            };


            /*while (true)
            {
                Console.WriteLine("Which day do you want to display?");
                Console.WriteLine("(Mon = 1, etc.) >");
                int dayIndex = int.Parse(Console.ReadLine());

                string chosenDay = daysOfWeek[dayIndex - 1];
                Console.WriteLine($"That day is {chosenDay}");

                if(chosenDay == "q")
                {
                    break;
                }
            }*/
            foreach(string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            daysOfWeek[3] = "Thursday";

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
