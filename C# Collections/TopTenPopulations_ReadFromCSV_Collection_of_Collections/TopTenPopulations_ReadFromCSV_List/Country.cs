﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TopTenPopulations_ReadFromCSV_List
{
    class Country
    {
        public string Name { get; }
        public string Code { get; }
        public string Region { get; }
        public int Population { get; }

        public Country(string name, string code, string region, int population)
        {
            this.Name = name;
            this.Code = code;
            this.Region = region;
            this.Population = population;
        }
    }
}