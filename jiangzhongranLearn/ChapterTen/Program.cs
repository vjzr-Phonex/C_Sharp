using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading;

namespace ChapterTen
{
    class Program
    {
        public static List<Racer> racers = new List<Racer>(20);

        static void Main(string[] args)
        {

        }

        //SortedSet
        public static void SortedSet()
        { 
            
        }

        //SortedList
        public static void SortedListTest()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(4, "a");
            sortedList.Add(2, "d");
            sortedList.Add(3, "q");
            sortedList.Add(1, "e");
            foreach (KeyValuePair<int, string> kv in sortedList)
            {
                Console.WriteLine("Key:" + kv.Key + " Value:" + kv.Value);
            }
        }

        //LookupTest
        public static void LookupTest()
        {
            var racers = new List<Racer>();
            racers.Add(new Racer(0,"Jacques","Villeneuve","Canada",11));
            racers.Add(new Racer(1,"Alan","Jones","Australia",12));
            racers.Add(new Racer(2, "Jackie", "Stuwart", "United Kindom", 27));
            racers.Add(new Racer(3, "James", "Hunt", "United Kindom", 10));
            racers.Add(new Racer(4, "Jack", "Brabham", "Australia", 14));

            var lookupRacers = racers.ToLookup(r => r.Country);
            foreach(Racer r in lookupRacers["Australia"])
            {
                Console.WriteLine(r);
            }
        }

        //DictionaryTest
        public static void DictionaryTest()
        { 
            var employees = new Dictionary<EmployeeId,Employee>(31);

            var idKyle = new EmployeeId("T3755");
            var kyle = new Employee(idKyle,"Kyle Bush",5443890.00m);
            employees.Add(idKyle,kyle);
            Console.WriteLine(kyle);
        }

        //SortedListTest
        public static void SortedListTest()
        { 
            var books = new SortedList<string,string>();
            books.Add("c#","ABCDE");
            books.Add("java","GFHND");

            Console.WriteLine(books["c#"]);

            foreach(KeyValuePair<string,string> book in books)
            {
                Console.WriteLine("{0},{1}",book.Key,book.Value);
            }
        }

        //List 相关代码
        public static void ListTest()
        {
            AddRacers();
            racers.ForEach(Console.WriteLine);
            int index = racers.FindIndex(FindCoutryFinland);
            Console.WriteLine(index);
            ReadOnlyCollection<Racer> readOnly = racers.AsReadOnly();
            try
            {
                readOnly[2].Country = "dddd";
                Console.WriteLine(readOnly[2].Country);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //Queue相关代码
        public static void QueueTest()
        {
            DocumentManager dm = new DocumentManager();
            ProcessDocuments.Start(dm);
            for (int i = 0; i < 1000;i++ )
            {
                Document doc = new Document("Doc"+i.ToString(),"content");
                dm.AddDocument(doc);
                Console.WriteLine("Added document {0}",doc.Title);
                Thread.Sleep(new Random().Next(20));
            }
        }

        //Stack相关代码
        public static void StackTest()
        {
            Stack<Char> stack = new Stack<char>();
            stack.Push('A');
            stack.Push('B');
            stack.Push('C');

            foreach(var tmp in stack)
            {
                Console.WriteLine(tmp);
            }
        }

        //List
        public static void AddRacers()
        {
            Racer graham = new Racer(7, "Graham", "Hill", "UK", 14);
            Racer emerson = new Racer(13, "Emerson", "Fittipaldi", "Brazil", 14);
            Racer mario = new Racer(16, "Mario", "Andretti", "USA", 12);

            racers.Add(new Racer(24, "Michael", "Schumacher", "Germany", 91));
            racers.Add(new Racer(27, "Mika", "Hakkinen", "Finland", 20));

            racers.AddRange(new Racer[]{
                new Racer(14,"Niki","Lauda","Austria",25),
                new Racer(27,"Alain","Porst","France",51)});
            racers.Insert(2, new Racer(10, "lilei", "hanmeimei", "China", 2));
        }

        //List
        public static bool FindCoutryFinland(Racer racer)
        {
            if (racer == null)
                throw new ArgumentException("Racer Null");
            return racer.Country == "Finland";
        }
    }
}
