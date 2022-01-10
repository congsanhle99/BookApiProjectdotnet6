using BookApiProject.Data;
using BookApiProject.Models;

namespace BookApiProject.Services
{
    public class CountryRepository : ICountryRepository
    {
        private AppDbContext _appDbContext;
        public CountryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // Check exist
        public bool CountryExists(int countryId)
        {
            return _appDbContext.Countries.Any(c => c.Id == countryId);
        }

        // get all country
        public ICollection<Country> GetCountries()
        {
            return _appDbContext.Countries
                .OrderBy(c => c.Name)
                .ToList();
        }

        // get country by Id
        public Country GetCountryById(int countryId)
        {
            return _appDbContext.Countries
                .Where(c => c.Id == countryId)
                .FirstOrDefault();
        }

        //
        public ICollection<Author> GetAuthorsFromCountry(int countryId)
        {
            return _appDbContext.Authors
                .Where(c => c.Country.Id == countryId)
                .ToList();
        }


        public Country GetCountryOfAnAuthor(int authorId)
        {
           return _appDbContext.Authors
                .Where(a => a.Id == authorId)
                .Select(c => c.Country)
                .FirstOrDefault();
        }
    }
}
