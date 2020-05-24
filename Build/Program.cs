using System;

namespace Build
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static System.Console;

    namespace DotNetDesignPatternDemos.Creational.Builder
    {

        public class Demo
        {
            static void Main(string[] args)
            {
                // if you want to build a simple HTML paragraph using StringBuilder
                var hello = "hello";
                var sb = new StringBuilder();
                sb.Append("<p>");
                sb.Append(hello);
                sb.Append("</p>");
                Console.WriteLine(sb);

                var words = new [] { "hello", "world" };
                sb.Clear();
                sb.Append("<ul>");
                foreach (var item in words)
                {
                    sb.Append($"<li>{ item }</li>");
                }
                sb.Append("</ul>");
                Console.WriteLine(sb);

                var build = new HtmlElement();
                var builder = new HtmlBuilder("ul");

                builder.AddChild("li", "Luis").AddChild("li", "Pedro");

                builder.AddChild("li", "Perez");
                builder.AddChild("li", "Gomez");

                Console.WriteLine(builder.ToString());

            }
        }
    }
}
