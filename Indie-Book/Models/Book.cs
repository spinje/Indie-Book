using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcLibraryService.Models
{
    public class Book
    {
        public int BookID { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public virtual List<Review> Review { get; set; }

    }
}
