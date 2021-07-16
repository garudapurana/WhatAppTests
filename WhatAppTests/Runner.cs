using NUnitLite;
using System;

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
