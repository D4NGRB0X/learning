using System;

namespace TopTenPopulations_ReadFromCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C: \Users\Thomas\Desktop\learning\Course_Files\C# Collections\Pop by Largest Final.csv";
            CSVReader reader = new CSVReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(9);

            foreach(Country country in countries)
            {
                Console.WriteLine($"{country.Population}: {country.Name}");
            }
        }
    }
}
