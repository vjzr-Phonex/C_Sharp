using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    public class HelloCollection
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "hello";
            yield return "world";
        }
    }
}
