using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Entity
{
    public class UserConfig<T>
    {
        public UserConfig(List<T> configs)
        {
            this.configList = configs;
        }

        List<T> configList;
        String type = "native";

        public List<T> ConfigList { get => configList; set => configList = value; }
        public string Type { get => type; set => type = value; }
    }
}
