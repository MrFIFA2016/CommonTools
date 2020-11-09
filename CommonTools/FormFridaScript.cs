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
            this.fridaHookControl1.GenScript_Java_Button.Click += GenScript_Java_Button_Click;
            this.fridaHookControl1.GenScript_Native_Button.Click += GenScript_Native_Button_Click;
        }

        private void GenScript_Native_Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GenScript_Java_Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
