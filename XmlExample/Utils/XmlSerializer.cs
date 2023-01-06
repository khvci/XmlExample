using System.Xml.Serialization;
using XmlExample.Entities;

namespace XmlExample.Utils
{
    public class UserXmlSerializer
    {
        public static void Serialize(IEnumerable<User> users, string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<User>));

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(stream, users.ToList());
            }
        }

        public static IEnumerable<User> Deserialize(string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<User>));

            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                return (List<User>)serializer.Deserialize(stream);
            }
        }
    }
}
