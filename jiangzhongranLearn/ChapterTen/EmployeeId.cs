using System;
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

        public EmployeeId()
        { 
            
        }
    }
}
