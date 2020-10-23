using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms_sample1.User
{
    public class Users : List<User>
    {
    }

    public static class AppUsers
    {
        public static Users AllUsers = new Users();
    }
}