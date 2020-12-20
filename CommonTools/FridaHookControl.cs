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
using Newtonsoft.Json.Linq;

namespace CommonTools
{
    public partial class FridaHookControl : UserControl
    {
        //  Java/Native脚本生成完毕事件
        public event JavaScriptGenerateCompletedEventHandle JavaScriptGenerateCompleted;
        public event NativeScriptGenerateCompletedEventHandle NativeScriptGenerateCompleted;

        public event JavaScriptGenerateCompletedEventHandle JavaJsonGenerateCompleted;
        public event NativeScriptGenerateCompletedEventHandle NativeJsonGenerateCompleted;

        public delegate void JavaScriptGenerateCompletedEventHandle(Object sender, JavaConfigEventArgs e);
        public delegate void NativeScriptGenerateCompletedEventHandle(Object sender, NativeConfigEventArgs e);

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
                    cell.Tag = new JavaParaItem();
                ((JavaParaItem)cell.Tag).ValuePrint = (bool)cell.Value;
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
                    cell.Tag = new NativeParaItem();
                ((NativeParaItem)cell.Tag).ValuePrint = (bool)cell.Value;

                if ((cell.Value == null || (bool)cell.Value == true) && dataGridView_Native.Columns[cell.ColumnIndex].Name.StartsWith("param"))
                {
                    MemPrintPanel panel;
                    string panelName = "paraPanel_" + e.ColumnIndex + e.RowIndex;
                    if (panelCache.ContainsKey(panelName))
                        panel = panelCache[panelName];
                    else
                    {
                        panel = new MemPrintPanel((NativeParaItem)cell.Tag);
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
                List<JavaConfig> jConfigs = new List<JavaConfig>(ConstractResults(dataGridView_Java, HookType.JAVA).Cast<JavaConfig>());
                JavaConfigEventArgs args = new JavaConfigEventArgs(jConfigs);
                JavaScriptGenerateCompleted(this, args);
            }
        }

        private void btn_genNativeScript_Click(object sender, EventArgs e)
        {
            if (NativeScriptGenerateCompleted != null)
            {
                List<NativeConfig> nConfigs = new List<NativeConfig>(ConstractResults(dataGridView_Native, HookType.NATIVE).Cast<NativeConfig>());
                NativeConfigEventArgs args = new NativeConfigEventArgs(nConfigs);
                NativeScriptGenerateCompleted(this, args);
            }
        }

        private List<BaseConfig> ConstractResults(DataGridView grid, HookType type)
        {
            grid.EndEdit();
            List<BaseConfig> results = new List<BaseConfig>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string className = Convert.ToString(((DataGridViewTextBoxCell)row.Cells[0]).Value);
                string functionName = Convert.ToString(((DataGridViewTextBoxCell)row.Cells[1]).Value);
                string param = Convert.ToString(((DataGridViewTextBoxCell)row.Cells[2]).Value);
                int paramCount = Convert.ToInt32(((DataGridViewTextBoxCell)row.Cells[3]).Value);

                switch (type)
                {
                    case HookType.JAVA:
                        {
                            Dictionary<string, JavaParaItem> map = new Dictionary<string, JavaParaItem>();
                            JavaConfig result = new JavaConfig(className, functionName, param, paramCount);
                            for (int i = 4; i < grid.Columns.Count; i++)
                            {
                                DataGridViewColumn col = grid.Columns[i];
                                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[col.Index];
                                if (cell.Tag == null)
                                    cell.Tag = new JavaParaItem();
                                map.Add(col.Name, (JavaParaItem)cell.Tag);
                            }
                            result.ParamConfig.Add(map);
                            results.Add(result);
                        }
                        break;
                    case HookType.NATIVE:
                        {
                            Dictionary<string, NativeParaItem> map = new Dictionary<string, NativeParaItem>();
                            NativeConfig result = new NativeConfig(className, functionName);
                            for (int i = 4; i < grid.Columns.Count; i++)
                            {
                                DataGridViewColumn col = grid.Columns[i];
                                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[col.Index];
                                if (cell.Tag == null)
                                    cell.Tag = new NativeParaItem();
                                map.Add(col.Name, (NativeParaItem)cell.Tag);
                            }
                            result.ParamConfig.Add(map);
                            results.Add(result);
                        }
                        break;
                    default:
                        break;
                }
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
                newCol.HeaderText = "参数" + maxColIndex_Java;
                newCol.Name = "param" + maxColIndex_Java++ + "_java";
                this.dataGridView_Java.Columns.Add(newCol);
            }
            if (this.tabControl1.SelectedTab.Name == "tabPage_native")
            {
                DataGridViewCheckBoxColumn newCol = new DataGridViewCheckBoxColumn();
                newCol.HeaderText = "参数" + maxColIndex_Native;
                newCol.Name = "param" + maxColIndex_Native++ + "_native";
                this.dataGridView_Native.Columns.Add(newCol);
            }
        }

        private void btn_genJavaJson_Click(object sender, EventArgs e)
        {
            if (JavaJsonGenerateCompleted != null)
            {
                List<JavaConfig> jConfigs = new List<JavaConfig>(ConstractResults(dataGridView_Java, HookType.JAVA).Cast<JavaConfig>());
                JavaConfigEventArgs args = new JavaConfigEventArgs(jConfigs);
                JavaJsonGenerateCompleted(this, args);
            }
        }

        private void btn_genNativeJson_Click(object sender, EventArgs e)
        {
            if (NativeJsonGenerateCompleted != null)
            {
                List<NativeConfig> nConfigs = new List<NativeConfig>(ConstractResults(dataGridView_Native, HookType.NATIVE).Cast<NativeConfig>());
                NativeConfigEventArgs args = new NativeConfigEventArgs(nConfigs);
                NativeJsonGenerateCompleted(this, args);
            }
        }
    }
}
