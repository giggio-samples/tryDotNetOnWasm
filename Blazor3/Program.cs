using Microsoft.AspNetCore.Blazor.Browser.Services;
using System;

namespace Blazor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.AspNetCore.Blazor.Browser.Interop.RegisteredFunction.Invoke<object>("done", "hello from c#");
        }
        public static string Echo(string msg) => $"Echo: {msg}";
        public static string Fatorial(string nString)
        {
            var n = Convert.ToInt32(nString);
            if (n <= 1) return "-1";
            var total = 1;
            while (n > 1)
            {
                total *= n;
                n--;
            }
            return total.ToString();
        }
    }
}
