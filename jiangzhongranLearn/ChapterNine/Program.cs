using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ChapterNine
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "vala mogulis,vala dohaeris!";
            string patString = "va";
            MatchCollection matchCol = Regex.Matches(str,patString,RegexOptions.IgnoreCase|RegexOptions.ExplicitCapture);
            foreach(Match nextMatch in matchCol)
            {
                Console.WriteLine(nextMatch.Index);
            }

            //Vector v = new Vector();
            //Console.WriteLine("The double is{0,10:E},the int is:{1}", 212.223, 12);
        }
    }
}
