using BookApiProject.Models;

namespace BookApiProject.Services
{
    public interface IReviewerRepository
    {
        // get all reviewer
        ICollection<Reviewer> GetReviewers();

        // get reviewer by Id
        Reviewer GetReviewerById(int reviewerId);

        // get all review by single reviewer
        ICollection<Review> GetAllReviewsByAReviewer(int reviewerId);

        // get review of a reviewer
        Reviewer GetReviewerOfAReviewer(int reviewId);

        bool ReviewerExists(int reviewerId);
    }
}
