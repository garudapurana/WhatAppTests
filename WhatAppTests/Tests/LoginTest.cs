using NUnit.Framework;

namespace WhatAppTests
{
    public class LoginTest : TestBase

    {
        [Test]
        public void LoginSecretaryTest()
        {
            User secretar = new User("secretary@gmail.com", "What_123");

            app.Login(secretar);
            app.Logout();
        }

        [Test]
        public void LoginMentorTest()
        {
            User mentor = new User("mentor@gmail.com", "What_123");

            app.Login(mentor);
            app.Logout();
        }
    }
}