using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
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
            double average = result / grades.Count;
            return average;
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

        public Stats GetStats(){
            var result = new Stats();
            result.Average = ComputeAverageGrade();
            result.High = getHighGrade();
            result.Low = getLowGrade();

            return result;
        }
        
    }
}