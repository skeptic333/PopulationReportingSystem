
using System.Collections.Generic;
using Population.Models;

namespace Population.DataAccess
{
    public class CountryRepository
    {
        private List<Country> _countries = new List<Country>();

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