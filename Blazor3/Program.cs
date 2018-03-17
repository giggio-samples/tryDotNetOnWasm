using Microsoft.AspNetCore.Blazor.Browser.Services;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Blazor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.AspNetCore.Blazor.Browser.Interop.RegisteredFunction.Invoke<object>("done", "hello from c#");
        }
        public static string Echo(string msg) => $"Echo: {msg}";
        public static string Fatorial(string nString) => Fatorial(Convert.ToInt32(nString)).ToString();
        public static int Fatorial(int n)
        {
            if (n <= 1) return -1;
            var total = 1;
            while (n > 1)
            {
                total *= n;
                n--;
            }
            return total;
        }

        public static string DesempenhoThreads()
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            Parallel.For(0, 1_000_000, i => Fatorial(12));
            sw.Stop();
            return sw.ElapsedMilliseconds.ToString();
        }

        public static string Desempenho()
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 1_000_000; i++)
            {
                var res = Fatorial(12);
            }
            sw.Stop();
            return sw.ElapsedMilliseconds.ToString();
        }

        public static int FatorialNaoOtimizado(int n)
        {
            if ((DateTime.Now.Millisecond % 2) == 0)
            {
                n++;
                if (n > 12) n = 12;
            }
            if (n <= 1) return -1;
            var total = 1;
            while (n > 1)
            {
                total *= n;
                n--;
            }
            return total;
        }

        public static string DesempenhoNaoOtimizado()
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 1_000_000; i++)
            {
                var res = FatorialNaoOtimizado(12);
            }
            sw.Stop();
            return sw.ElapsedMilliseconds.ToString();
        }
    }
}
