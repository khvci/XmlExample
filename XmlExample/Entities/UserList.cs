namespace XmlExample.Entities
{
    public static class UserList
    {
        private static List<User> users = new List<User>();

        /// <summary>
        /// Adds user instance to users List.
        /// </summary>
        /// <param name="user"></param>
        public static void AddToList(User user)
        {
            users.Add(user);
        }

        /// <summary>
        /// returns all users from static List that keeps users.
        /// </summary>
        /// <returns></returns>
        public static List<User> GetAllUsers()
        {
            return users;
        }
    }
}
