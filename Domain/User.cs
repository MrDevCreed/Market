using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class User
    {
        public User(string userName, string password, string email, string phone)
        {
            this.UserName = userName;
            this.Password = password;
            this.Email = email;
            this.Phone = phone;
        }

        public int Id { get; private set; }

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("UserName Value Connot be Null");

                if (value.Length < 4 || value.Length > 50)
                    throw new ArgumentOutOfRangeException("UserName Length Should Between [4-50]");

                _UserName = value;
            }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Password Value Connot be Null");

                if (value.Length < 8 || value.Length > 250)
                    throw new ArgumentOutOfRangeException("Password Length Should Between [8-250]");

                _Password = value;
            }
        }

        private string _Email;

        [EmailAddress]
        public string Email
        {
            get { return _Email; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Email Value Connot be Null");

                _Email = value;
            }
        }

        private string _Phone;

        public string Phone
        {
            get { return _Email; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Phone Value Connot be Null");

                _Phone = value;
            }
        }

        // Functions

        public void ChangeUserName(string userName)
        {
            this.UserName = userName;
        }

        public void ChangePassword(string password)
        {
            this.Password = password;
        }

        public void ChangeEmail(string email)
        {
            this.Email = email;
        }

        public void ChangePhone(string phone)
        {
            this.Phone = phone;
        }
    }
}
