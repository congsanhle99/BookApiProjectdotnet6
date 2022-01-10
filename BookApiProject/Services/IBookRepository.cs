using BookApiProject.Models;

namespace BookApiProject.Services
{
    public interface IBookRepository
    {
        // get all book
        ICollection<Book> GetBooks();

        // get book by id
        Category GetBookById(int bookId);

        Category GetBook(string bookIsbn);
        decimal GetBookRating(int bookId);     
        bool BookExists(int bookId);
        bool BookExists(string bookIsbn);
        bool IsDuplicateIsbn(int bookId, string bookIsbn);
    }
}
