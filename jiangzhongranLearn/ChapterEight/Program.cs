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

        public delegate void MakeGreet(string name);

        public void Greet(string name, MakeGreet makeGreet)
        {
            makeGreet(name);
        }

        public static void EnglishGreet(string name) 
        {
            Console.WriteLine("{0} Say Hello To You!!!",name);
        }

        public static void ChineseGreet(string name)
        {
            Console.WriteLine("{0} 向你问好！",name);
        }
        static void Main(string[] args)
        {
            MakeGreet mg ;
            mg = EnglishGreet;
            Program p = new Program();
            p.Greet("Barak Obama", EnglishGreet);
            p.Greet("姜仲然",ChineseGreet);
            //<------------------------>
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

            //DoubleOp[] operations = 
            //{
            //    MathOperations.MultiplyByTwo,MathOperations.Square
            //};

            //for (int i = 0; i < operations.Length;i++ )
            //{
            //    Console.WriteLine("Using operations[{0}]:",i);
            //    ProcessAndDisplayNumber(operations[i],2.0);
            //    ProcessAndDisplayNumber(operations[i],7.94);
            //    ProcessAndDisplayNumber(operations[i],1.414);
            //}

            //Employee[] employees = 
            //{
            //    new Employee("aa",2000),
            //    new Employee("bb",4000),
            //    new Employee("cc",3000),
            //    new Employee("dd",1000)
            //};
            //Console.WriteLine("all OK ");
            //BubbleSorter.Sort(employees,Employee.CompareSalary);
            //Console.WriteLine("all OK 2");
            //foreach( var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
        }
         
        static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
                double result = action(value);
                Console.WriteLine("Value is {0},result of operation is {1}",value,result);
        }
    }
}
