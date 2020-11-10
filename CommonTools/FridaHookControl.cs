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

        public FridaHookControl()
        {
            InitializeComponent();
        }

        private void btn_genJavaScript_Click(object sender, EventArgs e)
        {
            if (JavaScriptGenerateCompleted != null)
            {
                UserConfigEventArgs args = new UserConfigEventArgs(ConstractResults(dataGridView_Java));
                JavaScriptGenerateCompleted(this, args);
            }
        }

        private void btn_genNativeScript_Click(object sender, EventArgs e)
        {
            if (NativeScriptGenerateCompleted != null)
            {
                UserConfigEventArgs args = new UserConfigEventArgs(ConstractResults(dataGridView_Native));
                NativeScriptGenerateCompleted(this, args);
            }
        }

        private List<ConfigResult> ConstractResults(DataGridView grid)
        {
            grid.EndEdit();

            List<ConfigResult> results = new List<ConfigResult>();

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow)
                    continue;

                Dictionary<string, bool> map = new Dictionary<string, bool>();

                string className = ((DataGridViewTextBoxCell)row.Cells[0]).Value.ToString();
                string functionName = ((DataGridViewTextBoxCell)row.Cells[1]).Value.ToString();
                string param = ((DataGridViewTextBoxCell)row.Cells[2]).Value.ToString();
                string paramCount = ((DataGridViewTextBoxCell)row.Cells[3]).Value.ToString();

                ConfigResult result = new ConfigResult(className, functionName, param, paramCount);

                for (int i = 4; i < grid.Columns.Count; i++)
                {
                    DataGridViewColumn col = grid.Columns[i];
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[col.Index];
                    bool checkFlag = Convert.ToBoolean(cell.Value);
                    map.Add(col.Name, checkFlag);
                }
                //us.Add(map);
                result.UserSelection.Add(map);
                results.Add(result);
            }

            return results;
        }

    }
}
