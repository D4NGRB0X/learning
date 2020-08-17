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
            return countries;
        }
    }
}
