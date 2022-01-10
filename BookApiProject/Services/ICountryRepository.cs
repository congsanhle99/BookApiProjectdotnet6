using BookApiProject.Models;

namespace BookApiProject.Services
{
    public interface ICountryRepository
    {

        // Get all COUNTRY 
        ICollection<Country> GetCountries();

        // Get COUNTRY by ID
        Country GetCountryById(int countryId);

        // Get COUNTRY of AUTHOR
         Country GetCountryOfAnAuthor(int authorId);

        // Get all AUTHOR from COUNTRY
        ICollection<Author> GetAuthorsFromCountry(int countryId);

        bool CountryExists(int countryId);  

    }
}
