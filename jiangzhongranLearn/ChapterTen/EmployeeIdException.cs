using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterTen
{
    [Serializable]
    class EmployeeIdException : Exception
    {
        public EmployeeIdException(string message) : base(message) { }
    }
}
