using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonXmlHomework
{
    class User
    {
        private string Login { get; set; }
        private string Password { get; set; }
        private string Email { get; set; }
        private string PhoneNumber { get; set; }

        public User(string login, string password, string email, string phoneNumber)
        {
            Login = login; Password = password;
            Email = email; PhoneNumber = phoneNumber;
        }
    }
}
