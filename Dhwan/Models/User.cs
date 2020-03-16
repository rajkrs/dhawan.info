using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dhwan.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Short_description { get; set; }
        public DateTime Date_of_birth { get; set; }
        public Contact Personal_contact { get; set; }
        public Contact Official_contact { get; set; }
        public string About_me { get; set; }
        public List<string> About_me_skills { get; set; }
        public List<Page> Pages { get; set; }

    }
}