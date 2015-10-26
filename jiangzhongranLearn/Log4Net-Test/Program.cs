using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestLog4Net;

namespace Log4Net_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHelper.WriteLog(typeof(Program), "ddddd");
        }
    }
}
