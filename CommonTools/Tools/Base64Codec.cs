using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools.Tools
{
    public class Base64Codec : BaseTool
    {

        public Base64Codec(ToolStrip toolStrip, RichTextBox inputBox, RichTextBox outputBox) :
            base(toolStrip, inputBox, outputBox)
        {
            init();
        }

        protected override void init()
        {
            this.toolStrip.Items.Clear();

            ToolStripButton btn1 = new ToolStripButton
            {
                Text = "编码"
            };
            this.toolStrip.Items.Add(btn1);
            btn1.Click += EncodeBtn_Click;

            ToolStripButton btn2 = new ToolStripButton
            {
                Text = "解码"
            };
            this.toolStrip.Items.Add(btn2);
            btn2.Click += Btn2_Click;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text.Trim();
            byte[] bytes = Convert.FromBase64String(input);
            string output = Encoding.Default.GetString(bytes);
            outputBox.Text = output;
        }

        private void EncodeBtn_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text.Trim();
            byte[] bytes = Encoding.Default.GetBytes(input);
            string output = Convert.ToBase64String(bytes);
            outputBox.Text = output;
        }

    }
}
