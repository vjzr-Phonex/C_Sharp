using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterNine
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder(10);
            s.Append("asdfghjkl;a");
            Console.WriteLine(s.Capacity);

        }
    }
}
