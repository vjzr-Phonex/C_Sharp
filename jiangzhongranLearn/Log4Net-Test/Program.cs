using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestLog4Net;
using System.Reflection;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Log4Net_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            LogProvider.Log("Warn",LogEnum.Warn,new Exception("测试--warn"));
            
        }
    }
}
