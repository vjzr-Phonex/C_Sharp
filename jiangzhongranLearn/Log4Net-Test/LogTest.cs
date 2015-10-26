using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestLog4Net;

namespace Log4Net_Test
{
    class LogTest
    {
        public void test() 
        {
            LogHelper.WriteLog(typeof(LogTest),"sdsds");
            Exception ex = new Exception();
            LogHelper.WriteLog(typeof(LogTest), ex);
        }
    }
}
