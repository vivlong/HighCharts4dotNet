using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Reflection;

namespace winChart
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]

    public partial class WinFormChartControl : UserControl
    {
        private string _type = "column";
        private string _xtitle = "SysFreightChart";
        private string _ytitle = "$";
        private string[] _cName = {"SysMagic"};
        private string[] _cCategory = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
        private int[] _cValue = { 10, 30, 10, 0, -10, -30, -10, 0, 10, 30, 10, 0 };

        public string[] cCategory
        {
            get { return _cCategory; }
            set { _cCategory = value; }
        }

        public int[] cValue
        {
            get { return _cValue; }
            set { _cValue = value; }
        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string xtitle
        {
            get { return _xtitle; }
            set { _xtitle = value; }
        }

        public string ytitle
        {
            get { return _ytitle; }
            set { _ytitle = value; }
        }

        public string[] cName
        {
            get { return _cName; }
            set { _cName = value; }
        }

        public WinFormChartControl()
        {
            InitializeComponent();
        }

        public void LoadHtml()
        {
            webBrowser1.Url = new Uri(Application.StartupPath + @"\JsChart\index.htm");
        }

        public void LoadChart()
        {
            object[] gn = new object[cName.Length];
            for (int i = 0; i < cName.Length; i++)
            {
                gn[i] = cName[i];
            }
            object[] gc = new object[cCategory.Length];
            for (int i = 0; i < cCategory.Length; i++)
            {
                gc[i] = cCategory[i];
            }
            object[] gv = new object[cValue.Length];
            for (int i = 0; i < cValue.Length; i++)
            {
                gv[i] = cValue[i];
            }
            webBrowser1.Document.InvokeScript("GetSize", new object[] { this.Height,this.Width });
            webBrowser1.Document.InvokeScript("GetStyle", new object[] { type, xtitle, ytitle });
            webBrowser1.Document.InvokeScript("GetCategories", gc);
            webBrowser1.Document.InvokeScript("GetNames", gn);
            webBrowser1.Document.InvokeScript("GetValues", gv);
            webBrowser1.Document.InvokeScript("HCharts");
        }
    }
}
