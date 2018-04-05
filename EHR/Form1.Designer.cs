﻿namespace EHR
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMedication = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonRunEngine = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericTemp = new System.Windows.Forms.NumericUpDown();
            this.labelLastChecked = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelLastCalculatedDate = new System.Windows.Forms.Label();
            this.labelFactor3 = new System.Windows.Forms.Label();
            this.labelFactor2 = new System.Windows.Forms.Label();
            this.labelFactor1 = new System.Windows.Forms.Label();
            this.labelRiskScore = new System.Windows.Forms.Label();
            this.buttonSaveVitals = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericPulse = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericO2Sat = new System.Windows.Forms.NumericUpDown();
            this.tabControlTopLevel = new System.Windows.Forms.TabControl();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.tabPageWorklist = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericO2Sat)).BeginInit();
            this.tabControlTopLevel.SuspendLayout();
            this.tabPageChart.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(298, 896);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPatientName.Location = new System.Drawing.Point(152, 55);
            this.labelPatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(481, 44);
            this.labelPatientName.TabIndex = 1;
            this.labelPatientName.Text = "Jones, James (07/01/1955)";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitContainer1.Panel1.Controls.Add(this.labelPatientName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1622, 1001);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1622, 896);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer3.Panel2MinSize = 150;
            this.splitContainer3.Size = new System.Drawing.Size(1517, 896);
            this.splitContainer3.SplitterDistance = 1214;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1214, 896);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.labelMedication);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1198, 849);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medications";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(948, 380);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "SMART on FHIR App ->";
            // 
            // labelMedication
            // 
            this.labelMedication.AutoSize = true;
            this.labelMedication.Location = new System.Drawing.Point(132, 78);
            this.labelMedication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMedication.Name = "labelMedication";
            this.labelMedication.Size = new System.Drawing.Size(163, 25);
            this.labelMedication.TabIndex = 0;
            this.labelMedication.Text = "labelMedication";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1198, 849);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Physical Exam";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelStatus);
            this.tabPage3.Controls.Add(this.buttonRunEngine);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.numericTemp);
            this.tabPage3.Controls.Add(this.labelLastChecked);
            this.tabPage3.Controls.Add(this.buttonRefresh);
            this.tabPage3.Controls.Add(this.labelLastCalculatedDate);
            this.tabPage3.Controls.Add(this.labelFactor3);
            this.tabPage3.Controls.Add(this.labelFactor2);
            this.tabPage3.Controls.Add(this.labelFactor1);
            this.tabPage3.Controls.Add(this.labelRiskScore);
            this.tabPage3.Controls.Add(this.buttonSaveVitals);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.numericPulse);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.numericO2Sat);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1198, 849);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vitals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(41, 424);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(73, 25);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "Status";
            // 
            // buttonRunEngine
            // 
            this.buttonRunEngine.Location = new System.Drawing.Point(891, 602);
            this.buttonRunEngine.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRunEngine.Name = "buttonRunEngine";
            this.buttonRunEngine.Size = new System.Drawing.Size(141, 54);
            this.buttonRunEngine.TabIndex = 14;
            this.buttonRunEngine.Text = "Run Engine";
            this.buttonRunEngine.UseVisualStyleBackColor = true;
            this.buttonRunEngine.Click += new System.EventHandler(this.buttonRunEngine_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Temp";
            // 
            // numericTemp
            // 
            this.numericTemp.DecimalPlaces = 1;
            this.numericTemp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericTemp.Location = new System.Drawing.Point(373, 229);
            this.numericTemp.Margin = new System.Windows.Forms.Padding(4);
            this.numericTemp.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.numericTemp.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericTemp.Name = "numericTemp";
            this.numericTemp.Size = new System.Drawing.Size(112, 31);
            this.numericTemp.TabIndex = 12;
            this.numericTemp.Value = new decimal(new int[] {
            986,
            0,
            0,
            65536});
            // 
            // labelLastChecked
            // 
            this.labelLastChecked.AutoSize = true;
            this.labelLastChecked.Location = new System.Drawing.Point(751, 720);
            this.labelLastChecked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastChecked.Name = "labelLastChecked";
            this.labelLastChecked.Size = new System.Drawing.Size(184, 25);
            this.labelLastChecked.TabIndex = 11;
            this.labelLastChecked.Text = "labelLastChecked";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(739, 321);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(119, 49);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelLastCalculatedDate
            // 
            this.labelLastCalculatedDate.AutoSize = true;
            this.labelLastCalculatedDate.Location = new System.Drawing.Point(745, 412);
            this.labelLastCalculatedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastCalculatedDate.Name = "labelLastCalculatedDate";
            this.labelLastCalculatedDate.Size = new System.Drawing.Size(246, 25);
            this.labelLastCalculatedDate.TabIndex = 9;
            this.labelLastCalculatedDate.Text = "labelLastCalculatedDate";
            // 
            // labelFactor3
            // 
            this.labelFactor3.AutoSize = true;
            this.labelFactor3.Location = new System.Drawing.Point(745, 258);
            this.labelFactor3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFactor3.Name = "labelFactor3";
            this.labelFactor3.Size = new System.Drawing.Size(131, 25);
            this.labelFactor3.TabIndex = 8;
            this.labelFactor3.Text = "labelFactor3";
            // 
            // labelFactor2
            // 
            this.labelFactor2.AutoSize = true;
            this.labelFactor2.Location = new System.Drawing.Point(745, 209);
            this.labelFactor2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFactor2.Name = "labelFactor2";
            this.labelFactor2.Size = new System.Drawing.Size(131, 25);
            this.labelFactor2.TabIndex = 7;
            this.labelFactor2.Text = "labelFactor2";
            // 
            // labelFactor1
            // 
            this.labelFactor1.AutoSize = true;
            this.labelFactor1.Location = new System.Drawing.Point(745, 159);
            this.labelFactor1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFactor1.Name = "labelFactor1";
            this.labelFactor1.Size = new System.Drawing.Size(131, 25);
            this.labelFactor1.TabIndex = 6;
            this.labelFactor1.Text = "labelFactor1";
            // 
            // labelRiskScore
            // 
            this.labelRiskScore.AutoSize = true;
            this.labelRiskScore.Location = new System.Drawing.Point(745, 81);
            this.labelRiskScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRiskScore.Name = "labelRiskScore";
            this.labelRiskScore.Size = new System.Drawing.Size(156, 25);
            this.labelRiskScore.TabIndex = 5;
            this.labelRiskScore.Text = "labelRiskScore";
            // 
            // buttonSaveVitals
            // 
            this.buttonSaveVitals.Location = new System.Drawing.Point(339, 310);
            this.buttonSaveVitals.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveVitals.Name = "buttonSaveVitals";
            this.buttonSaveVitals.Size = new System.Drawing.Size(147, 38);
            this.buttonSaveVitals.TabIndex = 4;
            this.buttonSaveVitals.Text = "Save";
            this.buttonSaveVitals.UseVisualStyleBackColor = true;
            this.buttonSaveVitals.Click += new System.EventHandler(this.buttonSaveVitals_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pulse";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericPulse
            // 
            this.numericPulse.Location = new System.Drawing.Point(373, 159);
            this.numericPulse.Margin = new System.Windows.Forms.Padding(4);
            this.numericPulse.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericPulse.Name = "numericPulse";
            this.numericPulse.Size = new System.Drawing.Size(112, 31);
            this.numericPulse.TabIndex = 2;
            this.numericPulse.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "O2 Sat";
            // 
            // numericO2Sat
            // 
            this.numericO2Sat.Location = new System.Drawing.Point(373, 82);
            this.numericO2Sat.Margin = new System.Windows.Forms.Padding(4);
            this.numericO2Sat.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericO2Sat.Name = "numericO2Sat";
            this.numericO2Sat.Size = new System.Drawing.Size(112, 31);
            this.numericO2Sat.TabIndex = 0;
            this.numericO2Sat.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tabControlTopLevel
            // 
            this.tabControlTopLevel.Controls.Add(this.tabPageChart);
            this.tabControlTopLevel.Controls.Add(this.tabPageWorklist);
            this.tabControlTopLevel.Location = new System.Drawing.Point(0, 43);
            this.tabControlTopLevel.Name = "tabControlTopLevel";
            this.tabControlTopLevel.SelectedIndex = 0;
            this.tabControlTopLevel.Size = new System.Drawing.Size(1644, 1054);
            this.tabControlTopLevel.TabIndex = 4;
            // 
            // tabPageChart
            // 
            this.tabPageChart.BackColor = System.Drawing.Color.MistyRose;
            this.tabPageChart.Controls.Add(this.splitContainer1);
            this.tabPageChart.Location = new System.Drawing.Point(8, 39);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChart.Size = new System.Drawing.Size(1628, 1007);
            this.tabPageChart.TabIndex = 0;
            this.tabPageChart.Text = "Chart";
            // 
            // tabPageWorklist
            // 
            this.tabPageWorklist.Location = new System.Drawing.Point(8, 39);
            this.tabPageWorklist.Name = "tabPageWorklist";
            this.tabPageWorklist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorklist.Size = new System.Drawing.Size(1628, 1007);
            this.tabPageWorklist.TabIndex = 1;
            this.tabPageWorklist.Text = "Mosaic";
            this.tabPageWorklist.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.activityListToolStripMenuItem,
            this.findPatientToolStripMenuItem,
            this.inboxToolStripMenuItem,
            this.bookmarkToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1632, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // activityListToolStripMenuItem
            // 
            this.activityListToolStripMenuItem.Name = "activityListToolStripMenuItem";
            this.activityListToolStripMenuItem.Size = new System.Drawing.Size(147, 36);
            this.activityListToolStripMenuItem.Text = "Activity List";
            // 
            // findPatientToolStripMenuItem
            // 
            this.findPatientToolStripMenuItem.Name = "findPatientToolStripMenuItem";
            this.findPatientToolStripMenuItem.Size = new System.Drawing.Size(153, 36);
            this.findPatientToolStripMenuItem.Text = "Find Patient";
            // 
            // inboxToolStripMenuItem
            // 
            this.inboxToolStripMenuItem.Name = "inboxToolStripMenuItem";
            this.inboxToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.inboxToolStripMenuItem.Text = "Inbox";
            // 
            // bookmarkToolStripMenuItem
            // 
            this.bookmarkToolStripMenuItem.Name = "bookmarkToolStripMenuItem";
            this.bookmarkToolStripMenuItem.Size = new System.Drawing.Size(134, 36);
            this.bookmarkToolStripMenuItem.Text = "Bookmark";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(151, 36);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 1112);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControlTopLevel);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Myopic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericO2Sat)).EndInit();
            this.tabControlTopLevel.ResumeLayout(false);
            this.tabPageChart.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelMedication;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericO2Sat;
        private System.Windows.Forms.NumericUpDown numericPulse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveVitals;
        private System.Windows.Forms.Label labelFactor1;
        private System.Windows.Forms.Label labelRiskScore;
        private System.Windows.Forms.Label labelFactor3;
        private System.Windows.Forms.Label labelFactor2;
        private System.Windows.Forms.Label labelLastCalculatedDate;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelLastChecked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericTemp;
        private System.Windows.Forms.Button buttonRunEngine;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControlTopLevel;
        private System.Windows.Forms.TabPage tabPageChart;
        private System.Windows.Forms.TabPage tabPageWorklist;
    }
}

