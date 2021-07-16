namespace WhatAppTests
{
    public class User
    {
        private string email;
        private string password;

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetPass()
        {
            return password;
        }

    }
}