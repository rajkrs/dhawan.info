using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dhwan.Models
{
    public class Page
    {
        public string Nevigation { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string More_url_link { get; set; }
        public List<Card> Cards { get; set; }
    }
}