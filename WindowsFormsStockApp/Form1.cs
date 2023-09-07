using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStockApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox_Stock_DropDown(object sender, EventArgs e)
        {   //filenames directory path
            string dirPath = @"C:\Users\dskro\OneDrive\Desktop\SCHOOL\2023SU-FA\COP4365 Sfw System Development\Stock-Market-Project\Stock Data";

            if (Directory.Exists(dirPath))
            {
                string[] filePath = Directory.GetFiles(dirPath);
                foreach (string names in filePath)
                {
                    string stockNames = Path.GetFileNameWithoutExtension(names).Split('-')[0];

                    if (!comboBox_Stock.Items.Contains(stockNames))
                    {
                        comboBox_Stock.Items.Add(stockNames);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error Occurred: Directory does not exist");
            }

        }

        private void label_Test_Click(object sender, EventArgs e)
        {

        }
    }
}
