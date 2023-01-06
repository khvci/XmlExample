using System.Xml.Serialization;

namespace XmlExample.Entities
{
    [XmlRoot("Users")]
    public class User
    {
        [XmlElement("Id")]
        public string Id { get; set; }

        [XmlElement("FirstName")]
        public string FirstName { get; set; }

        [XmlElement("LastName")]
        public string LastName { get; set; }

        [XmlElement("UserName")]
        public string UserName { get; set; }

        [XmlElement("Email")]
        public string Email { get; set; }

        // constructors
        public User(
                string firstName, string lastName,
                string userName, string email)
        {
            Id = new Random().Next().ToString();
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;

        }

        public User() { } 
    }
}
