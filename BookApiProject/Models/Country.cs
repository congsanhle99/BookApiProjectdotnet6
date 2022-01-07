namespace BookApiProject.Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage ="Cannot more than 100 characters")]
        public string Name { get; set; }       
        public virtual ICollection<Author> Authors { get; set; }
    }
}
