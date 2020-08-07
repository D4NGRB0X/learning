using System;
using System.Collections.Generic;

namespace GradeBook{
    class Book{

        List<double> grades;
        string name;

        public Book(string name){
            grades = new List<double>();
            this.name = name;
        }

         

        public void AddGrade(double grade){
            if(grade >= 0 && grade <= 100){
                grades.Add(grade);
            }
            else{
                Console.WriteLine($"{grade} is not valid.");
            }
        }

        public double ComputeAverageGrade(){
            double result = 0.0;
            foreach(double grade in grades){
                result += grade;
            }
            return result/grades.Count;
        }

        /*public List<double> get_Grades(){
           Console.WriteLine(grades);
        }*/

    }
}