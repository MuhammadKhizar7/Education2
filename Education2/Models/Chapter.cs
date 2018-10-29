using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education2.Models
{
    public class Chapter
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        [Display(Name = "Select Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}