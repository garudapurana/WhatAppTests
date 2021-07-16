using NUnit.Framework;

namespace WhatAppTests
{
    public class TestBase
    {

        protected AppManager app = new AppManager();

        [OneTimeSetUp]
        public void Setup()
        {
            app.Init();

        }



        [OneTimeTearDown]
        public void TearDown()
        {
            app.Stop();
        }


    }
}