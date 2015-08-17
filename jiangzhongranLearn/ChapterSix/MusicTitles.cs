using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterSix
{
    class MusicTitles 
    {
        string[] name = {"one","two","three","four" };

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < 4;i++ )
            {
                yield return name[i];
            }
        }

        public IEnumerator<string> Reverse()
        { 
            for(int i=3;i>=0;i--)
            {
                yield return name[i];
            }
        }

        public IEnumerator<string> Subset(int index,int length) 
        {
            for (int i = index; i < index+length; i++)
            { 
                yield return name[i];
            }
        } 
    }
}
