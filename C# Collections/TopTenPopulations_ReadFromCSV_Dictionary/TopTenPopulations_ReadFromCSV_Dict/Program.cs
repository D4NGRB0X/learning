using System;
using System.Collections.Generic;
using System.IO;


namespace TopTenPopulations_ReadFromCSV_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Thomas\Desktop\learning\Course_Files\C# Collections\Pop by Largest Final.csv";
            CSVReader reader = new CSVReader(filePath);

            Dictionary<string, Country> countries = reader.ReadAllCountries();
            Console.WriteLine("Please enter a country code: ");
            string userInput = Console.ReadLine();
            
            bool countryExsists = countries.TryGetValue(userInput.ToUpper(), out Country country);
            if(!countryExsists)
                Console.WriteLine($"Sorry, the country code you entered is invalid, {userInput}");
            else
                Console.WriteLine($"{country.Name} has a population of {country.Population}");
        }
    }
}
