using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class CountryController
    {

        //properties
        public List<Country> CountryDb { get; set; }

        //constructor
        public CountryController()
        {
            CountryDb = new List<Country>()
            {
                new Country("Canada", "North America", new List<string>{"Red", "White"}),
                new Country("Japan", "Asia", new List<string>{"Red", "White"}),
                new Country("China", "Asia", new List<string>{"Red", "Yellow"}),
                new Country("South Korea", "Asia", new List<string>{"Red", "Blue", "Black", "White"}),
            };
        }

        //methods
        public void CountryAction(Country c)
        {
            CountryView seeCountry = new CountryView(c);
            seeCountry.Display();
        }

        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app.");
            bool runProgram = true;
            
            while (runProgram)
            {
                CountryListView listOfCountries = new CountryListView(CountryDb);
                Console.WriteLine("Please select a country from the following list:");
                listOfCountries.Display();

                bool getNumber = true;
                while (getNumber)
                {
                    Console.WriteLine($"Please select a number 1-4:");
                    int input = int.Parse(Console.ReadLine().Trim());                    
                    if (input >= 1 && input < 5)
                    {
                        CountryAction(CountryDb[input - 1]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That's not a valid option");
                    }
                }
                
                
                Console.WriteLine("\nWould you like to learn about another country? y to continue, any key to quit");
                string response = Console.ReadLine();

                if (response != "y")
                {
                    runProgram = false;
                }
            }
            Console.WriteLine("\nGoodbye!");

        }




    }
}
