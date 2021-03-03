using System;
using Business.CCS;

public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı.");
        }
    }
