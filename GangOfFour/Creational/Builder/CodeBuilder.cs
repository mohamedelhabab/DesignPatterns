using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Builder
{

    //Builder Coding Exercise
    public class CodeBuilder
    {
        StringBuilder sp = new StringBuilder();
        string indent = new string(' ', 2);


        public CodeBuilder(string className)
        {
            sp.AppendLine($"public class {className}");
            sp.AppendLine("{");
        }

        public CodeBuilder AddField(string fieldName, string fieldDataType)
        {
            sp.AppendLine($"{indent}public {fieldDataType} {fieldName};");
            return this;
        }       

        public override string ToString()
        {
            sp.AppendLine("}");
            return sp.ToString();
        }
    }
}
