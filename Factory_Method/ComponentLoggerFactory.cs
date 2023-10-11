using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class ComponentLoggerFactory : LoggerFactory
    {
        private readonly ListBox _listBox;
        public ComponentLoggerFactory(ListBox listBox1)
        {
            _listBox = listBox1;
        }
        public override ILogger CreateLogger()
        {
            return new ComponentLogger(_listBox);
        }
    }
}
