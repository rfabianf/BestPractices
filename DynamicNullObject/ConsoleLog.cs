using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicNullObject
{
    class ConsoleLog : ILog
    {
        public void Info(string msg)
        {
            Console.WriteLine(msg);
        }

        public void warn(string msg)
        {
            Console.WriteLine("Warning"+ msg);
        }
    }
}
