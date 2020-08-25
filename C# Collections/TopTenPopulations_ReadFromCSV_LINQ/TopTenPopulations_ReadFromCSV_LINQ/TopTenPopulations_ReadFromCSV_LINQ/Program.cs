using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace TopTenPopulations_ReadFromCSV_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Thomas\Desktop\learning\Course_Files\C# Collections\Pop by Largest Final.csv";
            CSVReader reader = new CSVReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            Country lilliput = new Country("Lilliput","LIL","Fiction",2_000_000);
            int lilliputIndex = countries.FindIndex(country => country.Population < lilliput.Population);
            countries.Insert(lilliputIndex, lilliput);
            countries.RemoveAt(lilliputIndex);

            foreach(Country country in countries.Where(x=>!x.Name.Contains(',')).Take(20).OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{country.Population}: {country.Name}");

            }

            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
