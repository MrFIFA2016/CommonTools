using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    public class UserConfigEventArgs : EventArgs
    {
        public UserConfigEventArgs(ConfigResult configResult) : base()
        {
            this.configResult = configResult;
        }

        ConfigResult configResult;

        public ConfigResult ConfigResult { get => configResult; }
    }
}
