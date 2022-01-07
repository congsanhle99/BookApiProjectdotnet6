namespace BookApiProject.Models
{
    public class Reviewer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage ="Cannot more than 100 characters")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Cannot more than 200 characters")]
        public string LastName { get; set; }
        public virtual ICollection<Review> Reviews { get; set;}
    }
}
