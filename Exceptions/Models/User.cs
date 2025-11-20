

using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Exceptions.Models
{
    internal class User : IAccount
    {
        private static int idCounter = 0;
        private int _id;
        public int Id
        {
            get
            { 
            return _id;
            }
        }
            
        public string FullName { get; set; }

        public string Email { get; set; }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (!PasswordChecker(value))
                { 
                throw new ArgumentException("Password error.");
                }
                _password = value;
            }
        }

        public User(string fullname, string email, string password)
        {
          idCounter++;
          _id = idCounter;

          FullName = fullname;
            Email = email;
          Password = password;


        }


        public void ShowInfo()
        {
            Console.WriteLine($"User id is {Id}, FullName is {FullName}, Email is {Email}");
        }

       public bool PasswordChecker(string password)
        {

            if (password.Length < 8)
                return false;

            if (!password.Any(char.IsUpper))
                return false;

            if (!password.Any(char.IsLower))
                return false;

            if (!password.Any(char.IsDigit))
                return false;

            return true;
        }
    }
}
