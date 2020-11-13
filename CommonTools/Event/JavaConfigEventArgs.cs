using CommonTools.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    public class JavaConfigEventArgs : EventArgs
    {
        public JavaConfigEventArgs(List<JavaConfig> configResults) : base()
        {
            this.Config = new UserConfig<JavaConfig>(configResults);
            this.config.Type = HookType.JAVA.ToString();
        }

        UserConfig<JavaConfig> config;
        

        public UserConfig<JavaConfig> Config { get => config; set => config = value; }
    }
}
