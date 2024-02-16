using System;

namespace Interface // Note: actual namespace depends on the project name.
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
          //  throw new NotImplementedException();
          Console.WriteLine("Database'ye log yazar.");
        }
    }


}