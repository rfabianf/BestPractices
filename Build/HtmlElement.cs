using System;
using System.Collections.Generic;
using System.Text;

namespace Build
{
    public class HtmlElement
    {
        public string Text, Name;
        public List<HtmlElement> htmlElements = new List<HtmlElement>();
        private const int indentSize = 2;

        public HtmlElement()
        {

        }

        public HtmlElement(string Name, string Text)
        {
            this.Text = Text ?? throw new ArgumentNullException(paramName: nameof(Text));
            this.Name = Name ?? throw new ArgumentNullException(paramName: nameof(Name));
        }

        private string StringImpl(int indent)
        {
            var sb = new StringBuilder();
            string i = new string(' ', indentSize * indent);
            sb.AppendLine($"{i}<{Name}>");

            if(!String.IsNullOrEmpty(Text))
            {
                sb.Append(new string(' ',indent * (indentSize +1)));
                sb.AppendLine(Text);
            }

            foreach (var e in htmlElements)
            {
                sb.Append(e.StringImpl(indent + 1));
            }
            sb.AppendLine($"{i}</{Name}>");
            return sb.ToString();
        }

        public override string ToString()
        {
            return StringImpl(0);
        }
    }
}
