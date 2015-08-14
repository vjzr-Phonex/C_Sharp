using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}",FirstName,LastName);
        }
    }
}
