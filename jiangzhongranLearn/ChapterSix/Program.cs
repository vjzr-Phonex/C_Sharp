﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1,2,3);
            Vector v2 = new Vector(4,5,6);
            Vector v3 = v1 + v2;
            Console.WriteLine(v3);

            Currency c = new Currency(12,33);
            float f = c;
            Console.WriteLine(f);

            //var helloCollection = new HelloCollection();
            //byte? test = 1;
            //string s1 = "abc";
            //string s2 = "ab" + "c";
            //if(s1 == s2)
            //{
            //    Console.WriteLine("s1 equals s2!");
            //}
            //byte te2 = test ?? 10;
            //if("12" is object)
            //{
            //    Console.WriteLine(typeof(HelloCollection));
            //}
            //Console.WriteLine(te2);

            //var helloCollection = new HelloCollection();
            //foreach (var i in helloCollection)
            //{
            //    Console.WriteLine(i);
            //}


            //Person[] persons = new Person[2];
            //persons[0] = new Person() {FirstName="Jiang",LastName="Zhongran"};
            //persons[1] = new Person() { FirstName = "Li", LastName = "Xinyu" };
            //foreach(var i in persons)
            //{
            //    Console.WriteLine(i.ToString());
            //}


            //int[,] test = new int[2, 3];
            //test[0, 0] = 0;
            //test[0, 1] = 1;
            //test[0, 2] = 2;
            //test[1, 0] = 3;
            //test[1, 1] = 4;
            //test[1, 2] = 5;
            //foreach (var i in test)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] one = {1,2,3,4,5};
            //int[] two = {10,20,30,40,50};
            //var segment = new ArraySegment<int>(one,2,2);
            //for (int i = segment.Offset; i < segment.Offset+segment.Count;i++ )
            //{
            //    Console.WriteLine(segment.Array[i]);
            //}

            
            //Array test = Array.CreateInstance(typeof(int),2);
            //test.SetValue(0,0);
            //test.SetValue(1,1);
            //foreach(var i in test)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
