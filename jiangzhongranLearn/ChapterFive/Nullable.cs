using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterFive
{
    class Nullable<T>
        where T:struct
    {
        private bool hasValue;
        private T value;

        public Nullable(T value)
        {
            this.hasValue = true;
            this.value = value;
        }

        public bool HasValue
        {
            get 
            {
                return hasValue;
            }
        }

        public T Value
        {
            get
            {
                if (!hasValue)
                {
                    throw new InvalidOperationException("no value");
                }
                return value;
            }
        }

        public static explicit operator T(Nullable<T> value)
        {
            return value.Value;
        }

        public static implicit operator Nullable<T>(T value)
        {
            return new Nullable<T>(value);
        }

        public override string ToString()
        {
            if (!HasValue)
                return String.Empty;
            return this.value.ToString();
        }
    }
}
