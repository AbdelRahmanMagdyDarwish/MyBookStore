using MyBookStore.Data.Models;
using MyBookStore.Data.ViewModel;

namespace MyBookStore.Data.Services
{
    public class AuthorServices
    {
        private AppDbContext context;
        public AuthorServices(AppDbContext context)
        {
            this.context = context;
        }
        #region AddAuthor
        public void AddAuthor (AuthorVM author)
        {
            var NewAuthor = new Author()
            {
                Name = author.Name,
            };
            context.Authors.Add(NewAuthor);
            context.SaveChanges();
        }

        #endregion
    }
}
