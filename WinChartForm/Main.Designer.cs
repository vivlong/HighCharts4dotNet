namespace WinChartForm
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.winChart1 = new winChart.WinFormChartControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winChart1
            // 
            this.winChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.winChart1.cCategory = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
            this.winChart1.cName = new string[] {
        "SysMagic"};
            this.winChart1.cValue = new int[] {
        10,
        30,
        10,
        0,
        -10,
        -30,
        -10,
        0,
        10,
        30,
        10,
        0};
            this.winChart1.Location = new System.Drawing.Point(0, 37);
            this.winChart1.Name = "winChart1";
            this.winChart1.Size = new System.Drawing.Size(577, 374);
            this.winChart1.TabIndex = 0;
            this.winChart1.type = "column";
            this.winChart1.xtitle = "SysFreightChart";
            this.winChart1.ytitle = "$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click here to show the column chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.winChart1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SysFreightChart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private winChart.WinFormChartControl winChart1;
        private System.Windows.Forms.Button button1;

    }
}

