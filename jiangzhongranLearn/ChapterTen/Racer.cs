using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterTen
{
    [Serializable]
    public class Racer : IComparable<Racer>, IFormattable
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int Wins { get; set; }

        public Racer(int id, string firstname, string lastName, string country = null, int wins = 0)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastName;
            this.Country = country;
            this.Wins = wins;
        }

        public override string ToString()
        {
            return String.Format("{0},{1}",FirstName,LastName);
        }

        public string ToString(string format, IFormatProvider formatprovider)
        {
            if (format == null)
                format = "N";
            switch (format.ToUpper())
            { 
                case "N":   
                    return ToString();
                case "F":   
                    return FirstName;
                case "L":   
                    return LastName;
                case "W":
                    return String.Format("{0},Wins : {1}",ToString(),Wins);
                case "C":
                    return String.Format("{0},Country : {1}",ToString(),Country);
                case "A":
                    return String.Format("{0},Wins : {1}", Country, Wins);
                default :
                    throw new FormatException(String.Format(formatprovider,"Format{0} is not supported",format));
            }
        }

        public string ToString(string format)
        {
            return ToString(format , null);
        }

        public int CompareTo(Racer other)
        {
            int compare = this.LastName.CompareTo(other.LastName);
            if (compare == 0)
                return this.FirstName.CompareTo(other.FirstName);
            return compare;
        }
    }
}
