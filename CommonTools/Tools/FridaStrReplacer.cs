using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools.Tools
{
    public class FridaStrReplacer : BaseTool
    {
        public FridaStrReplacer(ToolStrip toolStrip, RichTextBox inputBox, RichTextBox outputBox) : base(toolStrip, inputBox, outputBox)
        {
            init();
        }

        protected override void init()
        {
            this.toolStrip.Items.Clear();
        }

    }
}
