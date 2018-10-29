using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Education2.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DisplayName("Add Images")]
        public string ImageUrl { get; set; }
        [DisplayName("Select Chapter")]
        public int ChapterId { get; set; }
        public Chapter Chapter { get; set; }
    }
}