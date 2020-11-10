using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    public class UserConfigEventArgs : EventArgs
    {
        public UserConfigEventArgs(List<ConfigResult> configResults) : base()
        {
            this.configResults = configResults;
        }

        List<ConfigResult> configResults;

        public List<ConfigResult> ConfigResults { get => configResults; }
    }
}
