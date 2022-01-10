using BookApiProject.Models;

namespace BookApiProject.Services
{
    public interface IReviewRepository
    {
        // get all review
        ICollection<Review> GetReviews();

        // get review by Id
        Review GetReviewById(int reviewId);

        // get all review of a book
        ICollection<Review> GetAllReviewsOfABook(int bookId);

        // get all review of a Book
        Book GetBookOfAReview(int reviewId);

        bool ReviewExists(int reviewId);
    }
}
