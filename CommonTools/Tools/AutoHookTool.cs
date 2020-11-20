using CommonTools.Entity;
using ICSharpCode.TextEditor;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools.Tools
{
    public class AutoHookTool : StripTool
    {
        ToolStripStatusLabel statusLabel;
        public AutoHookTool(ToolStrip toolStrip, TextEditorControl inputBox, TextEditorControl outputBox, ToolStripStatusLabel statusLabel) : base(toolStrip, inputBox, outputBox)
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
                Text = "生成代码"
            };
            this.toolStrip.Items.Add(btn2);
            btn2.Click += Btn2_Click;

            ToolStripButton btn3 = new ToolStripButton
            {
                Text = "复制输出代码"
            };
            this.toolStrip.Items.Add(btn3);
            btn3.Click += Btn3_Click;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            string json = inputBox.Text;
            UserConfig<BaseConfig> config = ConfigUtil.ReadConfig(json);
            HookType type = (HookType)Enum.Parse(typeof(HookType), config.Type.ToUpper());
            int counter = 0;
            string res = "";
            foreach (BaseConfig cr in config.ConfigList)
            {
                switch (type)
                {
                    case HookType.JAVA:
                        {
                            JavaConfig result = (JavaConfig)cr;
                            foreach (Dictionary<string, JavaParaItem> chk in result.ParamConfig)
                            {
                                List<Object> checkedItems = chk.Values.ToList<Object>();
                                string script = CodeUtil.GenJavaCode(result.ClassName, result.FunctionName, result.Param, checkedItems, result.ParamCount, counter++);
                                res += "\r\n" + script;
                            }
                           
                        }
                        break;
                    case HookType.NATIVE:
                        {
                            NativeConfig result = (NativeConfig)cr;
                            foreach (Dictionary<string, NativeParaItem> chk in result.ParamConfig)
                            {
                                List<Object> checkedItems = chk.Values.ToList<Object>();
                                string script = CodeUtil.GenNativeCode(result.ModelName, result.Address, checkedItems, counter++);
                                res += "\r\n" + script;
                            }
                            //outputBox.Text = res;
                            //outputBox.Refresh();
                        }
                        break;
                    default:
                        break;
                }
            }
            outputBox.Text = res;
            outputBox.Refresh();
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

        private void Btn3_Click(object sender, EventArgs e)
        {
            outputBox.Focus();
            Clipboard.SetDataObject(outputBox.Text);
            statusLabel.Text = "代码已复制！共" + outputBox.Text.Length + "个字符";
        }
    }
}
