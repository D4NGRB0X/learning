using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace TopTenPopulations_ReadFromCSV_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Thomas\Desktop\learning\Course_Files\C# Collections\Pop by Largest Final.csv";
            CSVReader reader = new CSVReader(filePath);

            Dictionary<string, List<Country>> countries = reader.ReadAllCountries();
            foreach(string region in countries.Keys)
            {
                Console.WriteLine(region);
            }
            Console.WriteLine("Please select a region from the list above");
            string userInputRegion = Console.ReadLine();

            if (countries.ContainsKey(userInputRegion))
            {
                Console.WriteLine($"The 10 most populus countries in {userInputRegion} are :");
                foreach(Country country in countries[userInputRegion].Take(10))
                {
                    Console.WriteLine($"{country.Name} with {country.Population}.");
                }
            }
            else
            {
                Console.WriteLine($"{userInputRegion} is not a valid region.");
            }
            
        }
    }
}
