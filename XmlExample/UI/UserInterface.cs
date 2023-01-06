using XmlExample.Entities;
using XmlExample.Utils;

namespace XmlExample.UserInterface
{
    static class UserInterface
    {
        /// <summary>
        /// promprts a list to user, then calls another method that
        /// runs a command depending on user's choice.
        /// </summary>
        public static void GetUserSelection()
        {
            Console.WriteLine("\n1 - Yeni kullanici girisi\n" +
                              "2 - Mevcut kullanicilari goruntuleme\n" +
                              "3 - Cikis\n");

            RunUserCommand(short.Parse(Console.ReadLine()));
        }

        /// <summary>
        /// According to user's selection, calls related methods.
        /// </summary>
        /// <param name="selection">this parameter comes from GetUserSelection()</param>
        public static void RunUserCommand(short selection)
        {
            switch (selection)
            {
                case 1:
                    ConsoleReader.ReadInputUser();
                    UserXmlSerializer.Serialize(UserList.GetAllUsers(), "C:\\Users\\Z004PUVY\\OneDrive - Siemens AG\\Documents\\Database\\users.xml");
                    GetUserSelection();
                    break;
                case 2:
                    var existingUsers = UserXmlSerializer
                        .Deserialize("C:\\Users\\Z004PUVY\\OneDrive - Siemens AG\\Documents\\Database\\users.xml");

                    foreach (var user in existingUsers)
                    {
                        Console.WriteLine($"\nID: {user.Id}\n" +
                                          $"isim: {user.FirstName}\n" +
                                          $"soyisim: {user.LastName}\n" +
                                          $"kullanici adi: {user.UserName}\n" +
                                          $"email: {user.Email}\n");
                    }

                    GetUserSelection();
                    break;
                case 3:
                    Console.WriteLine("Program Sonlandirildi\n");
                    break;
            }
        }
    }
}
