using System;

namespace Interface // Note: actual namespace depends on the project name.
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
           // throw new NotImplementedException();
           Console.WriteLine("Sms olarak log yazar.");
        }
    }


}