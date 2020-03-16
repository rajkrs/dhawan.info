using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dhwan.Models
{
    public class Contact
    {
        public string Address { get; set; }
        public List<string> Emails { get; set; }
        public List<string> Phones { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Youtube { get; set; }
        public string GitHub { get; set; }

    }
}