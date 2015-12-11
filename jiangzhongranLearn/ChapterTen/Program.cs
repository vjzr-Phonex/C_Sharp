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
            /*List 相关代码
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
             * */

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
