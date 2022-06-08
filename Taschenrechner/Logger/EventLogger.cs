using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Taschenrechner.Logger
{
    public class EventLogger : IDisposable
    {
        public EventLogger(string level, string message)
        {           
            LogManager.Setup().LoadConfiguration(builder => {
                builder.ForLogger().FilterMinLevel(LogLevel.Debug).WriteToFile(fileName: "${basedir}/logs/${shortdate}.log", "${longdate} ${level} ${message} ${exception} ");
            });
            var logger = LogManager.GetCurrentClassLogger();

            switch (level)
            {
                case "Info":
                    logger.Info(message);
                    break;
                case "Debug":
                    logger.Debug(message);
                    break;
                default:    
                    logger.Error(message);
                    break;
            }            
        }

        public void Dispose()
        {
        }
    }
}
