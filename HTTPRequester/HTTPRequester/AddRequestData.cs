using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HTTPRequester
{
    public partial class AddRequestData : Form
    {
        private NewRequest parentForm;

        public AddRequestData()
        {
            InitializeComponent();
        }

        public void SetParentForm(NewRequest parentForm)
        {
            this.parentForm = parentForm;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            parentForm.AddFormData(textKey.Text, textValue.Text);
            Dispose();
        }
    }
}