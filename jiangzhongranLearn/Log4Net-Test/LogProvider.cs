using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Config;

namespace Log4Net_Test
{
    public sealed class LogProvider
    {
        private static readonly ILog provider = GetLogger();
       
        static LogProvider() { }

        private LogProvider() { }

        public static void Log(string msg, LogEnum logType, Exception ex = null)
        {
            WriteLog(msg,logType,ex);
        }

        private static ILog GetLogger()
        {
            InitConfig();
            return LogManager.GetLogger("DefaultLogger");
        }

        public static void InitConfig()
        {
            XmlConfigurator.Configure();
        }

        private static void WriteLog(string msg,LogEnum logType,Exception ex)
        {
            if (provider != null) {
                switch (logType)
                { 
                    case LogEnum.Debug:
                        provider.Debug(msg,ex);
                        break;
                    case LogEnum.Error:
                        provider.Error(msg,ex);
                        break;
                    case LogEnum.Fatal:
                        provider.Fatal(msg,ex);
                        break;
                    case LogEnum.Info:
                        provider.Info(msg,ex);
                        break;
                    case LogEnum.Warn:
                        provider.Warn(msg,ex);
                        break;
                    default:
                        return;

                }
            }
        }
    }
}
