using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Entity
{
    public class NativeConfig: BaseConfig
    {
        String modelName;
        String address;

        List<Dictionary<string, NativeParaItem>> paramConfig = new List<Dictionary<string, NativeParaItem>>();
        public NativeConfig(string modelName, string address)
        {
            this.ModelName = modelName;
            this.Address = address;
        }

        public string ModelName { get => modelName; set => modelName = value; }
        public string Address { get => address; set => address = value; }
        public List<Dictionary<string, NativeParaItem>> ParamConfig { get => paramConfig; set => paramConfig = value; }

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

            return String.Format("ModelName= {0}, \r\n Address= {1}, \r\n  Config=\r\n {2} ", ModelName, Address, sb.ToString());
        }

    }
}
