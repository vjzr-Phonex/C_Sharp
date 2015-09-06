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
            string.Format("{0}",12);
            Console.WriteLine("{0} 向你问好！",name);
        }

        static void Main(string[] args)
        {

            Heater heater = new Heater();
            Alarm al = new Alarm();
            Display ds = new Display();
            heater.BoilEvent += al.MakeAlert;
            heater.BoilEvent += Display.ShowMsg;

            //<-----------lambda表达式,书上范例----------->
            string mid = ", middlw part,";
            Func<string, string> lambda = param =>
                {
                    param += mid;
                    param += "and this was added to the string.";
                    return param;
                };
            Console.WriteLine(lambda("start of string"));
            Func<string, string> ddd = param =>
                {
                    param += "ddd";
                    return param;
                };
            Console.WriteLine(ddd("aaaaa"));
            //<-----------匿名方法、网络实例----------->
            //List<string> names = new List<string>();
            //names.Add("Sunny Chen");
            //names.Add("Kitty Wang");
            //names.Add("Sunny Crystal");

            //List<string> found = names.FindAll(
            //    new Predicate<string>(NameMatches));

            //if (found != null)
            //{
            //    foreach (string str in found)
            //        Console.WriteLine(str);
            //}   

            //<-----------委托、网络范例---------------->
            //Heater heater = new Heater();
            //Alarm al = new Alarm();
            //Display ds = new Display();
            //heater.BoilEvent += al.MakeAlert;
            //heater.BoilEvent += Display.ShowMsg;

            //heater.BoilWater();
            //-----------------------------
            //MakeGreet mg ;
            //mg = EnglishGreet;
            //mg += ChineseGreet;
            //Program p = new Program();
            //p.Greet("Barak Obama", mg);
            //p.Greet("姜仲然",ChineseGreet);
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

        static bool NameMatches(string name)
        {
            return name.StartsWith("sunny",
                StringComparison.OrdinalIgnoreCase);
        }   

        static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
                double result = action(value);
                Console.WriteLine("Value is {0},result of operation is {1}",value,result);
        }
    }
}
