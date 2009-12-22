namespace HTTPRequester
{
    partial class InfoContainer
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textURL = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textRequestHeader = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textRequestContent = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textResponseHeader = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textResponseContent = new System.Windows.Forms.TextBox();
            this.btDump = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResponseContentSize = new System.Windows.Forms.Label();
            this.labelRequestContentType = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(3, 3);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(794, 20);
            this.textURL.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(378, 149);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textRequestHeader);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 123);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Header";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textRequestHeader
            // 
            this.textRequestHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textRequestHeader.Location = new System.Drawing.Point(3, 3);
            this.textRequestHeader.Multiline = true;
            this.textRequestHeader.Name = "textRequestHeader";
            this.textRequestHeader.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textRequestHeader.Size = new System.Drawing.Size(364, 117);
            this.textRequestHeader.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textRequestContent);
            this.tabPage2.Controls.Add(this.labelRequestContentType);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 123);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Content";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textRequestContent
            // 
            this.textRequestContent.Location = new System.Drawing.Point(3, 24);
            this.textRequestContent.Multiline = true;
            this.textRequestContent.Name = "textRequestContent";
            this.textRequestContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textRequestContent.Size = new System.Drawing.Size(364, 96);
            this.textRequestContent.TabIndex = 7;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(6, 13);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(386, 149);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textResponseHeader);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(378, 123);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Header";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textResponseHeader
            // 
            this.textResponseHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textResponseHeader.Location = new System.Drawing.Point(3, 3);
            this.textResponseHeader.Multiline = true;
            this.textResponseHeader.Name = "textResponseHeader";
            this.textResponseHeader.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textResponseHeader.Size = new System.Drawing.Size(372, 117);
            this.textResponseHeader.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelResponseContentSize);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.textResponseContent);
            this.tabPage4.Controls.Add(this.btDump);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(378, 123);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Content";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textResponseContent
            // 
            this.textResponseContent.Location = new System.Drawing.Point(3, 24);
            this.textResponseContent.Multiline = true;
            this.textResponseContent.Name = "textResponseContent";
            this.textResponseContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textResponseContent.Size = new System.Drawing.Size(372, 96);
            this.textResponseContent.TabIndex = 9;
            // 
            // btDump
            // 
            this.btDump.Location = new System.Drawing.Point(318, 1);
            this.btDump.Name = "btDump";
            this.btDump.Size = new System.Drawing.Size(57, 23);
            this.btDump.TabIndex = 8;
            this.btDump.Text = "Dump";
            this.btDump.UseVisualStyleBackColor = true;
            this.btDump.Click += new System.EventHandler(this.btDump_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 168);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Location = new System.Drawing.Point(399, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 168);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Response";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bytes: ";
            // 
            // labelResponseContentSize
            // 
            this.labelResponseContentSize.AutoSize = true;
            this.labelResponseContentSize.Location = new System.Drawing.Point(51, 6);
            this.labelResponseContentSize.Name = "labelResponseContentSize";
            this.labelResponseContentSize.Size = new System.Drawing.Size(51, 13);
            this.labelResponseContentSize.TabIndex = 10;
            this.labelResponseContentSize.Text = "unknown";
            // 
            // labelRequestContentType
            // 
            this.labelRequestContentType.AutoSize = true;
            this.labelRequestContentType.Location = new System.Drawing.Point(6, 6);
            this.labelRequestContentType.Name = "labelRequestContentType";
            this.labelRequestContentType.Size = new System.Drawing.Size(100, 13);
            this.labelRequestContentType.TabIndex = 10;
            this.labelRequestContentType.Text = "Empty Post Content";
            // 
            // InfoContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textURL);
            this.Name = "InfoContainer";
            this.Size = new System.Drawing.Size(800, 200);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textRequestHeader;
        private System.Windows.Forms.TextBox textResponseHeader;
        private System.Windows.Forms.Button btDump;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textRequestContent;
        private System.Windows.Forms.TextBox textResponseContent;
        private System.Windows.Forms.Label labelResponseContentSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRequestContentType;
    }
}
