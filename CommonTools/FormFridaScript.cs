using CommonTools.Entity;
using ICSharpCode.TextEditor;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        private TextEditorControl inputBox;
        private TextEditorControl outputBox;

        public FormFridaScript(TextEditorControl inputBox, TextEditorControl outputBox)
        {
            InitializeComponent();
            this.inputBox = inputBox;
            this.outputBox = outputBox;
            fridaHookControl1.JavaScriptGenerateCompleted += FridaHookControl1_JavaScriptGenerateCompleted;
            fridaHookControl1.NativeScriptGenerateCompleted += FridaHookControl1_NativeScriptGenerateCompleted;
            fridaHookControl1.JavaJsonGenerateCompleted += FridaHookControl1_JavaJsonGenerateCompleted;
            fridaHookControl1.NativeJsonGenerateCompleted += FridaHookControl1_NativeJsonGenerateCompleted;
        }

        private void FridaHookControl1_NativeJsonGenerateCompleted(object sender, NativeConfigEventArgs e)
        {
            inputBox.Text = JsonConvert.SerializeObject(e.Config, Formatting.Indented);
        }

        private void FridaHookControl1_JavaJsonGenerateCompleted(object sender, JavaConfigEventArgs e)
        {
            inputBox.Text = JsonConvert.SerializeObject(e.Config, Formatting.Indented);
        }

        private void FridaHookControl1_NativeScriptGenerateCompleted(object sender, NativeConfigEventArgs e)
        {
            int counter = 0;
            string res = "";
            foreach (NativeConfig cr in e.Config.ConfigList)
            {
                foreach (Dictionary<string, NativeParaItem> chk in cr.ParamConfig)
                {
                    List<Object> checkedItems = chk.Values.ToList<Object>();
                    string script = CodeUtil.GenNativeCode(cr.ModelName, cr.Address, checkedItems, counter++);
                    res += "\r\n" + script;
                }
            }
            outputBox.Text = res;
            outputBox.Refresh();
            ScriptGenerateCompleted?.Invoke(this, e);
        }

        private void FridaHookControl1_JavaScriptGenerateCompleted(object sender, JavaConfigEventArgs e)
        {
            int counter = 0;
            string res = "";
            foreach (JavaConfig cr in e.Config.ConfigList)
            {
                foreach (Dictionary<string, JavaParaItem> chk in cr.ParamConfig)
                {
                    List<Object> checkedItems = chk.Values.ToList<Object>();
                    string script = CodeUtil.GenJavaCode(cr.ClassName, cr.FunctionName, cr.Param, checkedItems, cr.ParamCount, counter++);
                    res += "\r\n" + script;
                }
            }
            outputBox.Text = res;
            outputBox.Refresh();
            ScriptGenerateCompleted?.Invoke(this, e);
        }

    }
}
