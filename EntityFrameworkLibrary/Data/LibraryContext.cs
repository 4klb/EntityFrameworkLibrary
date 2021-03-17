using EntityFrameworkLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLibrary.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<AvailableBooks> AvailableBooks { get; set; }
        public DbSet<OrderedBooks> OrderedBooks { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-S75L8G1; Database=NewDataBase; Trusted_Connection=true;");
        }
    }
}
