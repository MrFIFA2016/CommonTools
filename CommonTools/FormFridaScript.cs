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
            MessageBox.Show(e.ConfigResult.ToString());
        }

        private void FridaHookControl1_JavaScriptGenerateCompleted(object sender, UserConfigEventArgs e)
        {
            //MessageBox.Show(e.ConfigResult.ToString());
            //outputBox.Text = e.ConfigResult.ToString();


        }

    }
}
