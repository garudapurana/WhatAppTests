using NUnitLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WhatAppTests
{
    class Runner
    {
        public static int Main(string[] args)
        {
            int res = new AutoRun().Execute(args);
            Console.ReadLine();
            return res;
        }
    }
}
