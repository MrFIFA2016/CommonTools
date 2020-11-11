namespace CommonTools
{
    partial class MemPrintPanel
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
            this.cBox_printMem = new System.Windows.Forms.CheckBox();
            this.cBox_printMem64 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memLengthBox = new System.Windows.Forms.NumericUpDown();
            this.mem64LengthBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memLengthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mem64LengthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cBox_printMem
            // 
            this.cBox_printMem.AutoSize = true;
            this.cBox_printMem.Location = new System.Drawing.Point(15, 30);
            this.cBox_printMem.Name = "cBox_printMem";
            this.cBox_printMem.Size = new System.Drawing.Size(104, 19);
            this.cBox_printMem.TabIndex = 0;
            this.cBox_printMem.Text = "此参数内存";
            this.cBox_printMem.UseVisualStyleBackColor = true;
            this.cBox_printMem.CheckedChanged += new System.EventHandler(this.cBox_printMem_CheckedChanged);
            // 
            // cBox_printMem64
            // 
            this.cBox_printMem64.AutoSize = true;
            this.cBox_printMem64.Location = new System.Drawing.Point(15, 93);
            this.cBox_printMem64.Name = "cBox_printMem64";
            this.cBox_printMem64.Size = new System.Drawing.Size(165, 19);
            this.cBox_printMem64.TabIndex = 1;
            this.cBox_printMem64.Text = "内存读64位再取内存";
            this.cBox_printMem64.UseVisualStyleBackColor = true;
            this.cBox_printMem64.CheckedChanged += new System.EventHandler(this.cBox_printMem64_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mem64LengthBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.memLengthBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBox_printMem);
            this.groupBox1.Controls.Add(this.cBox_printMem64);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打印内存";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "长度：";
            // 
            // memLengthBox
            // 
            this.memLengthBox.Enabled = false;
            this.memLengthBox.Location = new System.Drawing.Point(67, 59);
            this.memLengthBox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.memLengthBox.Name = "memLengthBox";
            this.memLengthBox.Size = new System.Drawing.Size(101, 25);
            this.memLengthBox.TabIndex = 3;
            this.memLengthBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // mem64LengthBox
            // 
            this.mem64LengthBox.Enabled = false;
            this.mem64LengthBox.Location = new System.Drawing.Point(67, 122);
            this.mem64LengthBox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.mem64LengthBox.Name = "mem64LengthBox";
            this.mem64LengthBox.Size = new System.Drawing.Size(101, 25);
            this.mem64LengthBox.TabIndex = 5;
            this.mem64LengthBox.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "长度：";
            // 
            // MemPrintPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "MemPrintPanel";
            this.Size = new System.Drawing.Size(197, 170);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memLengthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mem64LengthBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cBox_printMem;
        private System.Windows.Forms.CheckBox cBox_printMem64;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown mem64LengthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown memLengthBox;
        private System.Windows.Forms.Label label1;
    }
}
