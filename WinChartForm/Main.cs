using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;

namespace WinChartForm
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.winChart1.LoadHtml();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.winChart1.LoadChart();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.winChart1.LoadChart();
        }
    }
}
