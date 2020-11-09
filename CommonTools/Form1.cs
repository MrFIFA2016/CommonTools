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
            foreach (TreeNode node in tools_treeView.Nodes)
            {
                node.Expand();
            }
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
                    //new FridaStrReplacer(commonToolStrip, input_txtBox, output_txtBox);
                    {
                        FormFridaScript frm = new FormFridaScript(input_txtBox, output_txtBox);
                        frm.Show();
                    }
                    break;
                default:
                    break;
            }

        }

    }
}
