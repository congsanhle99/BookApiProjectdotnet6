using BookApiProject.DTOs;
using BookApiProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountiesController : Controller
    {
        private ICountryRepository _countryRepository;
        public CountiesController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        // api/countries
        [HttpGet()]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(IEnumerable<CountryDTO>))]
        public IActionResult GetCountries()
        {
            var countries = _countryRepository.GetCountries().ToList();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var countriesDTO = new List<CountryDTO>();
            foreach (var country in countries)
            {
                countriesDTO.Add(new CountryDTO
                {
                    Id = country.Id,
                    Name = country.Name
                });
            }
            return Ok(countriesDTO);
        }

        // api/country/id
        [HttpGet("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(CountryDTO))]
        public IActionResult GetCountry(int id)
        {
            if (!_countryRepository.CountryExists(id))
                return NotFound();

            var country = _countryRepository.GetCountry(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var countryDTO = new CountryDTO()
            {
                Id = country.Id,
                Name = country.Name
            };     
            return Ok(countryDTO);
        }

        // api/country/authors/authorId
        [HttpGet("authors/{authorId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(CountryDTO))]
        public IActionResult GetCountryOfAnAuthor(int authorId)
        {
           var country = _countryRepository.GetCountryOfAnAuthor(authorId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var countryDTO = new CountryDTO()
            {
                Id = country.Id,
                Name = country.Name
            };
            return Ok(countryDTO);

        }
    }
}
