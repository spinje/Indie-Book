using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MvcLibraryService.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int BookID { get; set; }
        public virtual Book Book { get; set; }

        [MinLength(10)]
        [MaxLength(50)]
        [DataType(DataType.Text)]
        public string Contents { get; set; }

        [Required()]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }

    }
}
