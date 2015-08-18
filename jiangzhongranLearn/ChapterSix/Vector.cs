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

        public static Vector operator * (double lhs,Vector rhs)
        {
            return new Vector(rhs.x * lhs, rhs.y * lhs, rhs.z * lhs);
        }

        public static bool operator ==(Vector lhs,Vector rhs)
        {
            if (lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z)
                return true;
            else 
                return false;
        }

        public static bool operator !=(Vector lhs, Vector rhs)
        {
            if (lhs == rhs)
                return false;
            else
                return true;
        }
    }
}
