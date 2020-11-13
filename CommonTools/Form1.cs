using CommonTools.Entity;
using CommonTools.Tools;
using ICSharpCode.TextEditor.Document;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tools_treeView.ExpandAll();
            output_txtBox.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("JavaScript");
            output_txtBox.Encoding = Encoding.GetEncoding("GB2312");
            
            input_txtBox.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("JavaScript");
            input_txtBox.Encoding = Encoding.GetEncoding("GB2312");
        }

        private void tools_treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null)
                return;

            ToolType tt = ToolType.NULL;
            if (!Enum.TryParse<ToolType>(e.Node.Tag.ToString(), true, out tt))
                return;

            switch (tt)
            {
                case ToolType.BASE64:
                    new Base64CodecTool(commonToolStrip, input_txtBox, output_txtBox);
                    break;
                case ToolType.AES:
                    new AESEncryptTool(commonToolStrip, input_txtBox, output_txtBox);
                    break;
                case ToolType.FRIDASCRIPT:
                    new HookTool(commonToolStrip, input_txtBox, output_txtBox, this.statusLabel1);

                    FormFridaScript frm = new FormFridaScript(input_txtBox, output_txtBox);
                    frm.ScriptGenerateCompleted += Frm_ScriptGenerateCompleted;
                    frm.Show();
                    break;
                case ToolType.FRIDASCRIPT_AUTO:
                    new AutoHookTool(commonToolStrip, input_txtBox, output_txtBox, this.statusLabel1);
                    break;
                default:
                    break;
            }

        }

        private void Frm_ScriptGenerateCompleted(object sender, EventArgs e)
        {
            statusLabel1.Text = "代码已生成！";
        }
    }
}
