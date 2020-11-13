using ICSharpCode.TextEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools.Tools
{
    public abstract class StripTool
    {
        protected ToolStrip toolStrip;
        protected TextEditorControl inputBox;
        protected TextEditorControl outputBox;

        public StripTool(ToolStrip toolStrip, TextEditorControl inputBox, TextEditorControl outputBox)
        {
            this.toolStrip = toolStrip;
            this.inputBox = inputBox;
            this.outputBox = outputBox;
        }
        protected abstract void init();
    }
}
