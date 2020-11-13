namespace CommonTools
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Base64");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("AES");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("编解码工具", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Frida脚本界面工具");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Frida脚本批量生成");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("脚本工具", new System.Windows.Forms.TreeNode[] {
            treeNode53,
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("工具集", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode55});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer_Form = new System.Windows.Forms.SplitContainer();
            this.tools_treeView = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.output_txtBox = new ICSharpCode.TextEditor.TextEditorControl();
            this.commonToolStrip = new System.Windows.Forms.ToolStrip();
            this.input_txtBox = new ICSharpCode.TextEditor.TextEditorControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Form)).BeginInit();
            this.splitContainer_Form.Panel1.SuspendLayout();
            this.splitContainer_Form.Panel2.SuspendLayout();
            this.splitContainer_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(980, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 24);
            this.toolStripMenuItem1.Text = "文件";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(980, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(39, 20);
            this.statusLabel1.Text = "就绪";
            // 
            // splitContainer_Form
            // 
            this.splitContainer_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Form.Location = new System.Drawing.Point(0, 30);
            this.splitContainer_Form.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer_Form.Name = "splitContainer_Form";
            // 
            // splitContainer_Form.Panel1
            // 
            this.splitContainer_Form.Panel1.Controls.Add(this.tools_treeView);
            // 
            // splitContainer_Form.Panel2
            // 
            this.splitContainer_Form.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer_Form.Panel2.Controls.Add(this.commonToolStrip);
            this.splitContainer_Form.Size = new System.Drawing.Size(980, 514);
            this.splitContainer_Form.SplitterDistance = 225;
            this.splitContainer_Form.SplitterWidth = 8;
            this.splitContainer_Form.TabIndex = 2;
            // 
            // tools_treeView
            // 
            this.tools_treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tools_treeView.Location = new System.Drawing.Point(0, 0);
            this.tools_treeView.Margin = new System.Windows.Forms.Padding(4);
            this.tools_treeView.Name = "tools_treeView";
            treeNode50.Name = "BASE64_Node";
            treeNode50.Tag = "base64";
            treeNode50.Text = "Base64";
            treeNode51.Name = "AES_Node";
            treeNode51.Tag = "AES";
            treeNode51.Text = "AES";
            treeNode52.Name = "tools_codec_node";
            treeNode52.Text = "编解码工具";
            treeNode53.Name = "tools_fridascript_node";
            treeNode53.Tag = "FRIDASCRIPT";
            treeNode53.Text = "Frida脚本界面工具";
            treeNode54.Name = "tools_fridascript_node_auto";
            treeNode54.Tag = "FRIDASCRIPT_AUTO";
            treeNode54.Text = "Frida脚本批量生成";
            treeNode55.Name = "tools_script_node";
            treeNode55.Text = "脚本工具";
            treeNode56.Name = "tools_root_node";
            treeNode56.Tag = "";
            treeNode56.Text = "工具集";
            this.tools_treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode56});
            this.tools_treeView.Size = new System.Drawing.Size(225, 514);
            this.tools_treeView.TabIndex = 0;
            this.tools_treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tools_treeView_NodeMouseDoubleClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(747, 489);
            this.splitContainer2.SplitterDistance = 295;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_txtBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.output_txtBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 489);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出";
            // 
            // output_txtBox
            // 
            this.output_txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_txtBox.IsReadOnly = false;
            this.output_txtBox.Location = new System.Drawing.Point(3, 24);
            this.output_txtBox.Name = "output_txtBox";
            this.output_txtBox.Size = new System.Drawing.Size(438, 462);
            this.output_txtBox.TabIndex = 1;
            this.output_txtBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // commonToolStrip
            // 
            this.commonToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.commonToolStrip.Location = new System.Drawing.Point(0, 0);
            this.commonToolStrip.Name = "commonToolStrip";
            this.commonToolStrip.Size = new System.Drawing.Size(747, 25);
            this.commonToolStrip.TabIndex = 0;
            this.commonToolStrip.Text = "toolStrip1";
            // 
            // input_txtBox
            // 
            this.input_txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input_txtBox.IsReadOnly = false;
            this.input_txtBox.Location = new System.Drawing.Point(3, 24);
            this.input_txtBox.Name = "input_txtBox";
            this.input_txtBox.ShowVRuler = false;
            this.input_txtBox.Size = new System.Drawing.Size(289, 462);
            this.input_txtBox.TabIndex = 2;
            this.input_txtBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.input_txtBox.VRulerRow = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 569);
            this.Controls.Add(this.splitContainer_Form);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "HOOK工具集";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer_Form.Panel1.ResumeLayout(false);
            this.splitContainer_Form.Panel2.ResumeLayout(false);
            this.splitContainer_Form.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Form)).EndInit();
            this.splitContainer_Form.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer_Form;
        private System.Windows.Forms.TreeView tools_treeView;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip commonToolStrip;
        private ICSharpCode.TextEditor.TextEditorControl output_txtBox;
        private ICSharpCode.TextEditor.TextEditorControl input_txtBox;
    }
}

