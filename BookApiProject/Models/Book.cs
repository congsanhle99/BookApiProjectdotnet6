namespace BookApiProject.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Must be between 3 and 20 characters")]
        public string  Isbn { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Cannot more than 200 characters")]
        public string Title { get; set; } 
        public DateTime? DatePublished { get; set; }
        public virtual ICollection<Review> Reviews { get; set;}
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<BookCategory> BookCategories { get; set; }

    }
}
