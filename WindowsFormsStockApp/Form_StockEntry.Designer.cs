namespace WindowsFormsStockApp
{
    partial class Form_StockEntry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_StockEntry));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBox_Stock = new System.Windows.Forms.ComboBox();
            this.comboBox_TimeInt = new System.Windows.Forms.ComboBox();
            this.label_Stock = new System.Windows.Forms.Label();
            this.label_TimeInt = new System.Windows.Forms.Label();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.button_SubmitStock = new System.Windows.Forms.Button();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label_EndDate = new System.Windows.Forms.Label();
            this.panel_Submit = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.toolTip_WebLink = new System.Windows.Forms.ToolTip(this.components);
            this.button_WebLink = new System.Windows.Forms.Button();
            this.toolTip_HelpBox = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Info = new System.Windows.Forms.Panel();
            this.groupBox_DateRange = new System.Windows.Forms.GroupBox();
            this.checkBox_Volume = new System.Windows.Forms.CheckBox();
            this.groupBox_StockAndTime = new System.Windows.Forms.GroupBox();
            this.button_ClearFile = new System.Windows.Forms.Button();
            this.textBox_StockSelected = new System.Windows.Forms.TextBox();
            this.label_OpenFile = new System.Windows.Forms.Label();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.openFileDialog_OpenStock = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_StockData = new System.Windows.Forms.DataGridView();
            this.chart_StockData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.linkLabel_Name = new System.Windows.Forms.LinkLabel();
            this.toolTip_StockChart = new System.Windows.Forms.ToolTip(this.components);
            this.aCandleStickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Submit.SuspendLayout();
            this.panel_Info.SuspendLayout();
            this.groupBox_DateRange.SuspendLayout();
            this.groupBox_StockAndTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_StockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandleStickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Stock
            // 
            this.comboBox_Stock.FormattingEnabled = true;
            this.comboBox_Stock.Location = new System.Drawing.Point(18, 45);
            this.comboBox_Stock.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Stock.Name = "comboBox_Stock";
            this.comboBox_Stock.Size = new System.Drawing.Size(260, 24);
            this.comboBox_Stock.TabIndex = 0;
            this.comboBox_Stock.SelectedIndexChanged += new System.EventHandler(this.comboBox_Stock_SelectedIndexChanged);
            // 
            // comboBox_TimeInt
            // 
            this.comboBox_TimeInt.FormattingEnabled = true;
            this.comboBox_TimeInt.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.comboBox_TimeInt.Location = new System.Drawing.Point(18, 96);
            this.comboBox_TimeInt.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_TimeInt.Name = "comboBox_TimeInt";
            this.comboBox_TimeInt.Size = new System.Drawing.Size(260, 24);
            this.comboBox_TimeInt.TabIndex = 1;
            this.comboBox_TimeInt.SelectedIndexChanged += new System.EventHandler(this.comboBox_TimeInt_SelectedIndexChanged);
            // 
            // label_Stock
            // 
            this.label_Stock.AutoSize = true;
            this.label_Stock.Location = new System.Drawing.Point(21, 26);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(82, 16);
            this.label_Stock.TabIndex = 3;
            this.label_Stock.Text = "Select Stock";
            // 
            // label_TimeInt
            // 
            this.label_TimeInt.AutoSize = true;
            this.label_TimeInt.Location = new System.Drawing.Point(21, 77);
            this.label_TimeInt.Name = "label_TimeInt";
            this.label_TimeInt.Size = new System.Drawing.Size(125, 16);
            this.label_TimeInt.TabIndex = 4;
            this.label_TimeInt.Text = "Select Time Interval";
            // 
            // label_StartDate
            // 
            this.label_StartDate.AutoSize = true;
            this.label_StartDate.Location = new System.Drawing.Point(28, 29);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(107, 16);
            this.label_StartDate.TabIndex = 5;
            this.label_StartDate.Text = "Select Start Date";
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(18, 94);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker_EndDate.TabIndex = 6;
            // 
            // button_SubmitStock
            // 
            this.button_SubmitStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SubmitStock.Location = new System.Drawing.Point(3, 3);
            this.button_SubmitStock.Name = "button_SubmitStock";
            this.button_SubmitStock.Size = new System.Drawing.Size(169, 57);
            this.button_SubmitStock.TabIndex = 7;
            this.button_SubmitStock.Text = "Submit";
            this.button_SubmitStock.UseVisualStyleBackColor = true;
            this.button_SubmitStock.Click += new System.EventHandler(this.button_SubmitStock_Click);
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(18, 48);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker_StartDate.TabIndex = 8;
            // 
            // label_EndDate
            // 
            this.label_EndDate.AutoSize = true;
            this.label_EndDate.Location = new System.Drawing.Point(28, 75);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(104, 16);
            this.label_EndDate.TabIndex = 9;
            this.label_EndDate.Text = "Select End Date";
            // 
            // panel_Submit
            // 
            this.panel_Submit.Controls.Add(this.button_SubmitStock);
            this.panel_Submit.Location = new System.Drawing.Point(121, 441);
            this.panel_Submit.Name = "panel_Submit";
            this.panel_Submit.Size = new System.Drawing.Size(175, 60);
            this.panel_Submit.TabIndex = 12;
            // 
            // button_Help
            // 
            this.button_Help.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Help.Location = new System.Drawing.Point(6, 4);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(41, 40);
            this.button_Help.TabIndex = 14;
            this.button_Help.Text = "?";
            this.toolTip_HelpBox.SetToolTip(this.button_Help, "Need information or guidance to how \r\nthis application operates? Click here!");
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // button_WebLink
            // 
            this.button_WebLink.Image = ((System.Drawing.Image)(resources.GetObject("button_WebLink.Image")));
            this.button_WebLink.Location = new System.Drawing.Point(53, 4);
            this.button_WebLink.Name = "button_WebLink";
            this.button_WebLink.Size = new System.Drawing.Size(41, 40);
            this.button_WebLink.TabIndex = 13;
            this.toolTip_WebLink.SetToolTip(this.button_WebLink, resources.GetString("button_WebLink.ToolTip"));
            this.button_WebLink.UseVisualStyleBackColor = true;
            this.button_WebLink.Click += new System.EventHandler(this.button_WebLink_Click);
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.button_WebLink);
            this.panel_Info.Controls.Add(this.button_Help);
            this.panel_Info.Location = new System.Drawing.Point(12, 441);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(103, 60);
            this.panel_Info.TabIndex = 15;
            // 
            // groupBox_DateRange
            // 
            this.groupBox_DateRange.Controls.Add(this.label_StartDate);
            this.groupBox_DateRange.Controls.Add(this.dateTimePicker_StartDate);
            this.groupBox_DateRange.Controls.Add(this.dateTimePicker_EndDate);
            this.groupBox_DateRange.Controls.Add(this.label_EndDate);
            this.groupBox_DateRange.Location = new System.Drawing.Point(12, 286);
            this.groupBox_DateRange.Name = "groupBox_DateRange";
            this.groupBox_DateRange.Size = new System.Drawing.Size(299, 141);
            this.groupBox_DateRange.TabIndex = 16;
            this.groupBox_DateRange.TabStop = false;
            this.groupBox_DateRange.Text = "Manage Time Period";
            // 
            // checkBox_Volume
            // 
            this.checkBox_Volume.AutoSize = true;
            this.checkBox_Volume.Location = new System.Drawing.Point(33, 227);
            this.checkBox_Volume.Name = "checkBox_Volume";
            this.checkBox_Volume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Volume.Size = new System.Drawing.Size(213, 20);
            this.checkBox_Volume.TabIndex = 21;
            this.checkBox_Volume.Text = "Show Stock Display w/ Volume";
            this.checkBox_Volume.UseVisualStyleBackColor = true;
            // 
            // groupBox_StockAndTime
            // 
            this.groupBox_StockAndTime.Controls.Add(this.checkBox_Volume);
            this.groupBox_StockAndTime.Controls.Add(this.button_ClearFile);
            this.groupBox_StockAndTime.Controls.Add(this.textBox_StockSelected);
            this.groupBox_StockAndTime.Controls.Add(this.label_OpenFile);
            this.groupBox_StockAndTime.Controls.Add(this.button_OpenFile);
            this.groupBox_StockAndTime.Controls.Add(this.comboBox_Stock);
            this.groupBox_StockAndTime.Controls.Add(this.label_TimeInt);
            this.groupBox_StockAndTime.Controls.Add(this.label_Stock);
            this.groupBox_StockAndTime.Controls.Add(this.comboBox_TimeInt);
            this.groupBox_StockAndTime.Location = new System.Drawing.Point(12, 21);
            this.groupBox_StockAndTime.Name = "groupBox_StockAndTime";
            this.groupBox_StockAndTime.Size = new System.Drawing.Size(299, 257);
            this.groupBox_StockAndTime.TabIndex = 17;
            this.groupBox_StockAndTime.TabStop = false;
            this.groupBox_StockAndTime.Text = "Manage Stock And Time";
            // 
            // button_ClearFile
            // 
            this.button_ClearFile.Location = new System.Drawing.Point(165, 192);
            this.button_ClearFile.Name = "button_ClearFile";
            this.button_ClearFile.Size = new System.Drawing.Size(113, 24);
            this.button_ClearFile.TabIndex = 8;
            this.button_ClearFile.Text = "Clear";
            this.button_ClearFile.UseVisualStyleBackColor = true;
            this.button_ClearFile.Click += new System.EventHandler(this.button_ClearFile_Click);
            // 
            // textBox_StockSelected
            // 
            this.textBox_StockSelected.Location = new System.Drawing.Point(18, 193);
            this.textBox_StockSelected.Name = "textBox_StockSelected";
            this.textBox_StockSelected.Size = new System.Drawing.Size(141, 22);
            this.textBox_StockSelected.TabIndex = 7;
            // 
            // label_OpenFile
            // 
            this.label_OpenFile.AutoSize = true;
            this.label_OpenFile.Location = new System.Drawing.Point(21, 133);
            this.label_OpenFile.Name = "label_OpenFile";
            this.label_OpenFile.Size = new System.Drawing.Size(150, 16);
            this.label_OpenFile.TabIndex = 6;
            this.label_OpenFile.Text = "Open Stock File Directly";
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(18, 153);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(260, 34);
            this.button_OpenFile.TabIndex = 5;
            this.button_OpenFile.Text = "Select Stock";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // openFileDialog_OpenStock
            // 
            this.openFileDialog_OpenStock.Filter = "\"CSV Files (*.csv) | *.csv| All Files (*.*) | *.*\"";
            this.openFileDialog_OpenStock.InitialDirectory = "../../../Stock Data";
            this.openFileDialog_OpenStock.Title = "\"Select CSV Stock File\"";
            // 
            // dataGridView_StockData
            // 
            this.dataGridView_StockData.AutoGenerateColumns = false;
            this.dataGridView_StockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StockData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datetimeDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn});
            this.dataGridView_StockData.DataSource = this.aCandleStickBindingSource;
            this.dataGridView_StockData.Location = new System.Drawing.Point(317, 401);
            this.dataGridView_StockData.Name = "dataGridView_StockData";
            this.dataGridView_StockData.RowHeadersWidth = 51;
            this.dataGridView_StockData.RowTemplate.Height = 24;
            this.dataGridView_StockData.Size = new System.Drawing.Size(879, 155);
            this.dataGridView_StockData.TabIndex = 18;
            // 
            // chart_StockData
            // 
            this.chart_StockData.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Title = "Dates";
            chartArea1.AxisY.LabelStyle.Format = "0";
            chartArea1.AxisY.Title = "Price(s)";
            chartArea1.Name = "ChartArea_Stock";
            this.chart_StockData.ChartAreas.Add(chartArea1);
            this.chart_StockData.DataSource = this.aCandleStickBindingSource;
            legend1.Name = "Legend1";
            this.chart_StockData.Legends.Add(legend1);
            this.chart_StockData.Location = new System.Drawing.Point(317, 27);
            this.chart_StockData.Name = "chart_StockData";
            this.chart_StockData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea_Stock";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Green";
            series1.IsXValueIndexed = true;
            series1.LabelToolTip = "Open: #VALY3\\nHigh: #VALY2\\nLow: #VALY1\\nClose: #VALY4\\nDate: #VALX\\n";
            series1.Legend = "Legend1";
            series1.Name = "Ticker";
            series1.ToolTip = "Open: #VALY3\\nHigh: #VALY2\\nLow: #VALY1\\nClose: #VALY4\\nDate: #VALX\\n";
            series1.XValueMember = "datetime";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "Low, High, Open, Close";
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_StockData.Series.Add(series1);
            this.chart_StockData.Size = new System.Drawing.Size(879, 368);
            this.chart_StockData.TabIndex = 19;
            this.chart_StockData.Text = "Stock Data";
            this.chart_StockData.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_StockData_MouseMove);
            // 
            // linkLabel_Name
            // 
            this.linkLabel_Name.AutoSize = true;
            this.linkLabel_Name.Location = new System.Drawing.Point(9, 540);
            this.linkLabel_Name.Name = "linkLabel_Name";
            this.linkLabel_Name.Size = new System.Drawing.Size(226, 16);
            this.linkLabel_Name.TabIndex = 20;
            this.linkLabel_Name.TabStop = true;
            this.linkLabel_Name.Text = "Stock Entry App by Dylan Skroskznik";
            this.linkLabel_Name.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel_Name.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Name_LinkClicked);
            // 
            // toolTip_StockChart
            // 
            this.toolTip_StockChart.UseAnimation = false;
            this.toolTip_StockChart.UseFading = false;
            // 
            // aCandleStickBindingSource
            // 
            this.aCandleStickBindingSource.AllowNew = true;
            this.aCandleStickBindingSource.DataSource = typeof(WindowsFormsStockApp.aCandleStick);
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "datetime";
            this.datetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "open";
            this.openDataGridViewTextBoxColumn.HeaderText = "open";
            this.openDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.Width = 125;
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "high";
            this.highDataGridViewTextBoxColumn.HeaderText = "high";
            this.highDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            this.highDataGridViewTextBoxColumn.Width = 125;
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "low";
            this.lowDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            this.lowDataGridViewTextBoxColumn.Width = 125;
            // 
            // closeDataGridViewTextBoxColumn
            // 
            this.closeDataGridViewTextBoxColumn.DataPropertyName = "close";
            this.closeDataGridViewTextBoxColumn.HeaderText = "close";
            this.closeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            this.closeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form_StockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 565);
            this.Controls.Add(this.linkLabel_Name);
            this.Controls.Add(this.chart_StockData);
            this.Controls.Add(this.dataGridView_StockData);
            this.Controls.Add(this.groupBox_StockAndTime);
            this.Controls.Add(this.groupBox_DateRange);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.panel_Submit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_StockEntry";
            this.Text = "Stock Entry";
            this.panel_Submit.ResumeLayout(false);
            this.panel_Info.ResumeLayout(false);
            this.groupBox_DateRange.ResumeLayout(false);
            this.groupBox_DateRange.PerformLayout();
            this.groupBox_StockAndTime.ResumeLayout(false);
            this.groupBox_StockAndTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_StockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandleStickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Stock;
        private System.Windows.Forms.ComboBox comboBox_TimeInt;
        private System.Windows.Forms.Label label_Stock;
        private System.Windows.Forms.Label label_TimeInt;
        private System.Windows.Forms.Label label_StartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndDate;
        private System.Windows.Forms.Button button_SubmitStock;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;
        private System.Windows.Forms.Label label_EndDate;
        private System.Windows.Forms.Panel panel_Submit;
        private System.Windows.Forms.Button button_WebLink;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.ToolTip toolTip_WebLink;
        private System.Windows.Forms.ToolTip toolTip_HelpBox;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.GroupBox groupBox_DateRange;
        private System.Windows.Forms.GroupBox groupBox_StockAndTime;
        private System.Windows.Forms.Label label_OpenFile;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog_OpenStock;
        private System.Windows.Forms.Button button_ClearFile;
        private System.Windows.Forms.TextBox textBox_StockSelected;
        private System.Windows.Forms.DataGridView dataGridView_StockData;
        private System.Windows.Forms.BindingSource aCandleStickBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_StockData;
        private System.Windows.Forms.LinkLabel linkLabel_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBox_Volume;
        private System.Windows.Forms.ToolTip toolTip_StockChart;
    }
}

