using BookApiProject.Models;

namespace BookApiProject.Services
{
    public interface IAuthorRepository
    {
        // get all author
        ICollection<Author> GetAuthors();

        // get author by Id
        Author GetAuthorById(int authorId);

        // get all author of book
        ICollection<Author> GetAllAuthorsOfABook(int bookId);

        // get all Book of a author
        ICollection<Book> GetAllBooksByAAuthor(int authorId);

        bool AuthorExists(int authorId);  
    }
}
