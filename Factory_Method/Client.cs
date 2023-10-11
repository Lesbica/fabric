using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Client
    {
        public void Main(LoggerFactory factory, string message)
        {
            ILogger logger = factory.CreateLogger();

            logger.Log(message);
        }
    }

}
