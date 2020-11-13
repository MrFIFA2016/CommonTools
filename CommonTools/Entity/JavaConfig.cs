using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Entity
{
    public class JavaConfig: BaseConfig
    {
        List<Dictionary<string, JavaParaItem>> paramConfig = new List<Dictionary<string, JavaParaItem>>();

        String className;
        String functionName;
        String param;
        int paramCount;

        public JavaConfig(string className, string functionName, string param, int paramCount)
        {
            this.ClassName = className;
            this.FunctionName = functionName;
            this.Param = param;
            this.ParamCount = paramCount;
        }

        public string ClassName { get => className; set => className = value; }
        public string FunctionName { get => functionName; set => functionName = value; }
        public string Param { get => param; set => param = value; }
        public int ParamCount { get => paramCount; set => paramCount = value; }
        public List<Dictionary<string, JavaParaItem>> ParamConfig { get => paramConfig; set => paramConfig = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //foreach (Dictionary<string, Object> item in Config)
            {
                //string row = "{";
                //foreach (var entity in item)
                //{
                //    row += " " + entity.Key + " -> " + entity.Value.ValuePrint + " |";
                //}
                //if (row.EndsWith("|"))
                //    row = row.Substring(0, row.Length - 1);
                //row += " }\r\n";
                //sb.AppendLine(row);
            }

            return String.Format("ClassName= {0}, \r\n FunctionName= {1}, \r\n Param= {2}, \r\n paramCount={3},\r\n Config=\r\n {4} ", ClassName, FunctionName, Param, ParamCount, sb.ToString());
        }

    }
}
