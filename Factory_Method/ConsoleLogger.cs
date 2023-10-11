using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            //Console.WriteLine("Console log: " + message);
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}
