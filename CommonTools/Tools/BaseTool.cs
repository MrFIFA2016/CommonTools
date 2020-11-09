using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools.Tools
{
    public abstract class BaseTool
    {
        protected ToolStrip toolStrip;
        protected RichTextBox inputBox;
        protected RichTextBox outputBox;

        public BaseTool(ToolStrip toolStrip, RichTextBox inputBox, RichTextBox outputBox)
        {
            this.toolStrip = toolStrip;
            this.inputBox = inputBox;
            this.outputBox = outputBox;
        }
        protected abstract void init();
    }
}
