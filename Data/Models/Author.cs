using System.Collections.Generic;

namespace MyBookStore.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation
        public List<BookAuthor> bookAuthors { get; set; }

    }
}
