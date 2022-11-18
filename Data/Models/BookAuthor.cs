namespace MyBookStore.Data.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }
        // Navigation Property
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
