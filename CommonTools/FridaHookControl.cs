using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools
{
    public partial class FridaHookControl : UserControl
    {
        //  Java/Native脚本生成完毕事件
        public event JavaScriptGenerateCompletedEventHandle JavaScriptGenerateCompleted;
        public event NativeScriptGenerateCompletedEventHandle NativeScriptGenerateCompleted;

        public delegate void JavaScriptGenerateCompletedEventHandle(Object sender, UserConfigEventArgs e);
        public delegate void NativeScriptGenerateCompletedEventHandle(Object sender, UserConfigEventArgs e);

        //public ToolStripButton GenScript_Java_Button
        //{
        //    get
        //    {
        //        return btn_genJavaScript; ;
        //    }
        //}

        //public ToolStripButton GenScript_Native_Button
        //{
        //    get
        //    {
        //        return btn_genNativeScript;
        //    }
        //}

        public FridaHookControl()
        {
            InitializeComponent();
        }

        private void btn_genJavaScript_Click(object sender, EventArgs e)
        {
            if (JavaScriptGenerateCompleted != null)
            {
                UserConfigEventArgs args = new UserConfigEventArgs(ConstractResult(dataGridView_Java, tBox_className_java, tBox_functionName_java, tBox_param_java));
                JavaScriptGenerateCompleted(this, args);
            }
        }

        private void btn_genNativeScript_Click(object sender, EventArgs e)
        {
            if (NativeScriptGenerateCompleted != null)
            {
                UserConfigEventArgs args = new UserConfigEventArgs(ConstractResult(dataGridView_Native, tBox_className_native, tBox_functionName_native, tBox_param_native));
                NativeScriptGenerateCompleted(this, args);
            }
        }

        private ConfigResult ConstractResult(DataGridView grid, TextBox tBox_className, TextBox tBox_functionName, TextBox tBox_param)
        {
            ConfigResult result = new ConfigResult(tBox_className.Text.Trim(), tBox_functionName.Text.Trim(), tBox_param.Text.Trim());
            List<Dictionary<string, bool>> us = result.UserSelection;
            grid.EndEdit();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow)
                    continue;
                Dictionary<string, bool> map = new Dictionary<string, bool>();
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[col.Index];
                    bool checkFlag = Convert.ToBoolean(cell.Value);
                    map.Add(col.Name, checkFlag);
                }
                us.Add(map);
            }

            return result;
        }

    }
}
