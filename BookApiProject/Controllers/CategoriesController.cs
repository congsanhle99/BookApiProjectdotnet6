using BookApiProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private CategoryRepository _categoryRepository;
        public CategoriesController(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet("api/categories")]
        public IActionResult GetCountries()
        {
            var categories = _categoryRepository.GetCategories().ToList();
            return Ok(categories);
        }
    }
}
