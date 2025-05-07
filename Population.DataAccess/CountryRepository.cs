<<<<<<< HEAD
// filepath: /Users/macbook/Documents/PopulationReportApp/Population.DataAccess/CountryRepository.cs
=======

using System.Collections.Generic;
>>>>>>> develop
using Population.Models;

namespace Population.DataAccess
{
    public class CountryRepository
    {
<<<<<<< HEAD
        private readonly List<Country> _countries = new()
        {
            new Country { Name = "USA", Population = 331000000 },
            new Country { Name = "India", Population = 1393409038 },
            new Country { Name = "Canada", Population = 38000000 }
        };
=======
        private List<Country> _countries = new List<Country>();
>>>>>>> develop

        public List<Country> GetAllCountries()
        {
            return _countries;
        }

        public void AddCountry(Country country)
        {
            _countries.Add(country);
        }
    }
}