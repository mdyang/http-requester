namespace HTTPRequester
{
    partial class NewRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRequest));
            this.btRequest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkAccept = new System.Windows.Forms.CheckBox();
            this.checkCookie = new System.Windows.Forms.CheckBox();
            this.checkReferer = new System.Windows.Forms.CheckBox();
            this.textCookie = new System.Windows.Forms.TextBox();
            this.textAccept = new System.Windows.Forms.TextBox();
            this.textReferer = new System.Windows.Forms.TextBox();
            this.textURL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMethod = new System.Windows.Forms.ComboBox();
            this.textUserAgent = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkEnableData = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textContentType = new System.Windows.Forms.ComboBox();
            this.panelFormData = new System.Windows.Forms.Panel();
            this.buttonDeleteData = new System.Windows.Forms.Button();
            this.buttonAddData = new System.Windows.Forms.Button();
            this.listRequestData = new System.Windows.Forms.ListBox();
            this.panelXMLData = new System.Windows.Forms.Panel();
            this.textXMLData = new System.Windows.Forms.TextBox();
            this.buttonXmlFromFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkAcceptLanguage = new System.Windows.Forms.CheckBox();
            this.checkAcceptEncoding = new System.Windows.Forms.CheckBox();
            this.checkAcceptCharset = new System.Windows.Forms.CheckBox();
            this.checkKeepAlive = new System.Windows.Forms.CheckBox();
            this.checkConnection = new System.Windows.Forms.CheckBox();
            this.textAcceptLanguage = new System.Windows.Forms.TextBox();
            this.textAcceptEncoding = new System.Windows.Forms.TextBox();
            this.textConnection = new System.Windows.Forms.TextBox();
            this.textAcceptCharset = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelFormData.SuspendLayout();
            this.panelXMLData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRequest
            // 
            this.btRequest.Location = new System.Drawing.Point(699, 331);
            this.btRequest.Name = "btRequest";
            this.btRequest.Size = new System.Drawing.Size(120, 23);
            this.btRequest.TabIndex = 0;
            this.btRequest.Text = "Perform Requet";
            this.btRequest.UseVisualStyleBackColor = true;
            this.btRequest.Click += new System.EventHandler(this.btRequest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 329);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.checkAccept);
            this.tabPage1.Controls.Add(this.checkCookie);
            this.tabPage1.Controls.Add(this.checkReferer);
            this.tabPage1.Controls.Add(this.textCookie);
            this.tabPage1.Controls.Add(this.textAccept);
            this.tabPage1.Controls.Add(this.textReferer);
            this.tabPage1.Controls.Add(this.textURL);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textMethod);
            this.tabPage1.Controls.Add(this.textUserAgent);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Header";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkAccept
            // 
            this.checkAccept.AutoSize = true;
            this.checkAccept.Location = new System.Drawing.Point(6, 156);
            this.checkAccept.Name = "checkAccept";
            this.checkAccept.Size = new System.Drawing.Size(60, 17);
            this.checkAccept.TabIndex = 9;
            this.checkAccept.Text = "Accept";
            this.checkAccept.UseVisualStyleBackColor = true;
            // 
            // checkCookie
            // 
            this.checkCookie.AutoSize = true;
            this.checkCookie.Location = new System.Drawing.Point(6, 72);
            this.checkCookie.Name = "checkCookie";
            this.checkCookie.Size = new System.Drawing.Size(59, 17);
            this.checkCookie.TabIndex = 9;
            this.checkCookie.Text = "Cookie";
            this.checkCookie.UseVisualStyleBackColor = true;
            // 
            // checkReferer
            // 
            this.checkReferer.AutoSize = true;
            this.checkReferer.Location = new System.Drawing.Point(6, 50);
            this.checkReferer.Name = "checkReferer";
            this.checkReferer.Size = new System.Drawing.Size(61, 17);
            this.checkReferer.TabIndex = 9;
            this.checkReferer.Text = "Referer";
            this.checkReferer.UseVisualStyleBackColor = true;
            // 
            // textCookie
            // 
            this.textCookie.Location = new System.Drawing.Point(69, 70);
            this.textCookie.Multiline = true;
            this.textCookie.Name = "textCookie";
            this.textCookie.Size = new System.Drawing.Size(737, 82);
            this.textCookie.TabIndex = 8;
            // 
            // textAccept
            // 
            this.textAccept.Location = new System.Drawing.Point(69, 154);
            this.textAccept.Name = "textAccept";
            this.textAccept.Size = new System.Drawing.Size(737, 20);
            this.textAccept.TabIndex = 8;
            this.textAccept.Text = "*/*";
            // 
            // textReferer
            // 
            this.textReferer.Location = new System.Drawing.Point(69, 48);
            this.textReferer.Name = "textReferer";
            this.textReferer.Size = new System.Drawing.Size(737, 20);
            this.textReferer.TabIndex = 8;
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(69, 3);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(619, 20);
            this.textURL.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User-Agent";
            // 
            // textMethod
            // 
            this.textMethod.FormattingEnabled = true;
            this.textMethod.Items.AddRange(new object[] {
            "get",
            "post"});
            this.textMethod.Location = new System.Drawing.Point(743, 2);
            this.textMethod.Name = "textMethod";
            this.textMethod.Size = new System.Drawing.Size(63, 21);
            this.textMethod.TabIndex = 3;
            this.textMethod.Text = "get";
            // 
            // textUserAgent
            // 
            this.textUserAgent.FormattingEnabled = true;
            this.textUserAgent.Items.AddRange(new object[] {
            "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.1.5) Gecko/20091102 Firefo" +
                "x/3.5.5",
            resources.GetString("textUserAgent.Items")});
            this.textUserAgent.Location = new System.Drawing.Point(69, 25);
            this.textUserAgent.Name = "textUserAgent";
            this.textUserAgent.Size = new System.Drawing.Size(737, 21);
            this.textUserAgent.TabIndex = 3;
            this.textUserAgent.Text = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.1.5) Gecko/20091102 Firefo" +
                "x/3.5.5";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkEnableData);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textContentType);
            this.tabPage2.Controls.Add(this.panelFormData);
            this.tabPage2.Controls.Add(this.panelXMLData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkEnableData
            // 
            this.checkEnableData.AutoSize = true;
            this.checkEnableData.Location = new System.Drawing.Point(6, 6);
            this.checkEnableData.Name = "checkEnableData";
            this.checkEnableData.Size = new System.Drawing.Size(59, 17);
            this.checkEnableData.TabIndex = 9;
            this.checkEnableData.Text = "Enable";
            this.checkEnableData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Content-Type";
            // 
            // textContentType
            // 
            this.textContentType.FormattingEnabled = true;
            this.textContentType.Items.AddRange(new object[] {
            "application/x-www-form-urlencoded",
            "text/xml"});
            this.textContentType.Location = new System.Drawing.Point(441, 4);
            this.textContentType.Name = "textContentType";
            this.textContentType.Size = new System.Drawing.Size(365, 21);
            this.textContentType.TabIndex = 1;
            this.textContentType.Text = "application/x-www-form-urlencoded";
            this.textContentType.SelectedIndexChanged += new System.EventHandler(this.textContentType_SelectedIndexChanged);
            // 
            // panelFormData
            // 
            this.panelFormData.Controls.Add(this.buttonDeleteData);
            this.panelFormData.Controls.Add(this.buttonAddData);
            this.panelFormData.Controls.Add(this.listRequestData);
            this.panelFormData.Location = new System.Drawing.Point(3, 28);
            this.panelFormData.Name = "panelFormData";
            this.panelFormData.Size = new System.Drawing.Size(803, 272);
            this.panelFormData.TabIndex = 0;
            // 
            // buttonDeleteData
            // 
            this.buttonDeleteData.Location = new System.Drawing.Point(776, 34);
            this.buttonDeleteData.Name = "buttonDeleteData";
            this.buttonDeleteData.Size = new System.Drawing.Size(24, 23);
            this.buttonDeleteData.TabIndex = 6;
            this.buttonDeleteData.Text = "-";
            this.buttonDeleteData.UseVisualStyleBackColor = true;
            this.buttonDeleteData.Click += new System.EventHandler(this.buttonDeleteData_Click);
            // 
            // buttonAddData
            // 
            this.buttonAddData.Location = new System.Drawing.Point(776, 5);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(24, 23);
            this.buttonAddData.TabIndex = 7;
            this.buttonAddData.Text = "+";
            this.buttonAddData.UseVisualStyleBackColor = true;
            this.buttonAddData.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // listRequestData
            // 
            this.listRequestData.FormattingEnabled = true;
            this.listRequestData.Location = new System.Drawing.Point(3, 3);
            this.listRequestData.Name = "listRequestData";
            this.listRequestData.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRequestData.Size = new System.Drawing.Size(770, 264);
            this.listRequestData.TabIndex = 5;
            // 
            // panelXMLData
            // 
            this.panelXMLData.Controls.Add(this.textXMLData);
            this.panelXMLData.Controls.Add(this.buttonXmlFromFile);
            this.panelXMLData.Location = new System.Drawing.Point(3, 28);
            this.panelXMLData.Name = "panelXMLData";
            this.panelXMLData.Size = new System.Drawing.Size(803, 272);
            this.panelXMLData.TabIndex = 0;
            this.panelXMLData.Visible = false;
            // 
            // textXMLData
            // 
            this.textXMLData.Location = new System.Drawing.Point(3, 28);
            this.textXMLData.Multiline = true;
            this.textXMLData.Name = "textXMLData";
            this.textXMLData.Size = new System.Drawing.Size(797, 241);
            this.textXMLData.TabIndex = 8;
            // 
            // buttonXmlFromFile
            // 
            this.buttonXmlFromFile.Location = new System.Drawing.Point(3, 3);
            this.buttonXmlFromFile.Name = "buttonXmlFromFile";
            this.buttonXmlFromFile.Size = new System.Drawing.Size(102, 23);
            this.buttonXmlFromFile.TabIndex = 7;
            this.buttonXmlFromFile.Text = "From File...";
            this.buttonXmlFromFile.UseVisualStyleBackColor = true;
            this.buttonXmlFromFile.Click += new System.EventHandler(this.buttonXmlFromFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkAcceptLanguage);
            this.groupBox1.Controls.Add(this.checkAcceptEncoding);
            this.groupBox1.Controls.Add(this.checkAcceptCharset);
            this.groupBox1.Controls.Add(this.checkKeepAlive);
            this.groupBox1.Controls.Add(this.checkConnection);
            this.groupBox1.Controls.Add(this.textAcceptLanguage);
            this.groupBox1.Controls.Add(this.textAcceptEncoding);
            this.groupBox1.Controls.Add(this.textConnection);
            this.groupBox1.Controls.Add(this.textAcceptCharset);
            this.groupBox1.Location = new System.Drawing.Point(0, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 106);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The Commonly Need-NOT-to-Set";
            // 
            // checkAcceptLanguage
            // 
            this.checkAcceptLanguage.AutoSize = true;
            this.checkAcceptLanguage.Location = new System.Drawing.Point(5, 83);
            this.checkAcceptLanguage.Name = "checkAcceptLanguage";
            this.checkAcceptLanguage.Size = new System.Drawing.Size(111, 17);
            this.checkAcceptLanguage.TabIndex = 14;
            this.checkAcceptLanguage.Text = "Accept-Language";
            this.checkAcceptLanguage.UseVisualStyleBackColor = true;
            // 
            // checkAcceptEncoding
            // 
            this.checkAcceptEncoding.AutoSize = true;
            this.checkAcceptEncoding.Location = new System.Drawing.Point(5, 61);
            this.checkAcceptEncoding.Name = "checkAcceptEncoding";
            this.checkAcceptEncoding.Size = new System.Drawing.Size(108, 17);
            this.checkAcceptEncoding.TabIndex = 16;
            this.checkAcceptEncoding.Text = "Accept-Encoding";
            this.checkAcceptEncoding.UseVisualStyleBackColor = true;
            // 
            // checkAcceptCharset
            // 
            this.checkAcceptCharset.AutoSize = true;
            this.checkAcceptCharset.Location = new System.Drawing.Point(5, 39);
            this.checkAcceptCharset.Name = "checkAcceptCharset";
            this.checkAcceptCharset.Size = new System.Drawing.Size(99, 17);
            this.checkAcceptCharset.TabIndex = 15;
            this.checkAcceptCharset.Text = "Accept-Charset";
            this.checkAcceptCharset.UseVisualStyleBackColor = true;
            // 
            // checkKeepAlive
            // 
            this.checkKeepAlive.AutoSize = true;
            this.checkKeepAlive.Checked = true;
            this.checkKeepAlive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkKeepAlive.Location = new System.Drawing.Point(723, 17);
            this.checkKeepAlive.Name = "checkKeepAlive";
            this.checkKeepAlive.Size = new System.Drawing.Size(77, 17);
            this.checkKeepAlive.TabIndex = 18;
            this.checkKeepAlive.Text = "Keep-Alive";
            this.checkKeepAlive.UseVisualStyleBackColor = true;
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.Location = new System.Drawing.Point(5, 17);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(80, 17);
            this.checkConnection.TabIndex = 17;
            this.checkConnection.Text = "Connection";
            this.checkConnection.UseVisualStyleBackColor = true;
            // 
            // textAcceptLanguage
            // 
            this.textAcceptLanguage.Location = new System.Drawing.Point(119, 81);
            this.textAcceptLanguage.Name = "textAcceptLanguage";
            this.textAcceptLanguage.Size = new System.Drawing.Size(684, 20);
            this.textAcceptLanguage.TabIndex = 11;
            // 
            // textAcceptEncoding
            // 
            this.textAcceptEncoding.Location = new System.Drawing.Point(119, 59);
            this.textAcceptEncoding.Name = "textAcceptEncoding";
            this.textAcceptEncoding.Size = new System.Drawing.Size(684, 20);
            this.textAcceptEncoding.TabIndex = 10;
            // 
            // textConnection
            // 
            this.textConnection.Location = new System.Drawing.Point(119, 15);
            this.textConnection.Name = "textConnection";
            this.textConnection.Size = new System.Drawing.Size(598, 20);
            this.textConnection.TabIndex = 12;
            // 
            // textAcceptCharset
            // 
            this.textAcceptCharset.Location = new System.Drawing.Point(119, 37);
            this.textAcceptCharset.Name = "textAcceptCharset";
            this.textAcceptCharset.Size = new System.Drawing.Size(684, 20);
            this.textAcceptCharset.TabIndex = 13;
            // 
            // NewRequest
            // 
            this.ClientSize = new System.Drawing.Size(821, 355);
            this.Controls.Add(this.btRequest);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewRequest";
            this.Text = "New HTTP Request";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelFormData.ResumeLayout(false);
            this.panelXMLData.ResumeLayout(false);
            this.panelXMLData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btRequest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox textUserAgent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox textMethod;
        private System.Windows.Forms.CheckBox checkReferer;
        private System.Windows.Forms.TextBox textReferer;
        private System.Windows.Forms.CheckBox checkCookie;
        private System.Windows.Forms.TextBox textCookie;
        private System.Windows.Forms.CheckBox checkAccept;
        private System.Windows.Forms.TextBox textAccept;
        private System.Windows.Forms.Panel panelFormData;
        private System.Windows.Forms.Button buttonDeleteData;
        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.ListBox listRequestData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox textContentType;
        private System.Windows.Forms.Panel panelXMLData;
        private System.Windows.Forms.TextBox textXMLData;
        private System.Windows.Forms.Button buttonXmlFromFile;
        private System.Windows.Forms.CheckBox checkEnableData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkAcceptLanguage;
        private System.Windows.Forms.CheckBox checkAcceptEncoding;
        private System.Windows.Forms.CheckBox checkAcceptCharset;
        private System.Windows.Forms.CheckBox checkKeepAlive;
        private System.Windows.Forms.CheckBox checkConnection;
        private System.Windows.Forms.TextBox textAcceptLanguage;
        private System.Windows.Forms.TextBox textAcceptEncoding;
        private System.Windows.Forms.TextBox textConnection;
        private System.Windows.Forms.TextBox textAcceptCharset;
    }
}