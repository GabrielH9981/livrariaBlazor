using crudBlazor.Shared;
using Microsoft.EntityFrameworkCore;
namespace crudBlazor.Server
{
     public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BookAutor> BookAutors { get; set; }
        public DbSet<Rent> Rents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAutor>()
                .HasKey(t => new {t.BookId, t.AutorId});

            modelBuilder.Entity<BookAutor>()
                .HasOne(pt => pt.Book)
                .WithMany(p => p.BookAutors)
                .HasForeignKey(pt => pt.BookId);

            modelBuilder.Entity<BookAutor>()
                .HasOne(pt => pt.Autor)
                .WithMany(t => t.BookAutors)
                .HasForeignKey(pt => pt.AutorId);
        }
    }
}