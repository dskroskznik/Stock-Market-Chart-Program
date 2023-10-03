using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStockApp
{
    public partial class Form_StockEntry : Form
    {
        public Form_StockEntry()
        {
            InitializeComponent();
        }
        private void button_Help_Click(object sender, EventArgs e)
        {
            string helpText = " -- How To Use -- \n\n Stock And Time:\n\tSelect the stock ticker of your" +
                "choosing ";
            MessageBox.Show(helpText, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_WebLink_Click(object sender, EventArgs e)
        {
            string webLink = "https://finance.yahoo.com/trending-tickers";
            Process.Start(webLink);
        }

        private void comboBox_Stock_DropDown(object sender, EventArgs e)
        {   //filenames directory path
            string dirPath = @"C:\Users\dskro\OneDrive\Desktop\SCHOOL\2023SU-FA\COP4365 Sfw System Development\Stock-Market-Project\WindowsFormsStockApp\bin\Stock Data";
            //string dirPath = @"C:\...\bin\Stock Data";
            string selectedTime = comboBox_TimeInt.Text.ToLower();
            comboBox_Stock.Items.Clear();  

            if (Directory.Exists(dirPath))
            {
                string[] filePath = Directory.GetFiles(dirPath, "*.csv");

                foreach (string names in filePath)
                {
                    string stockNames = Path.GetFileNameWithoutExtension(names);
                    string[] stockNameParts = stockNames.Split('-');
                    string stockTimeInt = stockNameParts.Last().ToLower();

                    if (!comboBox_Stock.Items.Contains(stockNames))
                    {
                        if(stockTimeInt == selectedTime) 
                        { 
                            comboBox_Stock.Items.Add(stockNames);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error Occurred: Directory does not exist", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolTip_WebLink_Popup(object sender, PopupEventArgs e)
        {
            toolTip_WebLink.SetToolTip(button_WebLink, "");
        }

        private void toolTip_HelpBox_Popup(object sender, PopupEventArgs e)
        {
            toolTip_HelpBox.SetToolTip(button_Help, "");
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            DialogResult fileDialog = openFileDialog_OpenStock.ShowDialog();
            if (fileDialog == DialogResult.OK)
            {
                String refString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\"\"Close\"";
                String name = openFileDialog_OpenStock.FileName;
                Text = name;
                
                String[] filesNames = openFileDialog_OpenStock.FileNames;

                using (StreamReader reader = new StreamReader(name))
                {
                    string fileHeader = reader.ReadLine();
                    string fileLine;
                    
                    if(fileHeader == refString)
                    {
                        while ((fileLine = reader.ReadLine()) != null)
                        {
                            Text = fileLine;
                        }
                    }
                }
            }
        }
        private void button_SubmitStock_Click(object sender, EventArgs e)
        {

        }

    }
}


