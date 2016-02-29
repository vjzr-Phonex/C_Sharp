using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.Concurrent;

namespace ChapterTen
{
    class Program
    {
        public static List<Racer> racers = new List<Racer>(20);

        static void Main(string[] args)
        {
            BlockingCollectionTest();
        }

        //BlockingCollectionTest
        public static void BlockingCollectionTest()
        {
            var sharedCollection = new BlockingCollection<int>();
            var events = new ManualResetEventSlim[2];
            var waits = new WaitHandle[2];

        }

        //ConcurrentCollectionTest
        public static void ConcurrentCollectionTest()
        {
            ConcurrentBag<string> bag = new ConcurrentBag<string>();
            bag.Add("just a test!");
            bag.Add("abc");
            bag.Add("ARCAS");
            string result;
            bag.TryPeek(out result);
            Console.WriteLine(result);
            BlockingCollection<string> collection = new BlockingCollection<string>();
        }

        //BitVector32Test
        public static void BitVector32Test()
        {
            var bits = new BitVector32();
            int bit1 = BitVector32.CreateMask();
            int bit2 = BitVector32.CreateMask(bit1);
            int bit3 = BitVector32.CreateMask(bit2);
            bits[3] = true;
            Console.WriteLine(bits);

        }

        //BitArrayTest
        public static void BitArrayTest()
        {
            var tmp = new BitArray(8);
            var tmp1 = new BitArray(8);
            tmp1.SetAll(true);
            tmp.SetAll(false);
            foreach(bool tm in tmp)
            {
                Console.WriteLine(tm);
            }
            foreach (bool tm in tmp1)
            {
                Console.WriteLine(tm);
            }
            Console.WriteLine();
        }
        
        //ObservableCollectionTest
        public static void ObservableCollectionTest()
        { 
            var data = new ObservableCollection<string>();

            data.CollectionChanged += new NotifyCollectionChangedEventHandler(DataCollectionChanged);
            
            data.Add("One");
            data.Add("Two");
            data.Add("Three");
            data.Insert(1,"$^^$");
            data.RemoveAt(1);
            foreach (var tmp in data)
            {
                Console.WriteLine(tmp);
            }
        }

        public static void DataCollectionChanged(object sender,NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("action:{0}",e.Action.ToString());
            if (e.OldItems != null)
            {
                Console.WriteLine("starting index for old item(s) : {0}",
                    e.OldStartingIndex);
                Console.WriteLine("Old item(s):");
                foreach(var item in e.OldItems)
                {
                    Console.WriteLine(item);
                }
            }

            if(e.NewItems != null)
            {
                Console.WriteLine("starting index for new item(s) : {0}",
                    e.NewStartingIndex);
                Console.WriteLine("new item(s):");
                foreach(var item in e.NewItems)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
        }

        //SortedSet
        public static void SortedSet()
        { 
            
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
