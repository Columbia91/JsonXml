using System;

namespace JsonXmlHomework
{
    [Serializable]
    public class User
    {
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public User() {}
        public User(string login, string password, string email, string phoneNumber)
        {
            Login = login; Password = password;
            Email = email; PhoneNumber = phoneNumber;
        }
    }
}
