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
            this.comboBox_Stock = new System.Windows.Forms.ComboBox();
            this.comboBox_TimeInt = new System.Windows.Forms.ComboBox();
            this.label_Stock = new System.Windows.Forms.Label();
            this.label_TimeInt = new System.Windows.Forms.Label();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.button_SubmitStock = new System.Windows.Forms.Button();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label_EndDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.button_WebLink = new System.Windows.Forms.Button();
            this.toolTip_WebLink = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_HelpBox = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Info = new System.Windows.Forms.Panel();
            this.groupBox_DateRange = new System.Windows.Forms.GroupBox();
            this.groupBox_StockAndTime = new System.Windows.Forms.GroupBox();
            this.label_OpenFile = new System.Windows.Forms.Label();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.openFileDialog_OpenStock = new System.Windows.Forms.OpenFileDialog();
            this.textBox_StockSelected = new System.Windows.Forms.TextBox();
            this.button_ClearFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel_Info.SuspendLayout();
            this.groupBox_DateRange.SuspendLayout();
            this.groupBox_StockAndTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Stock
            // 
            this.comboBox_Stock.FormattingEnabled = true;
            this.comboBox_Stock.Location = new System.Drawing.Point(18, 45);
            this.comboBox_Stock.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Stock.Name = "comboBox_Stock";
            this.comboBox_Stock.Size = new System.Drawing.Size(250, 24);
            this.comboBox_Stock.TabIndex = 0;
            this.comboBox_Stock.DropDown += new System.EventHandler(this.comboBox_Stock_DropDown);
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
            this.comboBox_TimeInt.Size = new System.Drawing.Size(250, 24);
            this.comboBox_TimeInt.TabIndex = 1;
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
            this.label_StartDate.Location = new System.Drawing.Point(28, 26);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(107, 16);
            this.label_StartDate.TabIndex = 5;
            this.label_StartDate.Text = "Select Start Date";
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(18, 91);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker_EndDate.TabIndex = 6;
            // 
            // button_SubmitStock
            // 
            this.button_SubmitStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SubmitStock.Location = new System.Drawing.Point(13, 12);
            this.button_SubmitStock.Name = "button_SubmitStock";
            this.button_SubmitStock.Size = new System.Drawing.Size(167, 58);
            this.button_SubmitStock.TabIndex = 7;
            this.button_SubmitStock.Text = "Submit";
            this.button_SubmitStock.UseVisualStyleBackColor = true;
            this.button_SubmitStock.Click += new System.EventHandler(this.button_SubmitStock_Click);
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(18, 45);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker_StartDate.TabIndex = 8;
            // 
            // label_EndDate
            // 
            this.label_EndDate.AutoSize = true;
            this.label_EndDate.Location = new System.Drawing.Point(28, 72);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(104, 16);
            this.label_EndDate.TabIndex = 9;
            this.label_EndDate.Text = "Select End Date";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_SubmitStock);
            this.panel3.Location = new System.Drawing.Point(177, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 80);
            this.panel3.TabIndex = 12;
            // 
            // button_Help
            // 
            this.button_Help.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Help.Location = new System.Drawing.Point(15, 11);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(62, 58);
            this.button_Help.TabIndex = 14;
            this.button_Help.Text = "?";
            this.toolTip_HelpBox.SetToolTip(this.button_Help, "Need information or guidance to how \r\nthis application operates? Click here!");
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // button_WebLink
            // 
            this.button_WebLink.Image = global::WindowsFormsStockApp.Properties.Resources.globe_10242;
            this.button_WebLink.Location = new System.Drawing.Point(83, 11);
            this.button_WebLink.Name = "button_WebLink";
            this.button_WebLink.Size = new System.Drawing.Size(62, 58);
            this.button_WebLink.TabIndex = 13;
            this.toolTip_WebLink.SetToolTip(this.button_WebLink, resources.GetString("button_WebLink.ToolTip"));
            this.button_WebLink.UseVisualStyleBackColor = true;
            this.button_WebLink.Click += new System.EventHandler(this.button_WebLink_Click);
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.button_WebLink);
            this.panel_Info.Controls.Add(this.button_Help);
            this.panel_Info.Location = new System.Drawing.Point(12, 412);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(159, 80);
            this.panel_Info.TabIndex = 15;
            // 
            // groupBox_DateRange
            // 
            this.groupBox_DateRange.Controls.Add(this.label_StartDate);
            this.groupBox_DateRange.Controls.Add(this.dateTimePicker_StartDate);
            this.groupBox_DateRange.Controls.Add(this.dateTimePicker_EndDate);
            this.groupBox_DateRange.Controls.Add(this.label_EndDate);
            this.groupBox_DateRange.Location = new System.Drawing.Point(12, 271);
            this.groupBox_DateRange.Name = "groupBox_DateRange";
            this.groupBox_DateRange.Size = new System.Drawing.Size(284, 131);
            this.groupBox_DateRange.TabIndex = 16;
            this.groupBox_DateRange.TabStop = false;
            this.groupBox_DateRange.Text = "Manage Time Period";
            // 
            // groupBox_StockAndTime
            // 
            this.groupBox_StockAndTime.Controls.Add(this.button_ClearFile);
            this.groupBox_StockAndTime.Controls.Add(this.textBox_StockSelected);
            this.groupBox_StockAndTime.Controls.Add(this.label_OpenFile);
            this.groupBox_StockAndTime.Controls.Add(this.button_OpenFile);
            this.groupBox_StockAndTime.Controls.Add(this.comboBox_Stock);
            this.groupBox_StockAndTime.Controls.Add(this.label_TimeInt);
            this.groupBox_StockAndTime.Controls.Add(this.label_Stock);
            this.groupBox_StockAndTime.Controls.Add(this.comboBox_TimeInt);
            this.groupBox_StockAndTime.Location = new System.Drawing.Point(12, 12);
            this.groupBox_StockAndTime.Name = "groupBox_StockAndTime";
            this.groupBox_StockAndTime.Size = new System.Drawing.Size(284, 244);
            this.groupBox_StockAndTime.TabIndex = 17;
            this.groupBox_StockAndTime.TabStop = false;
            this.groupBox_StockAndTime.Text = "Manage Stock And Time";
            // 
            // label_OpenFile
            // 
            this.label_OpenFile.AutoSize = true;
            this.label_OpenFile.Location = new System.Drawing.Point(21, 135);
            this.label_OpenFile.Name = "label_OpenFile";
            this.label_OpenFile.Size = new System.Drawing.Size(150, 16);
            this.label_OpenFile.TabIndex = 6;
            this.label_OpenFile.Text = "Open Stock File Directly";
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(18, 155);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(250, 34);
            this.button_OpenFile.TabIndex = 5;
            this.button_OpenFile.Text = "Select Stock";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // openFileDialog_OpenStock
            // 
            this.openFileDialog_OpenStock.FileName = "ABC.csv";
            this.openFileDialog_OpenStock.Filter = "\"csv files |*.csv\"";
            this.openFileDialog_OpenStock.InitialDirectory = "C:\\Users\\dskro\\OneDrive\\Desktop\\SCHOOL\\2023SU-FA\\COP4365 Sfw System Development\\S" +
    "tock-Market-Project\\WindowsFormsStockApp\\bin\\Stock Data\";\r\n";
            this.openFileDialog_OpenStock.Title = "\"Select CSV Stock File\"";
            // 
            // textBox_StockSelected
            // 
            this.textBox_StockSelected.Location = new System.Drawing.Point(18, 196);
            this.textBox_StockSelected.Name = "textBox_StockSelected";
            this.textBox_StockSelected.Size = new System.Drawing.Size(141, 22);
            this.textBox_StockSelected.TabIndex = 7;
            // 
            // button_ClearFile
            // 
            this.button_ClearFile.Location = new System.Drawing.Point(165, 195);
            this.button_ClearFile.Name = "button_ClearFile";
            this.button_ClearFile.Size = new System.Drawing.Size(103, 24);
            this.button_ClearFile.TabIndex = 8;
            this.button_ClearFile.Text = "Clear";
            this.button_ClearFile.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 389);
            this.dataGridView1.TabIndex = 18;
            // 
            // Form_StockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_StockAndTime);
            this.Controls.Add(this.groupBox_DateRange);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_StockEntry";
            this.Text = "Stock Entry";
            this.panel3.ResumeLayout(false);
            this.panel_Info.ResumeLayout(false);
            this.groupBox_DateRange.ResumeLayout(false);
            this.groupBox_DateRange.PerformLayout();
            this.groupBox_StockAndTime.ResumeLayout(false);
            this.groupBox_StockAndTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

