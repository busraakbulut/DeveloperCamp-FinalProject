using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Message = message;
            // Success = success;
        }
        public Result(bool success) //Mesaj vermek istemediğimizde bu kod bloğunu çalıştırmak istiyoruz
        {
            Success = success;
        }
        public bool Success { get; }
        // Get edip set etmesek bile constructorlara özel bir özellik olarak set edebiliyoruz.
        public string Message { get; }
    }
}
