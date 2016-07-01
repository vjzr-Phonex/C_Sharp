using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterEleven_LINQ
{
    public static class StringExtension
    {
        public static void Foo(this string s)
        {
            Console.WriteLine("Foo is just a Foo!");
        }
    }
}
