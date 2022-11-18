using System;
using System.Collections.Generic;

namespace MyBookStore.Data.ViewModel
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Cover { get; set; }
        public string Genre { get; set; }

        public int PublisherId { get; set; }
        public List<int> AuthorsIds { get; set; }

    }
}
