using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public String Text { get; set; }

        public List<HtmlElement> childElements = new List<HtmlElement>();
        private const int indentSize = 2;

        public HtmlElement()
        {

        }
        public HtmlElement(string name, string text)
        {
            this.Name = name;
            this.Text = text;
        }

        private string ToStringImpl(int indent)
        {
            StringBuilder sp = new StringBuilder();
            string space = new string(' ', indentSize * indent);

            sp.AppendLine($"{space}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sp.Append($"{new string(' ', indentSize * (indent + 1))}");
                sp.AppendLine(Text);
            }

            foreach (var child in childElements)
            {
                //Without Recursion

                //var childIndent = new string(' ', indentSize * (indent + 1));
                //sp.AppendLine($"{childIndent}<{child.Name}>");
                //sp.AppendLine($"{childIndent}{child.Text}");
                //sp.AppendLine($"{childIndent}</{child.Name}>");

                //Using Recursion
                 sp.AppendLine(child.ToStringImpl(indent+1));
            }

            sp.Append($"{space}</{this.Name}>");
            return sp.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }

    }
}
