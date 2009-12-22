using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;

namespace HTTPRequester
{
    public partial class NewRequest : Form
    {

        private MainForm mainForm;
        private Dictionary<string, string> formData;
        private Panel[] dataPanels;

        public NewRequest()
        {
            InitializeComponent();
            formData = new Dictionary<string, string>();
            dataPanels = new Panel[2]{panelFormData, panelXMLData};
        }

        public void SetParentForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private void btRequest_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();

            // formalize http request headers
            string url = textURL.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = textMethod.Text;
            request.UserAgent = textUserAgent.Text;
            if (checkReferer.Checked)
            {
                request.Referer = textReferer.Text;
            }
            if (checkCookie.Checked)
            {
                request.Headers.Add("Cookie: " + textCookie.Text);
            }
            if (checkAccept.Checked)
            {
                request.Accept = textAccept.Text;
            }
            if (checkConnection.Checked)
            {
                request.Connection = textConnection.Text;
            }
            request.KeepAlive = checkKeepAlive.Checked;
            if (checkAcceptCharset.Checked)
            {
                request.Headers.Add("Accept-Charset: " + textAcceptCharset.Text);
            }
            if (checkAcceptEncoding.Checked)
            {
                request.Headers.Add("Accept-Encoding: " + textAcceptEncoding.Text);
            }
            if (checkAcceptLanguage.Checked)
            {
                request.Headers.Add("Accept-Language: " + textAcceptLanguage.Text);
            }

            // process data
            Dictionary<string, object> dataWrapper = new Dictionary<string, object>();
            if (checkEnableData.Checked)
            {
                Dictionary<string, object> data = ProcessData();

                request.ContentType = (string)data["contentType"];
                byte[] content = (byte[])data["content"];
                int length = content.Length;
                request.ContentLength = length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(content, 0, length);
                requestStream.Close();

                dataWrapper.Add("empty", false);
                dataWrapper.Add("data", data);
            }
            else
            {
                dataWrapper.Add("empty", true);
            }
            dict.Add("data", dataWrapper);

            // perform http web request
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // parameter passing
            dict.Add("url", url);
            dict.Add("request", request);
            dict.Add("response", response);

            // do display stuff
            mainForm.AddInfo(dict);

            // dispose the dialog
            Dispose();
        }

        public Dictionary<string, object> ProcessData()
        {
            string contentType = textContentType.Text;
            string content = "";

            switch (contentType)
            {
                case "application/x-www-form-urlencoded":
                    {
                        foreach (KeyValuePair<string, string> pair in formData)
                        {
                            string param = 
                                pair.Key + "=" + HttpUtility.UrlEncode(pair.Value, Encoding.Default) + "&";
                            content += param;
                        }

                    }
                    break;
                default:
                    {
                        content = textXMLData.Text;
                    }
                    break;
            }

            Dictionary<string, object> retValue = new Dictionary<string, object>();

            retValue.Add("contentType", contentType);
            retValue.Add("content", Encoding.Default.GetBytes(content));

            return retValue;

        }

        public void AddFormData(string key, string value)
        {
            formData.Add(key, value);
            listRequestData.Items.Add(key + ": " + value);
        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            AddRequestData dlg = new AddRequestData();
            dlg.SetParentForm(this);
            dlg.ShowInTaskbar = false;
            dlg.ShowDialog();
        }

        private void buttonDeleteData_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selected = listRequestData.SelectedItems;

            // remove data in the dictionary
            foreach (object obj in selected)
            {
                string val = obj.ToString();
                int index = val.IndexOf(": ");
                string key = val.Substring(0, index);
                formData.Remove(key);
            }

            // remove listbox items
            int len = selected.Count;
            for (int i = 0; i < len; i++)
            {
                listRequestData.Items.Remove(selected[0]);
            }
        }

        void textContentType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int index = textContentType.SelectedIndex;
            foreach (Panel panel in dataPanels)
            {
                panel.Visible = false;
            }
            dataPanels[index].Visible = true;
        }

        void buttonXmlFromFile_Click(object sender, System.EventArgs e)
        {
            
        }

    }
}