using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools
{
    public partial class FridaHookControl : UserControl
    {
        public ToolStripButton GenScript_Java_Button
        {
            get
            {
                return btn_genJavaScript; ;
            }
        }

        public ToolStripButton GenScript_Native_Button
        {
            get
            {
                return btn_genNativeScript;
            }
        }

        public FridaHookControl()
        {
            InitializeComponent();
        }

    }
}
