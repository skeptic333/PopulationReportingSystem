namespace Population.Models
{
    public class Country
    {
        public required string Name { get; set; }
        public long Population { get; set; }
    }
<<<<<<< HEAD
}

namespace Population.DataAccess.Repositories
{
    public class CountryRepository
    {
        private readonly List<Population.Models.Country> _countries = new()
        {
            new Population.Models.Country { Name = "USA", Population = 331000000 },
            new Population.Models.Country { Name = "India", Population = 1393409038 },
            new Population.Models.Country { Name = "Canada", Population = 38000000 }
        };

        public List<Population.Models.Country> GetAllCountries()
        {
            return _countries;
        }
    }
=======
>>>>>>> develop
}