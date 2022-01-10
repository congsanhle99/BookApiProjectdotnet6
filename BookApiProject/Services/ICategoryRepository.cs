using BookApiProject.Models;

namespace BookApiProject.Services
{
    public interface ICategoryRepository
    {
        // get all category
        ICollection<Category> GetCategories();

        // get category by id
        Category GetCategory(int categoryId);

        //get category for a book
        ICollection<Category> GetAllCategoriesForABook(int bookId);

        // get all book for a category
        ICollection<Book> GetAllBooksForCategory(int categoryId);

        // Check category exist
        bool CategoryExists(int categoryId);
    }
}
