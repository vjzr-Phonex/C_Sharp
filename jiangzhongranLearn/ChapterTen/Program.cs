using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterTen
{
    class Program
    {
        public static List<Racer> racers = new List<Racer>(20);

        static void Main(string[] args)
        {
            AddRacers();
            //racers.RemoveRange(2,3);
            //for (int i = 0; i < racers.Count();i++ )
            //{
            //    Console.WriteLine("第"+i+"个"+racers[i]);
            //}
            racers.ForEach(Console.WriteLine);
            int index = racers.FindIndex(FindCoutryFinland);
            Console.WriteLine(index);
        }

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

        public static bool FindCoutryFinland(Racer racer)
        {
            if (racer == null)
                throw new ArgumentException("Racer Null");
            return racer.Country == "Finland";
        }
    }
}
