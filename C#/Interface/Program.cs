using System;

namespace Interface // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmsLogger smslogger = new SmsLogger();
            smslogger.WriteLog();

            DatabaseLogger databaselogger = new();
            databaselogger.WriteLog();

            LogManager logmanager = new LogManager(new SmsLogger());
            logmanager.WriteLog();
        }
    }
}