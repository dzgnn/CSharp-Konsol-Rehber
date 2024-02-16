using System;

namespace Interface // Note: actual namespace depends on the project name.
{
    public class LogManager:ILogger{
        public ILogger _logger;
        public LogManager(ILogger logger){
            _logger = logger;
        }

        public void WriteLog()
        {
           _logger.WriteLog();
        }
    }


}