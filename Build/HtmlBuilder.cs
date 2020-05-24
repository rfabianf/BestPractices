using System;
using System.Collections.Generic;
using System.Text;

namespace Build
{
    public class HtmlBuilder
    {
        private readonly string rootName;
        public HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public HtmlBuilder AddChild(string childName,string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.htmlElements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void clear()
        {
            root = new HtmlElement() { Name = rootName };
        }
    }
}
