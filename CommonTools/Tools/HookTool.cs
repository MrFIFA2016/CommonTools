using ICSharpCode.TextEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools.Tools
{
    public class HookTool : StripTool
    {
        ToolStripStatusLabel statusLabel;
        public HookTool(ToolStrip toolStrip, TextEditorControl inputBox, TextEditorControl outputBox, ToolStripStatusLabel statusLabel) : base(toolStrip, inputBox, outputBox)
        {
            init();
            this.statusLabel = statusLabel;
        }

        protected override void init()
        {
            this.toolStrip.Items.Clear();

            ToolStripButton btn0 = new ToolStripButton
            {
                Text = "清空输入"
            };
            this.toolStrip.Items.Add(btn0);
            btn0.Click += Btn0_Click;

            ToolStripButton btn1 = new ToolStripButton
            {
                Text = "清空输出"
            };
            this.toolStrip.Items.Add(btn1);
            btn1.Click += Btn1_Click;

            ToolStripButton btn2 = new ToolStripButton
            {
                Text = "复制输出代码"
            };
            this.toolStrip.Items.Add(btn2);
            btn2.Click += Btn2_Click;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            inputBox.Refresh();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            outputBox.Refresh();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            outputBox.Focus();
            Clipboard.SetDataObject(outputBox.Text);
            statusLabel.Text = "代码已复制！共" + outputBox.Text.Length + "个字符";
        }
    }
}
