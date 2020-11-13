using CommonTools.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    public class NativeConfigEventArgs : EventArgs
    {
        public NativeConfigEventArgs(List<NativeConfig> configResults) : base()
        {
            this.config = new UserConfig<NativeConfig>(configResults);
            this.config.Type = HookType.NATIVE.ToString();
        }

        UserConfig<NativeConfig> config;

        public UserConfig<NativeConfig> Config { get => config; set => config = value; }
    }
}
