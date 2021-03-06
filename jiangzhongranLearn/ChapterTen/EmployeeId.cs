﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterTen
{
    [Serializable]
    public class EmployeeId : IEquatable<EmployeeId>
    {
        private readonly char prefix;
        private readonly int number;

        public EmployeeId(string id)
        {
            if (id == null)
                throw new ArgumentException("ID is wrong!");
            this.prefix = (id.ToUpper())[0];
            int numLength = id.Length ;

            try
            {
                int subLength = numLength > 6 ? 6 : numLength;
                number = int.Parse(id.Substring(1, subLength - 1));
            }
            catch (FormatException)
            {
                throw new EmployeeIdException("Invalid EmployeeId format!");
            }
        }

        public override string ToString()
        {
            return prefix.ToString() + string.Format("{0,6:000000}", number);
        }

        public override int GetHashCode()
        {
            return (number ^ number)*0x15051505;
        }

        public override bool Equals(object obj)
        {
            return base.Equals((EmployeeId)obj);
        }

        public static bool operator ==(EmployeeId left, EmployeeId right)
        {
            return left.Equals(right);
        }

        public bool Equals(EmployeeId other)
        {
            if (other == null)
            {
                return false;
            }
            return (prefix == other.prefix && number == other.number);
        }

        public static bool operator !=(EmployeeId left, EmployeeId right)
        {
            return !(left == right);
        }
    }
}
