namespace HTTPRequester
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.outerPanel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.newRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outerPanel
            // 
            this.outerPanel.Location = new System.Drawing.Point(1, 32);
            this.outerPanel.Name = "outerPanel";
            this.outerPanel.Size = new System.Drawing.Size(800, 455);
            this.outerPanel.TabIndex = 0;
            this.outerPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.outerPanel_MouseWheel);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(800, 32);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 455);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.vScrollBar1_MouseWheel);
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // newRequest
            // 
            this.newRequest.Location = new System.Drawing.Point(1, 3);
            this.newRequest.Name = "newRequest";
            this.newRequest.Size = new System.Drawing.Size(124, 23);
            this.newRequest.TabIndex = 2;
            this.newRequest.Text = "New Request";
            this.newRequest.UseVisualStyleBackColor = true;
            this.newRequest.Click += new System.EventHandler(this.newRequest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 489);
            this.Controls.Add(this.newRequest);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.outerPanel);
            this.Name = "MainForm";
            this.Text = "HTTPRequester";
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel outerPanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button newRequest;
    }
}

