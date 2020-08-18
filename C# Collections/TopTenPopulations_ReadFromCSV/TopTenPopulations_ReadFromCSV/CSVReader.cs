using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TopTenPopulations_ReadFromCSV
{
    class CSVReader
    {
        private string _csvFilePath; //field

        public CSVReader(string csvFilePath) //constructor using field
        {
            this._csvFilePath = csvFilePath;
        }

        public Country[] ReadFirstNCountries(int nCountries) //method returning Array of country objects that is length n
        {
            Country[] countries = new Country[nCountries];
            using (StreamReader reader = new StreamReader(_csvFilePath)) // < disposes of StreamReader and releases file once loop is complete 
            {
                reader.ReadLine(); //first call reads header

                for(int line = 0; line < nCountries; line++)
                {
                    string csvLine = reader.ReadLine(); 
                    countries[line] = ReadCountryFromCSVLine(csvLine);
                }
            }
            return countries;
        }
    
        public Country ReadCountryFromCSVLine(string csvLine)
        {
            string[] data = csvLine.Split(',');

            string name = data[0];
            string code = data[1];
            string region = data[2];
            int population = int.Parse(data[3]);

            return new Country(name, code, region, population);
        }
    }
}
