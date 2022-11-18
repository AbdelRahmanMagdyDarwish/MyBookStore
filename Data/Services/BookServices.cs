using MyBookStore.Data.Models;
using MyBookStore.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MyBookStore.Data.Services
{
    public class BookServices
    {
        private AppDbContext context;
        public BookServices(AppDbContext context)
        {
            this.context = context;
        }
        #region add
        public void addBook (BookVM book)
        {
            var _book = new Book()
            {
                Title= book.Title,
                Description = book.Description,
                Cover= book.Cover,
                Genre = book.Genre,
                IsRead= book.IsRead,
                AddedDated = DateTime.Now,
                DateRead= book.IsRead ? book.DateRead.Value  : null ,
                Rate = book.IsRead ? book.Rate.Value : null,
                PublisherId = book.PublisherId,

            };
            context.Books.Add(_book);
            context.SaveChanges();
            foreach(var Id in book.AuthorsIds)
            {
                var bookAuthor = new BookAuthor()
                {
                    BookId = _book.Id,
                    AuthorId = Id,
                };
                context.bookAuthors.Add(bookAuthor);
                context.SaveChanges();
            }
        }
        #endregion

        #region get
        public List<Book> GetBooks()
        {
            var books = context.Books.ToList();
            return books;
        }
        #endregion

        #region byid
        public Book getByID (int id)
        {
            var bookId = context.Books.FirstOrDefault(x => x.Id == id);
            return bookId; 
        }
        #endregion

        #region Update
        public Book UpdateBook (int id , BookVM book)
        {
            var bookId = getByID(id);
            if(bookId != null)
            {
                bookId.Title = book.Title;
                bookId.Description = book.Description;
                bookId.Cover = book.Cover;
                bookId.Genre = book.Genre;
                bookId.IsRead = book.IsRead;
                bookId.AddedDated = DateTime.Now;
                bookId.DateRead = book.IsRead ? book.DateRead.Value : null;
                bookId.Rate = book.IsRead ? book.Rate.Value : null;
                context.SaveChanges();
            }
            return bookId; 
        }
        #endregion

        #region delete
        public void DeleteById (int id)
        {
            var DeletedBook = context.Books.FirstOrDefault(x=>x.Id == id);
            if(DeletedBook != null)
            {
                context.Books.Remove(DeletedBook);
            }
            context.SaveChanges(); 
        }
        #endregion
    }
}
