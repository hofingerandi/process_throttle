using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slowdown
{
    public partial class LicenseInfo : Form
    {
        public LicenseInfo()
        {
            InitializeComponent();

            linkLabelAhaSoft.LinkArea = new LinkArea(27, 23);
            linkLabelAhaSoft.Text = "The icon is available from http://www.aha-soft.com under the CC BY 3.0-license";
        }

        private void linkLabelAhaSoft_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.aha-soft.com/");
        }
    }
}
