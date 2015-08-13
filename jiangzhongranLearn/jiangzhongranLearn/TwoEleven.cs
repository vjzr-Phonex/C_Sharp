
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jiangzhongranLearn
{
    class TwoEleven
    {
        static TwoEleven()
        {
            Console.WriteLine("TwoEleven static init!!!");
        }

        public void te() 
        {
            #if DEBUG
                Console.Write("ddsf");
            #endif
        }

        public void de()
        {
            Console.WriteLine("de!!!");
        }

        public void dw(out int i) 
        {
            i = 0;
            return;
        }
    }
}
