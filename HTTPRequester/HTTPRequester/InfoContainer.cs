using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace HTTPRequester
{
    public partial class InfoContainer : UserControl
    {
        private Dictionary<string, object> dict;
        private HttpWebRequest request;
        private HttpWebResponse response;
        private byte[] responseContent;
        private Dictionary<string, object> requestContent;

        public InfoContainer()
        {
            InitializeComponent();
            this.BackColor = Utility.GetRandomColor(200, 56);
        }

        public void SetInfo(Dictionary<string, object> dict)
        {
            this.dict = dict;
            InitializeInfo();
            DisplayInfo();
        }

        private void InitializeInfo()
        {
            this.request = (HttpWebRequest)dict["request"];
            this.response = (HttpWebResponse)dict["response"];

            // request content
            if ((bool)((Dictionary<string, object>)dict["data"])["empty"])
            {
                requestContent = null;
            }
            else
            {
                requestContent = (Dictionary<string, object>)((Dictionary<string, object>)dict["data"])["data"];
            }

            // Initialize response content, stored in responseContent
            responseContent = Utility.GetBytesFromStream(response.GetResponseStream());
        }

        private void DisplayInfo()
        {
            // append url
            textURL.Text = (string)dict["url"];

            // append request headers
            WebHeaderCollection requestHeaders = request.Headers;
            string[] requestHeaderKeys = requestHeaders.AllKeys;
            for (int i = 0; i < requestHeaderKeys.Length; i++)
            {
                string key = requestHeaderKeys[i];
                textRequestHeader.AppendText(key);
                textRequestHeader.AppendText(": ");
                textRequestHeader.AppendText(requestHeaders[key]);
                textRequestHeader.AppendText("\r\n");
            }

            // append request content
            if (requestContent != null)
            {
                labelRequestContentType.Text = (string)requestContent["contentType"];
                textRequestContent.Text = Encoding.Default.GetString((byte[])requestContent["content"]);
            }

            // append response headers
            WebHeaderCollection responseHeaders = response.Headers;
            string[] responseHeaderKeys = responseHeaders.AllKeys;
            for (int i = 0; i < responseHeaderKeys.Length; i++)
            {
                string key = responseHeaderKeys[i];
                textResponseHeader.AppendText(key);
                textResponseHeader.AppendText(": ");
                textResponseHeader.AppendText(responseHeaders[key]);
                textResponseHeader.AppendText("\r\n");
            }

            // append response content
            labelResponseContentSize.Text = responseContent.Length.ToString();
            textResponseContent.Text = Encoding.Default.GetString(responseContent);

        }

        public static int ContainerHeight
        {
            get
            {
                return 200;
            }
        }

        private void btDump_Click(object sender, EventArgs e)
        {
            FileDialog fileDlg = new SaveFileDialog();
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                Utility.WriteFileBytes(fileDlg.FileName, responseContent);
            }
        }

    }
}
