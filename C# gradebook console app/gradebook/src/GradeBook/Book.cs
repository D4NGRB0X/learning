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

        public void AddLetterGrade(char letter){
            switch(letter){
                case 'A':
                    AddGrade(90.0);
                    break;
                
                case 'B':
                    AddGrade(80.0);
                    break;
                
                case 'C':
                    AddGrade(70.0);
                    break;
                
                default:
                    AddGrade(0.0);
                    break;
            }
        }

        public List<double> GetGrades(){
            return grades;
        }
        public double ComputeAverageGrade()
        {
            double result = 0.0;
            foreach (double grade in grades) // see also for(var i = 0; i boolean iterable.Count; i++)
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
            do //will always run once
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
            while(index < grades.Count) // will only run if condition evaluates to true
            {
                if(grades[index] == 42.1){
                    //break; stops loop and returns value
                    continue; // skips evaluation of item and continues trhough loop
                }
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
            result.Letter = ComputeLetterGrade(result.Average);

            return result;
        }

        public char ComputeLetterGrade(double average)
        {
            switch(average){
                
                case var d when d >=90.0:
                    return 'A';

                case var d when d >=80.0 && d <=90.0:
                    return 'B';
                
                case var d when d >=70.0 && d <=80.0:
                    return 'C';

                case var d when d >=60.0 && d <=70.0:
                    return 'D';
                
                default:
                    return 'F';
            }
        }
    }
}