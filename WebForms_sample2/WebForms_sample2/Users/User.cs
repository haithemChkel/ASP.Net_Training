using System.Xml.Serialization;

namespace WebForms_sample2.ManageUsers
{
    public enum Genders
    {
        Male = 1, Female
    }

    [XmlType("user")]
    public class User
    {
        [XmlAttribute]
        public string LastName { get; set; }
        [XmlAttribute]
        public string FirstName { get; set; }
        [XmlAttribute]
        public Genders Gender { get; set; }
    }
}