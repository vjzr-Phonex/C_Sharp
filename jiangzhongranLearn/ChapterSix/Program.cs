using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2];
            persons[0] = new Person() {FirstName="Jiang",LastName="Zhongran"};
            persons[1] = new Person() { FirstName = "Li", LastName = "Xinyu" };
            foreach(var i in persons)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
