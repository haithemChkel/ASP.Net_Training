using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebForms_sample2.ManageUsers
{
    [XmlType("users")]
    public class Users : List<User>
    { }

    public class AppUsers
    {
        public static Users AllUsers = FillSampleData();

        private static Users FillSampleData()
        {
            var list = new Users();
            list.Add(new User { LastName = "XX1", FirstName = "XX2", Gender = Genders.Male });
            list.Add(new User { LastName = "XX2", FirstName = "XX3", Gender = Genders.Female });
            list.Add(new User { LastName = "XX3", FirstName = "XX4", Gender = Genders.Male });
            list.Add(new User { LastName = "XX4", FirstName = "XX5", Gender = Genders.Female });
            list.Add(new User { LastName = "XX5", FirstName = "XX6", Gender = Genders.Male });
            return list;
        }
    }
}