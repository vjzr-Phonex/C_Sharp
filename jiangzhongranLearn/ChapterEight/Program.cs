using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterEight
{
    class Program
    {
        public delegate string GetAString();

        public delegate double DoubleOp(double x);

        static void Main(string[] args)
        {
            //int a = 20;
            //GetAString gas = new GetAString(a.ToString);
            //Console.WriteLine("First Delegate:"+gas());

            //int x = 40;
            //GetAString firstStringMethod = x.ToString;
            //Console.WriteLine(firstStringMethod());

            //Currency balance = new Currency(34,50);
            //firstStringMethod = balance.ToString;
            //Console.WriteLine("string is {0}",firstStringMethod());

            //firstStringMethod = new GetAString(Currency.GetCurrency);
            //Console.WriteLine("string is {0}", firstStringMethod());

            DoubleOp[] operations = 
            {
                MathOperations.MultiplyByTwo,MathOperations.Square
            };

            for (int i = 0; i < operations.Length;i++ )
            {

            }
        }
    }
}
