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
//            LogHelper.WriteLog(typeof(Program),"sddsew");


//          Application.Run(new MainForm());
            //创建日志记录组件实例
            
            ILog log = LogManager.GetLogger(typeof(Program));
            //记录错误日志
            for (int i = 0; i < 100; i++)
            { 
                log.Error("error", new Exception("发生了一个异常"));
                Console.Write(i + " ");
            }
                //记录严重错误
//            log.Fatal("fatal", new Exception("发生了一个致命错误"));
            //记录一般信息
//            log.Info("info");
            //记录调试信息
//            log.Debug("debug");
            //记录警告信息
//            log.Warn("warn");
//            Console.WriteLine("日志记录完毕。");
//            Coddnsole.Read();
        }
    }
}
