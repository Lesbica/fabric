using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Method
{
    public class ComponentLogger : ILogger
    {
        private ListBox listBox;

        public ComponentLogger(ListBox listBox)
        {
            this.listBox = listBox;
        }

        public void Log(string message)
        {
            listBox.Items.Add($"{DateTime.Now}: {message}");
        }
    }
}
