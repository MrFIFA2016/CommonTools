using CommonTools.Tools;
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
            //foreach (TreeNode node in tools_treeView.Nodes)
            //{
            //    node.Expand();
            //}
            this.tools_treeView.ExpandAll();
			textEditorControl1.ShowEOLMarkers = false;
			  textEditorControl1.ShowHRuler = false;
			  textEditorControl1.ShowInvalidLines = false;
			  textEditorControl1.ShowMatchingBracket = true;
			  textEditorControl1.ShowSpaces = false;
			  textEditorControl1.ShowTabs = false;
			  textEditorControl1.ShowVRuler = false;
			  textEditorControl1.AllowCaretBeyondEOL = false;
			  textEditorControl1.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("JavaScript");
			  textEditorControl1.Encoding = Encoding.GetEncoding("GB2312");
       
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
                    new Base64Codec(commonToolStrip, input_txtBox, output_txtBox);
                    break;
                case ToolType.AES:
                    new AESEncrypt(commonToolStrip, input_txtBox, output_txtBox);
                    break;
                case ToolType.FRIDASCRIPT:
                    new FridaStrReplacer(commonToolStrip, input_txtBox, output_txtBox, this.statusLabel1);
                    FormFridaScript frm = new FormFridaScript(input_txtBox, output_txtBox);
                    frm.ScriptGenerateCompleted += Frm_ScriptGenerateCompleted;
                    frm.Show();
                    break;
                default:
                    break;
            }

        }

        private void Frm_ScriptGenerateCompleted(object sender, EventArgs e)
        {
            statusLabel1.Text = "代码已生成！";
            this.Focus();
        }
    }
}
