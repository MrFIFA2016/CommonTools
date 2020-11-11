using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Entity
{
    public class ConfigResult
    {
        String className;
        String functionName;
        String param;
        int paramCount;
        List<Dictionary<string, ParaItem>> userSelection = new List<Dictionary<string, ParaItem>>();

        public ConfigResult(string className, string functionName, string param, int paramCount)
        {
            this.className = className;
            this.functionName = functionName;
            this.param = param;
            this.paramCount = paramCount;
        }

        public string ClassName { get => className; }
        public string FunctionName { get => functionName; }
        public string Param { get => param; }
        public List<Dictionary<string, ParaItem>> UserSelection { get => userSelection; }
        public int ParamCount { get => paramCount; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Dictionary<string, ParaItem> item in userSelection)
            {
                string row = "{";
                foreach (var entity in item)
                {
                    row += " " + entity.Key + " -> " + entity.Value.ValuePrint + " |";
                }
                if (row.EndsWith("|"))
                    row = row.Substring(0, row.Length - 1);
                row += " }\r\n";
                sb.AppendLine(row);
            }

            return String.Format("ClassName= {0}, \r\n FunctionName= {1}, \r\n Param= {2}, \r\n paramCount={3},\r\n UserSelection=\r\n {4} ", className, functionName, param, paramCount, sb.ToString());
        }

    }
}
