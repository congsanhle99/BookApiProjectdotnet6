namespace BookApiProject.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Cannot more than 100 characters")]
        public string Name { get; set; }
        public virtual ICollection<BookCategory> BookCategories { get; set; }

    }
}
