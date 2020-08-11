using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }


        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100) //left evaluates first
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"{grade} is not valid.");
            }
        }

        public List<double> GetGrades(){
            return grades;
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
            int index = 0;
            do
            {
                highGrade = Math.Max(grades[index], highGrade);
                index++;
            }
            while(index < grades.Count);
            return highGrade;
        }

        public double getLowGrade()
        {
            double lowGrade = double.MaxValue;
            int index = 0;
            while(index < grades.Count)
            {
                lowGrade = Math.Min(grades[index], lowGrade);
                index++;
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