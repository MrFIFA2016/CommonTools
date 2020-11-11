using CommonTools.Entity;
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
    public partial class FormFridaScript : Form
    {
        //代码生成完成事件
        public event ScriptGenerateCompletedEventHandle ScriptGenerateCompleted;

        public delegate void ScriptGenerateCompletedEventHandle(Object sender, EventArgs e);

        private RichTextBox inputBox, outputBox;
        public FormFridaScript(RichTextBox inputBox, RichTextBox outputBox)
        {
            InitializeComponent();
            this.inputBox = inputBox;
            this.outputBox = outputBox;
            fridaHookControl1.JavaScriptGenerateCompleted += FridaHookControl1_JavaScriptGenerateCompleted;
            fridaHookControl1.NativeScriptGenerateCompleted += FridaHookControl1_NativeScriptGenerateCompleted;
        }

        private void FridaHookControl1_NativeScriptGenerateCompleted(object sender, UserConfigEventArgs e)
        {
            int counter = 0;
            foreach (ConfigResult cr in e.ConfigResults)
            {
                foreach (Dictionary<String, ParaItem> chk in cr.UserSelection)
                {
                    List<ParaItem> checkedItems = chk.Values.ToList();
                    string script = CodeUtil.GenCode("native", inputBox.Text, cr.ClassName, cr.FunctionName, cr.Param, checkedItems, cr.ParamCount, counter++);
                    outputBox.Text += "\r\n" + script;
                }
            }
            ScriptGenerateCompleted?.Invoke(this, new EventArgs());
        }

        private void FridaHookControl1_JavaScriptGenerateCompleted(object sender, UserConfigEventArgs e)
        {
            int counter = 0;
            foreach (ConfigResult cr in e.ConfigResults)
            {
                foreach (Dictionary<String, ParaItem> chk in cr.UserSelection)
                {
                    List<ParaItem> checkedItems = chk.Values.ToList();
                    string script = CodeUtil.GenCode("java", inputBox.Text, cr.ClassName, cr.FunctionName, cr.Param, checkedItems, cr.ParamCount, counter++);
                    outputBox.Text += "\r\n" + script;
                }
            }
            ScriptGenerateCompleted?.Invoke(this, new EventArgs());
        }

    }
}
