using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TopTenPopulations_ReadFromCSV_LINQ
{
    class CSVReader
    {
        private string _csvFilePath; //field

        public CSVReader(string csvFilePath) //constructor using field
        {
            this._csvFilePath = csvFilePath;
        }

        public List<Country> ReadAllCountries() //method returning List of all country objects
        {
            List<Country> countries = new List<Country>();
            using (StreamReader reader = new StreamReader(_csvFilePath)) // < disposes of StreamReader and releases file once loop is complete 
            {
                reader.ReadLine(); //first call reads header

                string csvLine;
                while((csvLine = reader.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCSVLine(csvLine));
                }
            }
            return countries;
        }
    
        public Country ReadCountryFromCSVLine(string csvLine)
        {
            string[] data = csvLine.Split(',');
            string name;
            string code;
            string region;
            string populationAsText;
            switch (data.Length)
            {
                case 4:
                    name = data[0];
                    code = data[1];
                    region =data[2];
                    populationAsText = data[3];
                    break;

                case 5:
                    name = data[0]+","+data[1];
                    name = name.Replace("\"",null).Trim();
                    code = data[2];
                    region = data[3];
                    populationAsText = data[4];
                    break;
                default:
                    throw new Exception($"Can't parse country from csvLine: {csvLine}");
            }
            int.TryParse(populationAsText,out int population);
            return new Country(name, code, region, population);
                       
        }
    }
}
