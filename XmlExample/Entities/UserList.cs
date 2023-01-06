namespace XmlExample.Entities
{
    public static class UserList
    {
        private static List<User> users = new List<User>();

        public static void AddToList(User user)
        {
            users.Add(user);
        }

        public static List<User> GetAllUsers()
        {
            return users;
        }
    }
}
