using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLibraryService.Models
{
    public class Author
    {
        public int AuthorID { get; set; }

        public string Name { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}