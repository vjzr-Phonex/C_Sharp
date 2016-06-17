using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterEleven_LINQ
{
    [Serializable]
    public class Racer:IComparable<Racer>,IFormattable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Wins { get; set; }
        public string Country { get; set; }
        public int Starts { get; set; }
        public string[] Cars { get; set; }
        public int[] Years { get; set; }

        public Racer(string firstName = null, string lastName = null,
            string country = null, int starts = 0, int wins = 0,
            IEnumerable<int> years = null, IEnumerable<string> cars = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.Starts = starts;
            this.Wins = wins;
            var yearsList = new List<int>();
            foreach(int year in years)
            {
                yearsList.Add(year);
            }
            this.Years = yearsList.ToArray();
            var carList = new List<string>();
            foreach(string car in cars)
            {
                carList.Add(car);
            }
            this.Cars = carList.ToArray();
        }

        public override string ToString()
        {
            return String.Format("{0},{1}",FirstName,LastName);
        }

        public int CompareTo(Racer other)
        {
            if (other == null) throw new ArgumentException("Other is Null!");
            return this.LastName.CompareTo(other.LastName);
        }

        public string ToString(string format)
        {
            return ToString(format,null);
        }

        public string ToString(string format,IFormatProvider formatProvider)
        {
            switch (format)
            { 
                case "N" :
                    return ToString();
                case "F" :
                    return FirstName;
                case "L" :
                    return LastName;
                case "C" :
                    return Country;
                case "S" :
                    return Starts.ToString();
                case "W" :
                    return Wins.ToString();
                case "A" :
                    return String.Format("{0} {1},{2} ; starts:{3},wins:{4}", FirstName, LastName, Country, Starts, Wins);
                default:
                    throw new FormatException(String.Format("Format {0} not support", format));
            }
        }

    }
}
