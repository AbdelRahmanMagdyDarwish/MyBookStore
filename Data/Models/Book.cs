using System;
using System.Collections.Generic;

namespace MyBookStore.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime ? DateRead { get; set; }
        public int ? Rate { get; set; }
        public string Cover { get; set; }
        public string Genre { get; set; }
        public DateTime AddedDated { get; set; }

        // Navigation Property
        public int ? PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public List<BookAuthor> bookAuthors { get; set; }

    }
}
