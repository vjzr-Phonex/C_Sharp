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

        public override string ToString()
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
                    return "||" + Norm().ToString() + "||";
                case "VE":
                    return String.Format("({0:E},{1:E},{2:E})",X,Y,Z);
                case "IJK":
                    StringBuilder sb = new StringBuilder(X.ToString(),30);
                    sb.AppendFormat("i+");
                    sb.AppendFormat(Y.ToString());
                    sb.AppendFormat("j+");
                    sb.AppendFormat(Z.ToString());
                    return sb.ToString();
                default:
                    return ToString();
            }
        }

        public double Norm()
        {
            return X * X + Y * Y + Z * Z;
        }
    }
}
