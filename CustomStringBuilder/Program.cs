using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder();

            cb.AppendLine("class Foo")
                .AppendLine("{")
                .AppendLine("}");

            Console.WriteLine(cb);

            var sb = new StringBuilder();

            sb.AppendLine("class 2 ").AppendLine("2");

            Console.WriteLine(sb);

        }
    }
}
