using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestLog4Net;
using System.Reflection;
using log4net;

namespace Log4Net_Test
{
    class Program
    {


        static void Main(string[] args)
        {
//            LogHelper.WriteLog(typeof(Program), "ddddd");
//        http://blog.csdn.net/zhoufoxcn/article/details/2220533
            ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }
    }
}
