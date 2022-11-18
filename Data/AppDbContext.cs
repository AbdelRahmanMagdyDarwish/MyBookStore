using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using MyBookStore.Data.Models;
using System.Runtime.CompilerServices;

namespace MyBookStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasOne(B => B.Book)
                .WithMany(B => B.bookAuthors)
                .HasForeignKey(B => B.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(B => B.Author)
                .WithMany(B => B.bookAuthors)
                .HasForeignKey(B => B.AuthorId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Book> Books { get; set;}
        public DbSet<BookAuthor> bookAuthors { get; set;}
        public DbSet <Author> Authors { get; set;}
        public DbSet <Publisher> Publishers { get; set;}
    }
}