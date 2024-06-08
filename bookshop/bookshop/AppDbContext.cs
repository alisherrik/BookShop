using bookshop.Models;
using Microsoft.EntityFrameworkCore;

namespace bookshop
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Navigation(s => s.Category).AutoInclude();
            modelBuilder.Entity<Book>().Navigation(s => s.Author).AutoInclude();
            modelBuilder.Entity<Category>().HasMany(c => c.Books).WithOne(s => s.Category).HasForeignKey(s => s.CategoryId);
            modelBuilder.Entity<Author>().HasMany(c => c.Books).WithOne(c => c.Author).HasForeignKey(s => s.AuthorId);
            SeedData(modelBuilder);
        }
        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Romans" },
                new Category { Id = 2, Name = "Fantastic" },
                new Category { Id = 3, Name = "History" }


            );
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Jack London" },
                new Author { Id = 2, Name = "Scott Fitzgerald" },
                new Author { Id = 3, Name = "Alexander Grin" }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "Martin Iden", CategoryId = 1, Price = 200, AuthorId = 1 },
                new Book { Id = 2, Name = "The Great Gatspy", CategoryId = 2, Price = 122, AuthorId = 2 },
                new Book { Id = 3, Name = "Obsession of the Stern", CategoryId = 3, Price = 334, AuthorId = 3 }
             );
        }
    }
}
