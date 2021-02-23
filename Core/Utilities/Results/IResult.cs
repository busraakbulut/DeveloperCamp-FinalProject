using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel void fonksiyonlar için başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
