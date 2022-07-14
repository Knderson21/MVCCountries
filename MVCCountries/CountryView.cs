using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }

        public void Display()
        {
            Console.WriteLine($"\nCountry: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}\nFlag Colors:");
            for(int i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                Console.WriteLine(DisplayCountry.Colors[i]);
            }
        }
    }
}
