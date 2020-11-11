using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonTools.Entity;

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
            this.dataGridView_Native.MouseClick += DataGridView_Native_MouseClick;
            this.dataGridView_Java.ContextMenuStrip = this.contextMenuStrip_default;
            this.dataGridView_Native.ContextMenuStrip = this.contextMenuStrip_default;
            this.dataGridView_Native.CurrentCellDirtyStateChanged += DataGridView_Native_CurrentCellDirtyStateChanged;
            this.dataGridView_Native.CellValueChanged += DataGridView_Native_CellValueChanged;
            this.dataGridView_Java.CurrentCellDirtyStateChanged += DataGridView_Java_CurrentCellDirtyStateChanged;
            this.dataGridView_Java.CellValueChanged += DataGridView_Java_CellValueChanged;
        }

        private void DataGridView_Java_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView_Java.CurrentCell;
            Type tp = cell.ValueType;
            if (tp == typeof(Boolean))
            {
                if (cell.Tag == null)
                    cell.Tag = new ParaItem();
                ((ParaItem)cell.Tag).ValuePrint = (bool)cell.Value;
            }
        }

        private void DataGridView_Java_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView_Java.CurrentCell;
            Type tp = cell.ValueType;
            if (tp == typeof(Boolean))
            {
                dataGridView_Java.EndEdit();
            }
        }

        private void DataGridView_Native_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView_Native.Controls.Clear();
        }

        private void DataGridView_Native_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView_Native.CurrentCell;
            Type tp = cell.ValueType;
            if (tp == typeof(Boolean))
            {
                dataGridView_Native.EndEdit();
            }
        }

        Dictionary<String, MemPrintPanel> panelCache = new Dictionary<string, MemPrintPanel>();

        private void DataGridView_Native_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView_Native.CurrentCell;
            Type tp = cell.ValueType;
            if (tp == typeof(Boolean))
            {
                if (cell.Tag == null)
                    cell.Tag = new ParaItem();
                ((ParaItem)cell.Tag).ValuePrint = (bool)cell.Value;

                if ((cell.Value == null || (bool)cell.Value == true) && dataGridView_Native.Columns[cell.ColumnIndex].Name.StartsWith("param"))
                {
                    MemPrintPanel panel;
                    string panelName = "paraPanel_" + e.ColumnIndex + e.RowIndex;
                    if (panelCache.ContainsKey(panelName))
                        panel = panelCache[panelName];
                    else
                    {
                        panel = new MemPrintPanel((ParaItem)cell.Tag);
                        panelCache.Add(panelName, panel);
                    }

                    Rectangle rec = dataGridView_Native.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    panel.Location = rec.Location;
                    panel.Name = panelName;
                    dataGridView_Native.Controls.Add(panel);

                    panel.BringToFront();
                    panel.Visible = true;
                }

            }
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

                Dictionary<string, ParaItem> map = new Dictionary<string, ParaItem>();

                string className = Convert.ToString(((DataGridViewTextBoxCell)row.Cells[0]).Value);
                string functionName = Convert.ToString(((DataGridViewTextBoxCell)row.Cells[1]).Value);
                string param = Convert.ToString(((DataGridViewTextBoxCell)row.Cells[2]).Value);
                int paramCount = Convert.ToInt32(((DataGridViewTextBoxCell)row.Cells[3]).Value);

                ConfigResult result = new ConfigResult(className, functionName, param, paramCount);

                for (int i = 4; i < grid.Columns.Count; i++)
                {
                    DataGridViewColumn col = grid.Columns[i];
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[col.Index];
                    if (cell.Tag == null)
                        cell.Tag = new ParaItem();
                    // bool checkFlag = Convert.ToBoolean(cell.Value);
                    map.Add(col.Name, (ParaItem)cell.Tag);
                }
                result.UserSelection.Add(map);
                results.Add(result);
            }

            return results;
        }

        int maxColIndex_Java = 3;
        int maxColIndex_Native = 3;

        private void 增加列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab.Name == "tabPage_java")
            {
                DataGridViewCheckBoxColumn newCol = new DataGridViewCheckBoxColumn();
                newCol.HeaderText = "参数" + maxColIndex_Java++;
                newCol.Name = "param" + maxColIndex_Java + "_java";
                this.dataGridView_Java.Columns.Add(newCol);
            }
            if (this.tabControl1.SelectedTab.Name == "tabPage_native")
            {
                DataGridViewCheckBoxColumn newCol = new DataGridViewCheckBoxColumn();
                newCol.HeaderText = "参数" + maxColIndex_Native++;
                newCol.Name = "param" + maxColIndex_Native + "_native";
                this.dataGridView_Native.Columns.Add(newCol);
            }
        }



    }
}
