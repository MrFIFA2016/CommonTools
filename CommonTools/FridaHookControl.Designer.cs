namespace CommonTools
{
    partial class FridaHookControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FridaHookControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_java = new System.Windows.Forms.TabPage();
            this.dataGridView_Java = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_genJavaScript = new System.Windows.Forms.ToolStripButton();
            this.tabPage_native = new System.Windows.Forms.TabPage();
            this.dataGridView_Native = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_genNativeScript = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip_default = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加参数列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.className_Java = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionName_Java = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param_Java = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramCount_Java = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stackInfo_java = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.retVal_java = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param0_java = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param1_java = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param2_java = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.className_Native = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionName_Native = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param_Native = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramCount_Native = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stackInfo_native = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.retVal_native = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param0_native = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param1_native = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param2_native = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage_java.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Java)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage_native.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Native)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip_default.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_java);
            this.tabControl1.Controls.Add(this.tabPage_native);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 498);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_java
            // 
            this.tabPage_java.Controls.Add(this.dataGridView_Java);
            this.tabPage_java.Controls.Add(this.toolStrip2);
            this.tabPage_java.Location = new System.Drawing.Point(4, 28);
            this.tabPage_java.Name = "tabPage_java";
            this.tabPage_java.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_java.Size = new System.Drawing.Size(582, 466);
            this.tabPage_java.TabIndex = 0;
            this.tabPage_java.Text = "Java";
            this.tabPage_java.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Java
            // 
            this.dataGridView_Java.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Java.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Java.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.className_Java,
            this.functionName_Java,
            this.param_Java,
            this.paramCount_Java,
            this.stackInfo_java,
            this.retVal_java,
            this.param0_java,
            this.param1_java,
            this.param2_java});
            this.dataGridView_Java.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Java.MultiSelect = false;
            this.dataGridView_Java.Name = "dataGridView_Java";
            this.dataGridView_Java.RowTemplate.Height = 27;
            this.dataGridView_Java.Size = new System.Drawing.Size(570, 422);
            this.dataGridView_Java.TabIndex = 13;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_genJavaScript});
            this.toolStrip2.Location = new System.Drawing.Point(3, 431);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(576, 32);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_genJavaScript
            // 
            this.btn_genJavaScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_genJavaScript.Image = ((System.Drawing.Image)(resources.GetObject("btn_genJavaScript.Image")));
            this.btn_genJavaScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_genJavaScript.Name = "btn_genJavaScript";
            this.btn_genJavaScript.Size = new System.Drawing.Size(92, 29);
            this.btn_genJavaScript.Text = "生成脚本";
            this.btn_genJavaScript.Click += new System.EventHandler(this.btn_genJavaScript_Click);
            // 
            // tabPage_native
            // 
            this.tabPage_native.Controls.Add(this.dataGridView_Native);
            this.tabPage_native.Controls.Add(this.toolStrip1);
            this.tabPage_native.Location = new System.Drawing.Point(4, 28);
            this.tabPage_native.Name = "tabPage_native";
            this.tabPage_native.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_native.Size = new System.Drawing.Size(582, 466);
            this.tabPage_native.TabIndex = 1;
            this.tabPage_native.Text = "Native";
            this.tabPage_native.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Native
            // 
            this.dataGridView_Native.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Native.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Native.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.className_Native,
            this.functionName_Native,
            this.param_Native,
            this.paramCount_Native,
            this.stackInfo_native,
            this.retVal_native,
            this.param0_native,
            this.param1_native,
            this.param2_native});
            this.dataGridView_Native.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Native.MultiSelect = false;
            this.dataGridView_Native.Name = "dataGridView_Native";
            this.dataGridView_Native.RowTemplate.Height = 27;
            this.dataGridView_Native.Size = new System.Drawing.Size(570, 422);
            this.dataGridView_Native.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_genNativeScript});
            this.toolStrip1.Location = new System.Drawing.Point(3, 431);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(576, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_genNativeScript
            // 
            this.btn_genNativeScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_genNativeScript.Image = ((System.Drawing.Image)(resources.GetObject("btn_genNativeScript.Image")));
            this.btn_genNativeScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_genNativeScript.Name = "btn_genNativeScript";
            this.btn_genNativeScript.Size = new System.Drawing.Size(92, 29);
            this.btn_genNativeScript.Text = "生成脚本";
            this.btn_genNativeScript.Click += new System.EventHandler(this.btn_genNativeScript_Click);
            // 
            // contextMenuStrip_default
            // 
            this.contextMenuStrip_default.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_default.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加参数列ToolStripMenuItem});
            this.contextMenuStrip_default.Name = "contextMenuStrip_default";
            this.contextMenuStrip_default.Size = new System.Drawing.Size(154, 28);
            // 
            // 增加参数列ToolStripMenuItem
            // 
            this.增加参数列ToolStripMenuItem.Name = "增加参数列ToolStripMenuItem";
            this.增加参数列ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.增加参数列ToolStripMenuItem.Text = "增加参数列";
            this.增加参数列ToolStripMenuItem.Click += new System.EventHandler(this.增加列ToolStripMenuItem_Click);
            // 
            // className_Java
            // 
            this.className_Java.HeaderText = "类名";
            this.className_Java.Name = "className_Java";
            // 
            // functionName_Java
            // 
            this.functionName_Java.HeaderText = "函数名";
            this.functionName_Java.Name = "functionName_Java";
            // 
            // param_Java
            // 
            this.param_Java.HeaderText = "参数";
            this.param_Java.Name = "param_Java";
            // 
            // paramCount_Java
            // 
            this.paramCount_Java.HeaderText = "参数个数";
            this.paramCount_Java.Name = "paramCount_Java";
            this.paramCount_Java.Width = 120;
            // 
            // stackInfo_java
            // 
            this.stackInfo_java.HeaderText = "堆栈";
            this.stackInfo_java.Name = "stackInfo_java";
            // 
            // retVal_java
            // 
            this.retVal_java.HeaderText = "返回值";
            this.retVal_java.Name = "retVal_java";
            // 
            // param0_java
            // 
            this.param0_java.HeaderText = "参数0";
            this.param0_java.Name = "param0_java";
            // 
            // param1_java
            // 
            this.param1_java.HeaderText = "参数1";
            this.param1_java.Name = "param1_java";
            // 
            // param2_java
            // 
            this.param2_java.HeaderText = "参数2";
            this.param2_java.Name = "param2_java";
            // 
            // className_Native
            // 
            this.className_Native.Frozen = true;
            this.className_Native.HeaderText = "模块名";
            this.className_Native.Name = "className_Native";
            // 
            // functionName_Native
            // 
            this.functionName_Native.Frozen = true;
            this.functionName_Native.HeaderText = "地址";
            this.functionName_Native.Name = "functionName_Native";
            // 
            // param_Native
            // 
            this.param_Native.Frozen = true;
            this.param_Native.HeaderText = "参数";
            this.param_Native.Name = "param_Native";
            this.param_Native.Visible = false;
            // 
            // paramCount_Native
            // 
            this.paramCount_Native.Frozen = true;
            this.paramCount_Native.HeaderText = "参数个数";
            this.paramCount_Native.Name = "paramCount_Native";
            this.paramCount_Native.Visible = false;
            this.paramCount_Native.Width = 120;
            // 
            // stackInfo_native
            // 
            this.stackInfo_native.HeaderText = "堆栈";
            this.stackInfo_native.Name = "stackInfo_native";
            // 
            // retVal_native
            // 
            this.retVal_native.HeaderText = "返回值";
            this.retVal_native.Name = "retVal_native";
            // 
            // param0_native
            // 
            this.param0_native.HeaderText = "参数0";
            this.param0_native.Name = "param0_native";
            // 
            // param1_native
            // 
            this.param1_native.HeaderText = "参数1";
            this.param1_native.Name = "param1_native";
            // 
            // param2_native
            // 
            this.param2_native.HeaderText = "参数2";
            this.param2_native.Name = "param2_native";
            // 
            // FridaHookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FridaHookControl";
            this.Size = new System.Drawing.Size(590, 498);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_java.ResumeLayout(false);
            this.tabPage_java.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Java)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage_native.ResumeLayout(false);
            this.tabPage_native.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Native)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip_default.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_java;
        private System.Windows.Forms.TabPage tabPage_native;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_genNativeScript;
        private System.Windows.Forms.DataGridView dataGridView_Java;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_genJavaScript;
        private System.Windows.Forms.DataGridView dataGridView_Native;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_default;
        private System.Windows.Forms.ToolStripMenuItem 增加参数列ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn className_Java;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionName_Java;
        private System.Windows.Forms.DataGridViewTextBoxColumn param_Java;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramCount_Java;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stackInfo_java;
        private System.Windows.Forms.DataGridViewCheckBoxColumn retVal_java;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param0_java;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param1_java;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param2_java;
        private System.Windows.Forms.DataGridViewTextBoxColumn className_Native;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionName_Native;
        private System.Windows.Forms.DataGridViewTextBoxColumn param_Native;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramCount_Native;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stackInfo_native;
        private System.Windows.Forms.DataGridViewCheckBoxColumn retVal_native;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param0_native;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param1_native;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param2_native;
    }
}
