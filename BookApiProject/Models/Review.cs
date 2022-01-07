namespace BookApiProject.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 6, ErrorMessage ="Must be between 6 and 200 characters")]
        public string Headline { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 6, ErrorMessage = "Must be between 6 and 2000 characters")]
        public string ReviewText { get; set; }

        [Range(1, 10, ErrorMessage ="Rating must be between 1 and 10")]
        public int Rating { get; set; }
        public virtual Reviewer Reviewer { get; set; }
        public virtual Book Book { get; set; }
    }
}
