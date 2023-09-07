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
            this.comboBox_Stock = new System.Windows.Forms.ComboBox();
            this.comboBox_TimeInt = new System.Windows.Forms.ComboBox();
            this.label_Stock = new System.Windows.Forms.Label();
            this.label_TimeInt = new System.Windows.Forms.Label();
            this.label_Test = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBox_Stock
            // 
            this.comboBox_Stock.FormattingEnabled = true;
            this.comboBox_Stock.Location = new System.Drawing.Point(16, 31);
            this.comboBox_Stock.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Stock.Name = "comboBox_Stock";
            this.comboBox_Stock.Size = new System.Drawing.Size(252, 24);
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
            this.comboBox_TimeInt.Location = new System.Drawing.Point(16, 90);
            this.comboBox_TimeInt.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_TimeInt.Name = "comboBox_TimeInt";
            this.comboBox_TimeInt.Size = new System.Drawing.Size(252, 24);
            this.comboBox_TimeInt.TabIndex = 1;
            // 
            // label_Stock
            // 
            this.label_Stock.AutoSize = true;
            this.label_Stock.Location = new System.Drawing.Point(23, 12);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(82, 16);
            this.label_Stock.TabIndex = 3;
            this.label_Stock.Text = "Select Stock";
            // 
            // label_TimeInt
            // 
            this.label_TimeInt.AutoSize = true;
            this.label_TimeInt.Location = new System.Drawing.Point(23, 71);
            this.label_TimeInt.Name = "label_TimeInt";
            this.label_TimeInt.Size = new System.Drawing.Size(125, 16);
            this.label_TimeInt.TabIndex = 4;
            this.label_TimeInt.Text = "Select Time Interval";
            // 
            // label_Test
            // 
            this.label_Test.AutoSize = true;
            this.label_Test.Location = new System.Drawing.Point(23, 133);
            this.label_Test.Name = "label_Test";
            this.label_Test.Size = new System.Drawing.Size(34, 16);
            this.label_Test.TabIndex = 5;
            this.label_Test.Text = "Test";
            this.label_Test.Click += new System.EventHandler(this.label_Test_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 505);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_Test);
            this.Controls.Add(this.label_TimeInt);
            this.Controls.Add(this.label_Stock);
            this.Controls.Add(this.comboBox_TimeInt);
            this.Controls.Add(this.comboBox_Stock);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Stock;
        private System.Windows.Forms.ComboBox comboBox_TimeInt;
        private System.Windows.Forms.Label label_Stock;
        private System.Windows.Forms.Label label_TimeInt;
        private System.Windows.Forms.Label label_Test;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

