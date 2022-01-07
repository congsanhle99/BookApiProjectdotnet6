using BookApiProject.Models;

namespace BookApiProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }

        // ModelBuilder allow us to specify the RELATIONSHIP between entities
        // OVERRIDE it from the Db Context
        // configure MANY-to-MANY relationship
            // BookAuthor and BookCategory
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // BookCategory
            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });
            // One "Book" Many "Category"
            modelBuilder.Entity<BookCategory>()
                        .HasOne(b => b.Book)
                        .WithMany(bc => bc.BookCategories)
                        .HasForeignKey(b => b.BookId);
            // One "Category" Many "Book"
            modelBuilder.Entity<BookCategory>()
                        .HasOne(c => c.Category)
                        .WithMany(bc => bc.BookCategories)
                        .HasForeignKey(c => c.CategoryId);

            // BookAuthor
            modelBuilder.Entity<BookAuthor>()
                        .HasKey(ba => new {ba.BookId, ba.AuthorId});
            // One "Book" MANY "Author"
            modelBuilder.Entity<BookAuthor>()
                        .HasOne(b => b.Book)
                        .WithMany(ba => ba.BookAuthors)
                        .HasForeignKey(b => b.BookId);
            // One "Author" Many "Book"
            modelBuilder.Entity<BookAuthor>()
                        .HasOne(a => a.Author)
                        .WithMany(ba => ba.BookAuthors)
                        .HasForeignKey(a => a.AuthorId);


        }
    }
}
