using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    public class ConfigResult
    {
        String className;
        String functionName;
        String param;
        List<Dictionary<string, bool>> userSelection = new List<Dictionary<string, bool>>();

        public ConfigResult(string className, string functionName, string param)
        {
            this.className = className;
            this.functionName = functionName;
            this.param = param;
        }

        public string ClassName { get => className; }
        public string FunctionName { get => functionName; }
        public string Param { get => param; }
        public List<Dictionary<string, bool>> UserSelection { get => userSelection; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Dictionary<string, bool> item in userSelection)
            {
                string row = "{";
                foreach (var entity in item)
                {
                    row += " " + entity.Key + " -> " + entity.Value + " |";
                }
                if (row.EndsWith("|"))
                    row = row.Substring(0, row.Length - 1);
                row += " }\r\n";
                sb.AppendLine(row);
            }

            return String.Format("ClassName= {0}, \r\n FunctionName= {1}, \r\n Param= {2}, \r\n UserSelection=\r\n {3} ", className, functionName, param, sb.ToString());
        }

    }
}
