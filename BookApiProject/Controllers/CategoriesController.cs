using BookApiProject.DTOs;
using BookApiProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private ICategoryRepository _categoryRepository;
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        // api/categories
        [HttpGet()]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(IEnumerable<CategoryDTO>))]
        public IActionResult GetCategories()
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categories = _categoryRepository.GetCategories().ToList();
            var categoriesDTO = new List<CategoryDTO>();
            foreach (var category in categories)
            {
                categoriesDTO.Add(new CategoryDTO
                {
                    CategoryId = category.Id,
                    CategoryName = category.Name
                });
            }
            return Ok(categoriesDTO);
        }

        // api/categories/id
        [HttpGet("{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(CategoryDTO))]
        public IActionResult GetCountry(int id)
        {
            if (!_categoryRepository.CategoryExists(id))
                return NotFound();

            var category = _categoryRepository.GetCategoryById(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoryDTO = new CategoryDTO()
            {
                CategoryId = category.Id,
                CategoryName = category.Name
            };
            return Ok(categoryDTO);
        }

        // api/categories/books/authorId
        [HttpGet("books/{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(IEnumerable<CategoryDTO>))]
        public IActionResult GetAllCategoriesForABook(int id)
        {
            // TO DO - 
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categories = _categoryRepository.GetAllCategoriesForABook(id);
            var categoriesDTO = new List<CategoryDTO>();
            foreach (var category in categories)
            {
                categoriesDTO.Add(new CategoryDTO()
                {
                    CategoryId = category.Id,
                    CategoryName = category.Name
                });
            }
            return Ok(categoriesDTO);
        }

        // TO DO - All book for category
        // api/books/category/authorId
        /*[HttpGet("category/{id}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(CategoryDTO))]
        public IActionResult GetAllBooksForCategory(int id)
        {
            // TO DO - 
            
        }*/
    }
}
