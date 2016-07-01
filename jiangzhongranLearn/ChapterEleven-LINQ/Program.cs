using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ChapterEleven_LINQ.DataLib;
namespace ChapterEleven_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            linqQuery();            
        }

        private static void linqQuery()
        {
            var query = from r in Formula1.GetChampions()
                        where r.Country == "Brazil"
                        orderby r.Wins descending
                        select r;
            foreach(Racer r in query)
            {
//                Console.WriteLine(query.ToString());
                Console.WriteLine("{0:A}",r);
                String s = "qqwe";
                s.Foo();
            }
        }
    }
}
