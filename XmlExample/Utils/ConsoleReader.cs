using XmlExample.Entities;

namespace XmlExample.Utils
{
    static class ConsoleReader
    {
        static int userSelection = 0;
        static string _firstName;
        static string _lastName;
        static string _userName;
        static string _email;

        public static void ReadInputUser()
        {
            Console.WriteLine("\nisim: ");
            _firstName = Console.ReadLine();

            Console.WriteLine("soyisim: ");
            _lastName = Console.ReadLine();

            Console.WriteLine("userName: ");
            _userName = Console.ReadLine();

            Console.WriteLine("email: ");
            _email = Console.ReadLine();

            UserList.AddToList(new User(
                _firstName, _lastName,
                _userName, _email));
        }

    }

}
