using System.Xml.Serialization;

namespace XmlExample.Entities
{
    public class User
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

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
