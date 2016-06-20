using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterEleven_LINQ
{
    class Team
    {
        public string Name { set; get; }
        public int[] Years { set; get; }
        public Team(string name, params int[] years)
        {
            this.Name = name;
            this.Years = years;
        }
    }
}
