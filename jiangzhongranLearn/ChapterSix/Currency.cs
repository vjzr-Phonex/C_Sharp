using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    struct Currency
    {
        public uint Dollars;
        public ushort Cents;

        public Currency(uint dollars, ushort cents)
        {
            this.Dollars = dollars;
            this.Cents = cents;
        }

        public override string ToString()
        {
            return string.Format("${0}.{1,-2:00}",Dollars,Cents);
        }

        public static implicit operator float(Currency value)
        {
            return value.Dollars+(value.Cents/100.0f);
        }
    }
}
