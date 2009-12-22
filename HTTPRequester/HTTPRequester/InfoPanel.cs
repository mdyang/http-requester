using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace HTTPRequester
{
    public partial class InfoPanel : UserControl
    {

        private List<InfoContainer> containers;

        public InfoPanel()
        {
            InitializeComponent();
            this.containers = new List<InfoContainer>();
            
        }

        public void AddInfoContainer(Dictionary<string, object> dict){
            InfoContainer container = new InfoContainer();
            container.SetInfo(dict);
            int curpos = containers.Count;
            containers.Add(container);
            container.Left = 0;
            container.Top = InfoContainer.ContainerHeight * curpos;
            this.Height = InfoContainer.ContainerHeight * (curpos + 1);
            this.Controls.Add(container);
        }

    }
}
