using System;
using System.Collections.Generic;
using System.IO;


namespace TopTenPopulations_ReadFromCSV_List_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Thomas\Desktop\learning\Course_Files\C# Collections\Pop by Largest Final.csv";
            CSVReader reader = new CSVReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            reader.RemoveCommaCountries(countries);
            Console.WriteLine("Please enter number of countries to display:");
            bool userInputIsInt = int.TryParse(Console.ReadLine(),out int userInput);
            if(!userInputIsInt || userInput <= 0)
                {
                    Console.WriteLine("please enter a number greater than 0. Exiting.");
                    return;
                }

            //foreach(Country country in countries)
            //int maxDisplayedItems = Math.Min(userInput,countries.Count);
            //for (int index = 0; index < maxDisplayedItems; index++)
            //int maxDisplayedItems = userInput;
            //for (int index = countries.Count -1 ; index >= 0; index--)
            int maxDisplayedItems = userInput;
            for (int index = 0; index < countries.Count ; index++)
            {

                //int displayIndex = countries.Count - 1 - index;
                if(index > 0 && (index % maxDisplayedItems == 0))
                {
                    Console.WriteLine("Press any key continue or q to quit.");
                    if (Console.ReadLine() == "q")
                        break;
                }
                Country country = countries[index];
                Console.WriteLine($"{index + 1} {country.Population}: {country.Name}");

            }
        }
    }
}
