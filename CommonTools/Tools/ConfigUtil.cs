using CommonTools.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Tools
{
    public class ConfigUtil
    {
        public static UserConfig<BaseConfig> ReadConfig(String json)
        {
            Dictionary<String, Object> map = JsonConvert.DeserializeObject<Dictionary<String, Object>>(json);
            string hookType = map["Type"].ToString().Trim().ToUpper(); ;
            HookType type = (HookType)Enum.Parse(typeof(HookType), hookType);
            JArray configs = (JArray)map["ConfigList"];
            switch (type)
            {
                case HookType.JAVA:
                    {
                        List<JavaConfig> list = configs.ToObject<List<JavaConfig>>();
                        List<BaseConfig> baseList = new List<BaseConfig>(list.Cast<BaseConfig>());
                        UserConfig<BaseConfig> config = new UserConfig<BaseConfig>(baseList);
                        config.Type = type.ToString().ToLower();
                        return config;
                    }
                case HookType.NATIVE:
                    {
                        List<NativeConfig> list = configs.ToObject<List<NativeConfig>>();
                        List<BaseConfig> baseList = new List<BaseConfig>(list.Cast<BaseConfig>());
                        UserConfig<BaseConfig> config = new UserConfig<BaseConfig>(baseList);
                        config.Type = type.ToString().ToLower();
                        return config;
                    }
                default:
                    break;
            }
            return null;
        }
    }
}
