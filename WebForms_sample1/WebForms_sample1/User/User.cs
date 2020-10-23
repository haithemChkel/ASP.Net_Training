using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms_sample1.User
{
    public enum Genders
    {
        Male = 1, Female
    }
    public class User
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Genders? Gender { get; set; }
    }
}