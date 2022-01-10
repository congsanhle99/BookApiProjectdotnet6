using BookApiProject.Data;
using BookApiProject.Models;

namespace BookApiProject.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public ICollection<Category> GetCategories()
        {
            return _appDbContext.Categories.OrderBy(c => c.Name).ToList();
        } 
        public Category GetCategoryById(int categoryId)
        {
            return _appDbContext.Categories.Where(c => c.Id == categoryId).FirstOrDefault();
        }

        public ICollection<Book> GetAllBooksForCategory(int categoryId)
        {
            return _appDbContext.BookCategories.Where(c => c.CategoryId == categoryId).Select(b => b.Book).ToList();
        }

        public ICollection<Category> GetAllCategoriesForABook(int bookId)
        {
            return _appDbContext.BookCategories.Where(b => b.BookId == bookId).Select(c => c.Category).ToList();
        }
        public bool CategoryExists(int categoryId)
        {
            return _appDbContext.Categories.Any(c => c.Id == categoryId);
        }

    }
}
