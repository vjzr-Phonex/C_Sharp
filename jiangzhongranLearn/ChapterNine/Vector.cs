using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterNine
{
    class Vector : IFormattable
    {
        public double X { set; get; }
        public double Y { set; get; }
        public double Z { set; get; }

        public string ToString()
        {
            string result = string.Format("(X:{0},Y:{1},Z:{2})",X,Y,Z);
            return result;
        }

        public string ToString(string format,IFormatProvider formatPrivider)
        { 
            if(format == null)
            {
                return ToString();
            }
            string formatUpper = format.ToUpper();
            switch (formatUpper)
            { 
                case "N":
                    return "||" + Norm() + "||";
                case "VE":
                    return String.Format("()");
            }
        }

        public double Norm()
        {
            return X * X + Y * Y + Z * Z;
        }
    }
}
