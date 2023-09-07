namespace WindowsFormsStockApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_Stock = new System.Windows.Forms.ComboBox();
            this.comboBox_TimeInt = new System.Windows.Forms.ComboBox();
            this.label_Stock = new System.Windows.Forms.Label();
            this.label_TimeInt = new System.Windows.Forms.Label();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.button_SubmitStock = new System.Windows.Forms.Button();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label_EndDate = new System.Windows.Forms.Label();
            this.panel_StockAndTime = new System.Windows.Forms.Panel();
            this.panel_DateRange = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.button_WebLink = new System.Windows.Forms.Button();
            this.helpProvider_Website = new System.Windows.Forms.HelpProvider();
            this.panel_StockAndTime.SuspendLayout();
            this.panel_DateRange.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Stock
            // 
            this.comboBox_Stock.FormattingEnabled = true;
            this.comboBox_Stock.Location = new System.Drawing.Point(21, 32);
            this.comboBox_Stock.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Stock.Name = "comboBox_Stock";
            this.comboBox_Stock.Size = new System.Drawing.Size(242, 24);
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
            this.comboBox_TimeInt.Location = new System.Drawing.Point(21, 85);
            this.comboBox_TimeInt.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_TimeInt.Name = "comboBox_TimeInt";
            this.comboBox_TimeInt.Size = new System.Drawing.Size(242, 24);
            this.comboBox_TimeInt.TabIndex = 1;
            // 
            // label_Stock
            // 
            this.label_Stock.AutoSize = true;
            this.label_Stock.Location = new System.Drawing.Point(31, 13);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(82, 16);
            this.label_Stock.TabIndex = 3;
            this.label_Stock.Text = "Select Stock";
            // 
            // label_TimeInt
            // 
            this.label_TimeInt.AutoSize = true;
            this.label_TimeInt.Location = new System.Drawing.Point(31, 66);
            this.label_TimeInt.Name = "label_TimeInt";
            this.label_TimeInt.Size = new System.Drawing.Size(125, 16);
            this.label_TimeInt.TabIndex = 4;
            this.label_TimeInt.Text = "Select Time Interval";
            // 
            // label_StartDate
            // 
            this.label_StartDate.AutoSize = true;
            this.label_StartDate.Location = new System.Drawing.Point(38, 13);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(107, 16);
            this.label_StartDate.TabIndex = 5;
            this.label_StartDate.Text = "Select Start Date";
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(28, 87);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker_EndDate.TabIndex = 6;
            // 
            // button_SubmitStock
            // 
            this.button_SubmitStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SubmitStock.Location = new System.Drawing.Point(26, 18);
            this.button_SubmitStock.Name = "button_SubmitStock";
            this.button_SubmitStock.Size = new System.Drawing.Size(248, 104);
            this.button_SubmitStock.TabIndex = 7;
            this.button_SubmitStock.Text = "Submit";
            this.button_SubmitStock.UseVisualStyleBackColor = true;
            this.button_SubmitStock.Click += new System.EventHandler(this.button_SubmitStock_Click);
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(28, 32);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker_StartDate.TabIndex = 8;
            // 
            // label_EndDate
            // 
            this.label_EndDate.AutoSize = true;
            this.label_EndDate.Location = new System.Drawing.Point(38, 68);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(104, 16);
            this.label_EndDate.TabIndex = 9;
            this.label_EndDate.Text = "Select End Date";
            // 
            // panel_StockAndTime
            // 
            this.panel_StockAndTime.Controls.Add(this.comboBox_Stock);
            this.panel_StockAndTime.Controls.Add(this.label_Stock);
            this.panel_StockAndTime.Controls.Add(this.label_TimeInt);
            this.panel_StockAndTime.Controls.Add(this.comboBox_TimeInt);
            this.panel_StockAndTime.Location = new System.Drawing.Point(27, 27);
            this.panel_StockAndTime.Name = "panel_StockAndTime";
            this.panel_StockAndTime.Size = new System.Drawing.Size(298, 136);
            this.panel_StockAndTime.TabIndex = 10;
            // 
            // panel_DateRange
            // 
            this.panel_DateRange.Controls.Add(this.label_StartDate);
            this.panel_DateRange.Controls.Add(this.dateTimePicker_StartDate);
            this.panel_DateRange.Controls.Add(this.dateTimePicker_EndDate);
            this.panel_DateRange.Controls.Add(this.label_EndDate);
            this.panel_DateRange.Location = new System.Drawing.Point(639, 27);
            this.panel_DateRange.Name = "panel_DateRange";
            this.panel_DateRange.Size = new System.Drawing.Size(339, 136);
            this.panel_DateRange.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_SubmitStock);
            this.panel3.Location = new System.Drawing.Point(335, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 136);
            this.panel3.TabIndex = 12;
            // 
            // button_Help
            // 
            this.button_Help.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Help.Location = new System.Drawing.Point(104, 452);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(62, 58);
            this.button_Help.TabIndex = 14;
            this.button_Help.Text = "?";
            this.button_Help.UseVisualStyleBackColor = true;
            // 
            // button_WebLink
            // 
            this.button_WebLink.Image = global::WindowsFormsStockApp.Properties.Resources.globe_10242;
            this.button_WebLink.Location = new System.Drawing.Point(27, 452);
            this.button_WebLink.Name = "button_WebLink";
            this.button_WebLink.Size = new System.Drawing.Size(62, 58);
            this.button_WebLink.TabIndex = 13;
            this.button_WebLink.UseVisualStyleBackColor = true;
            this.button_WebLink.MouseHover += new System.EventHandler(this.button_WebLink_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 522);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.button_WebLink);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_DateRange);
            this.Controls.Add(this.panel_StockAndTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_StockAndTime.ResumeLayout(false);
            this.panel_StockAndTime.PerformLayout();
            this.panel_DateRange.ResumeLayout(false);
            this.panel_DateRange.PerformLayout();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel_StockAndTime;
        private System.Windows.Forms.Panel panel_DateRange;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_WebLink;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.HelpProvider helpProvider_Website;
    }
}

