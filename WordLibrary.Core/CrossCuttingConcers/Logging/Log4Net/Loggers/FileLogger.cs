using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordLibrary.Core.CrossCuttingConcers.Logging.Log4Net.Loggers
{
    public class FileLogger : LoggerService
    {
        public FileLogger() : base(LogManager.GetLogger("JsonFileLogger"))
        {
        }
    }
}
