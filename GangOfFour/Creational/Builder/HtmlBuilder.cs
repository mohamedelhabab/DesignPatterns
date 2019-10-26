using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational
{
    public class HtmlBuilder
    {
        public string rootName { get; set; }
        public HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName,string text)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }
        public HtmlBuilder AddChild(string childName , string childText)
        {
            root.childElements.Add(new HtmlElement()
            {
                Name = childName ,
                Text = childText
            });

            return this;
        }

        public void Clear()
        {
            root = new HtmlElement() { Name = rootName};
        }

        public override string ToString()
        {
            return root.ToString();
        }
    }
}
