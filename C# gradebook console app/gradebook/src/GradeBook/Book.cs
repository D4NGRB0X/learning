using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GradeBook
{
    public interface IBook
    {
        void AddGrade(double grade);
        Stats GetStats();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }
    public abstract class Book : NamedObject, IBook
    {
        private List<double> grades;
        public List<double> Grades { get => grades; set => grades = value; }

        protected Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;
        public abstract void AddGrade(double grade);
        public abstract Stats GetStats();
    }
    public class InMemoryBook : Book
    {

        public const string INSTRUCTOR = "Professor X"; // immutable read only field public allows it to be displayed but cannot be manipulated

        public InMemoryBook(string name) : base(name)
        {
            try
            {

                Grades = new List<double>();
                Name = name;
                //category;
            }
            catch (ArgumentException invalidNameExcaption)
            {
                Console.WriteLine(invalidNameExcaption.Message);
            }
        }


        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100) //left evaluates first
            {
                Grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }
        public override event GradeAddedDelegate GradeAdded;



        public List<double> GetGrades()
        {
            return Grades;
        }

        public override Stats GetStats()
        {
            var result = new Stats(Grades);

            return result;
        }


    }

    public class DiskBook : Book
    {
        
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }

        }

        public override Stats GetStats()
        {
            // var reader = File.ReadLines($"{Name}.txt");
            // var result = new Stats(reader.Cast<double>().ToList());
 
            Grades = new List<double>();
            using(var reader = File.OpenText($"{Name}.txt")){;
                var line = reader.ReadLine();
                while(line!= null){
                    var number = double.Parse(line);
                    Grades.Add(number);
                    line = reader.ReadLine();
                }
            }
            var result = new Stats(Grades);
            return result;
        }
    }
}

// Long form property creation
// private string name; 
// public string Name{
//     get{
//         return name;
//     }
//     set{
//         if(!String.IsNullOrEmpty(value)){
//         name = value;
//         }
//         else{
//             throw new ArgumentException($"Invalid {nameof(name)}");
//         }
//     }
// }

//readonly string category; //field can only be changed in constructor
