using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HTTPRequester
{
    public partial class MainForm : Form
    {
        InfoPanel infoPanel;

        public MainForm()
        {
            InitializeComponent();
            infoPanel = new InfoPanel();
            infoPanel.Top = 0;
            infoPanel.Left = 0;
            this.outerPanel.Controls.Add(infoPanel);

        }

        public void AddInfo(Dictionary<string, object> dict)
        {
            infoPanel.AddInfoContainer(dict);
            infoPanel_SizeChanged();
        }

        private void infoPanel_SizeChanged()
        {
            int delta = infoPanel.Height - outerPanel.Height;
            infoPanel.Top = delta > 0 ? (-delta) : 0;
            vScrollBar1.Maximum = delta > 0 ? delta / 10 : 0;
            SetScrollValue(vScrollBar1.Maximum - 9);
        }

        void vScrollBar1_ValueChanged(object sender, System.EventArgs e)
        {
            double percentage = ((double)vScrollBar1.Value) / (vScrollBar1.Maximum-9);
            //MessageBox.Show(vScrollBar1.Value.ToString() + ", " + vScrollBar1.Maximum);
            int delta = infoPanel.Height - outerPanel.Height;
            infoPanel.Top = -((int)(percentage * delta));
        }

        void vScrollBar1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int value = vScrollBar1.Value;
            if (e.Delta < 0)
            {
                value+=5;
            }
            else
            {
                value-=5;
            }
            SetScrollValue(value);
        }

        private void SetScrollValue(int val)
        {
            int min = 0;
            int max = vScrollBar1.Maximum - 9;
            max = max < 0 ? 0 : max;
            int value = val;
            if (val < min) value = 0;
            if (val > max) value = max;
            vScrollBar1.Value = value;
        }

        void outerPanel_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            vScrollBar1_MouseWheel(sender, e);
        }

        private void newRequest_Click(object sender, EventArgs e)
        {
            NewRequest requestForm = new NewRequest();
            requestForm.SetParentForm(this);
            requestForm.ShowInTaskbar = false;
            requestForm.Visible = true;
        }

    }
}