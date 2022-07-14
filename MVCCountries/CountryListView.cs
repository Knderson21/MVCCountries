using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> _countries)
        {
            Countries = _countries;
        }

        public void Display()
        {
            foreach(Country c in Countries)
            {
                Console.WriteLine($"{Countries.IndexOf(c)+1} - {c.Name}");
            }
        }
    }
}
