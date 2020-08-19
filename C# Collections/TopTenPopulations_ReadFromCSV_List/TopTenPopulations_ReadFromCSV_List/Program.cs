using System;
using System.Collections.Generic;
using System.IO;


namespace TopTenPopulations_ReadFromCSV_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Thomas\Desktop\learning\Course_Files\C# Collections\Pop by Largest Final.csv";
            CSVReader reader = new CSVReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            foreach(Country country in countries)
            {
                Console.WriteLine($"{country.Population}: {country.Name}");
            }
        }
    }
}
