using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterEight
{
    class Program
    {
        public delegate string GetAString();

        static void Main(string[] args)
        {
            int a = 20;
            GetAString gas = new GetAString(a.ToString);
            Console.WriteLine("First Delegate:"+gas());
        }
    }
}
