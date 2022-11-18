using MyBookStore.Data.Models;
using MyBookStore.Data.ViewModel;

namespace MyBookStore.Data.Services
{
    public class PublisherServices
    {
        private AppDbContext context;
        public PublisherServices(AppDbContext context)
        {
            this.context = context;
        }
        #region AddPublisher
        public void AddPublisher(PublisherVM publisher)
        {
            var NewPublisher = new Publisher()
            {
                Name= publisher.Name,
            };
            context.Publishers.Add(NewPublisher);
            context.SaveChanges();
        }
        #endregion
    }
}
