using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    struct Vector
    {
        public double x, y,z;

        public Vector(double x,double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector(Vector temp)
        {
            this.x = temp.x;
            this.y = temp.y;
            this.z = temp.z;
        }

        public override string ToString()
        { 
            return "("+x+","+y+","+z+")";
        }

        public static Vector operator + (Vector lhs,Vector rhs)
        {
            Vector result = new Vector(lhs);
            result.x += rhs.x;
            result.y += rhs.y;
            result.z += rhs.z;
            return result;
        }
    }
}
