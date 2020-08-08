using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {

        private List<double> grades;
        private string name;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }



        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"{grade} is not valid.");
            }
        }

        public double ComputeAverageGrade()
        {
            double result = 0.0;
            foreach (double grade in grades)
            {
                result += grade;
            }
            return result / grades.Count;
        }

        public double getHighGrade()
        {
            double highGrade = double.MinValue;
            foreach (var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
            }
            return highGrade;
        }

        public double getLowGrade()
        {
            double lowGrade = double.MaxValue;
            foreach (var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
            }
            return lowGrade;
        }

        public void showStats()
        {
            Console.WriteLine($"Average grade is {ComputeAverageGrade():N2}.");
            Console.WriteLine($"Highest grade is {getHighGrade():N2}.");
            Console.WriteLine($"Lowest grade is {getLowGrade():N2}.");
        }
    }
}