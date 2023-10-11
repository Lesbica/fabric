using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class FileLoggerFactory : LoggerFactory
    {
        private string _fileName;

        public FileLoggerFactory(string _fileName) 
        { 
            this._fileName = _fileName;
        }

        public override ILogger CreateLogger()
        {
            return new FileLogger(_fileName);
        }
    }
}
