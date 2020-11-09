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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FridaHookControl));
            this.tBox_param_java = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_className_java = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_functionName_java = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_Java = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_genJavaScript = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_Native = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_genNativeScript = new System.Windows.Forms.ToolStripButton();
            this.tBox_className_native = new System.Windows.Forms.TextBox();
            this.tBox_param_native = new System.Windows.Forms.TextBox();
            this.tBox_functionName_native = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stackInfo_java = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param1_java = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param2_java = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param3_java = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.retVal_java = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stackInfo_native = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param1_native = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param2_native = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.param3_native = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.retVal_native = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Java)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Native)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBox_param_java
            // 
            this.tBox_param_java.Location = new System.Drawing.Point(71, 76);
            this.tBox_param_java.Name = "tBox_param_java";
            this.tBox_param_java.Size = new System.Drawing.Size(227, 28);
            this.tBox_param_java.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "参数：";
            // 
            // tBox_className_java
            // 
            this.tBox_className_java.Location = new System.Drawing.Point(71, 28);
            this.tBox_className_java.Name = "tBox_className_java";
            this.tBox_className_java.Size = new System.Drawing.Size(227, 28);
            this.tBox_className_java.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(308, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "函数名：";
            // 
            // tBox_functionName_java
            // 
            this.tBox_functionName_java.Location = new System.Drawing.Point(397, 28);
            this.tBox_functionName_java.Name = "tBox_functionName_java";
            this.tBox_functionName_java.Size = new System.Drawing.Size(143, 28);
            this.tBox_functionName_java.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "类名：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 498);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_Java);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Controls.Add(this.tBox_className_java);
            this.tabPage1.Controls.Add(this.tBox_param_java);
            this.tabPage1.Controls.Add(this.tBox_functionName_java);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Java";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Java
            // 
            this.dataGridView_Java.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Java.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Java.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stackInfo_java,
            this.param1_java,
            this.param2_java,
            this.param3_java,
            this.retVal_java});
            this.dataGridView_Java.Location = new System.Drawing.Point(6, 130);
            this.dataGridView_Java.MultiSelect = false;
            this.dataGridView_Java.Name = "dataGridView_Java";
            this.dataGridView_Java.RowTemplate.Height = 27;
            this.dataGridView_Java.Size = new System.Drawing.Size(570, 298);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_Native);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.tBox_className_native);
            this.tabPage2.Controls.Add(this.tBox_param_native);
            this.tabPage2.Controls.Add(this.tBox_functionName_native);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Native";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Native
            // 
            this.dataGridView_Native.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Native.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Native.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stackInfo_native,
            this.param1_native,
            this.param2_native,
            this.param3_native,
            this.retVal_native});
            this.dataGridView_Native.Location = new System.Drawing.Point(6, 130);
            this.dataGridView_Native.MultiSelect = false;
            this.dataGridView_Native.Name = "dataGridView_Native";
            this.dataGridView_Native.RowTemplate.Height = 27;
            this.dataGridView_Native.Size = new System.Drawing.Size(570, 298);
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
            // tBox_className_native
            // 
            this.tBox_className_native.Location = new System.Drawing.Point(71, 28);
            this.tBox_className_native.Name = "tBox_className_native";
            this.tBox_className_native.Size = new System.Drawing.Size(227, 28);
            this.tBox_className_native.TabIndex = 7;
            // 
            // tBox_param_native
            // 
            this.tBox_param_native.Location = new System.Drawing.Point(71, 76);
            this.tBox_param_native.Name = "tBox_param_native";
            this.tBox_param_native.Size = new System.Drawing.Size(227, 28);
            this.tBox_param_native.TabIndex = 11;
            // 
            // tBox_functionName_native
            // 
            this.tBox_functionName_native.Location = new System.Drawing.Point(397, 28);
            this.tBox_functionName_native.Name = "tBox_functionName_native";
            this.tBox_functionName_native.Size = new System.Drawing.Size(143, 28);
            this.tBox_functionName_native.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "类名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "参数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(308, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "函数名：";
            // 
            // stackInfo_java
            // 
            this.stackInfo_java.HeaderText = "堆栈";
            this.stackInfo_java.Name = "stackInfo_java";
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
            // param3_java
            // 
            this.param3_java.HeaderText = "参数3";
            this.param3_java.Name = "param3_java";
            // 
            // retVal_java
            // 
            this.retVal_java.HeaderText = "返回值";
            this.retVal_java.Name = "retVal_java";
            // 
            // stackInfo_native
            // 
            this.stackInfo_native.HeaderText = "堆栈";
            this.stackInfo_native.Name = "stackInfo_native";
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
            // param3_native
            // 
            this.param3_native.HeaderText = "参数3";
            this.param3_native.Name = "param3_native";
            // 
            // retVal_native
            // 
            this.retVal_native.HeaderText = "返回值";
            this.retVal_native.Name = "retVal_native";
            // 
            // FridaHookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FridaHookControl";
            this.Size = new System.Drawing.Size(590, 498);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Java)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Native)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_param_java;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox_functionName_java;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_className_java;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_genNativeScript;
        private System.Windows.Forms.TextBox tBox_className_native;
        private System.Windows.Forms.TextBox tBox_param_native;
        private System.Windows.Forms.TextBox tBox_functionName_native;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_Java;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_genJavaScript;
        private System.Windows.Forms.DataGridView dataGridView_Native;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stackInfo_java;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param1_java;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param2_java;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param3_java;
        private System.Windows.Forms.DataGridViewCheckBoxColumn retVal_java;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stackInfo_native;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param1_native;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param2_native;
        private System.Windows.Forms.DataGridViewCheckBoxColumn param3_native;
        private System.Windows.Forms.DataGridViewCheckBoxColumn retVal_native;
    }
}
