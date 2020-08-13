using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Stats
    {
        public double High;
        public double Low;
        public double Average
        {
            get;
        }
        public char Letter
        {
            get
            {

                switch (Average)
                {

                    case var d when d >= 90.0:
                        return 'A';

                    case var d when d >= 80.0 && d <= 90.0:
                        return 'B';

                    case var d when d >= 70.0 && d <= 80.0:
                        return 'C';

                    case var d when d >= 60.0 && d <= 70.0:
                        return 'D';

                    default:
                        return 'F';
                }

            }
        }

        public Stats(List<double> grades)
        {
            Average = ComputeAverageGrade(grades);
            High = getHighGrade(grades);
            Low = getLowGrade(grades);
        }

        public double ComputeAverageGrade(List<double> grades)
        {
            double result = 0.0;
            foreach (double grade in grades) // see also for(var i = 0; i boolean iterable.Count; i++)
            {
                result += grade;
            }
            double average = result / grades.Count;
            return average;
        }

        public double getHighGrade(List<double> grades)
        {
            double highGrade = double.MinValue;
            int index = 0;
            do //will always run once
            {
                highGrade = Math.Max(grades[index], highGrade);
                index++;
            }
            while (index < grades.Count);
            return highGrade;
        }
        public double getLowGrade(List<double> grades)
        {
            double lowGrade = double.MaxValue;
            int index = 0;
            while (index < grades.Count) // will only run if condition evaluates to true
            {
                if (grades[index] == 42.1)
                {
                    //break; stops loop and returns value
                    continue; // skips evaluation of item and continues trhough loop
                }
                lowGrade = Math.Min(grades[index], lowGrade);
                index++;
            }
            return lowGrade;
        }


        /* public void AddLetterGrade(char letter)
         { //could also be AddGrade with different signature C# can differentiate based on signature "Method Overloading"
             switch (letter)
             {
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
         }*/

    }
}