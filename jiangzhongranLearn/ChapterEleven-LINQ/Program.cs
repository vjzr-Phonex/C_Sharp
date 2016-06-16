using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ChapterEleven_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ttt();
        }

        static void ttt()
        {
            long time1 = Environment.TickCount;
            long time2 = Environment.TickCount;
            long tmp = time2 - 0;
        }


        private static void test()
        {
            try
            {
                test2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("catch ex in floor2!");
            }
        }

        private static void test2 ()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine("catch ex in floor 1!");
                throw new Exception();
            }
        }
    }
}
