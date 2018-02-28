using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace GetProcessorID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorID"].ToString();
            }
            txtNumber.Text = id;

        }

        private void btnMother_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            string motherBoard = "";
            foreach (ManagementObject mo in moc)
            {
                motherBoard = (string)mo["SerialNumber"];
            }
            txtNumber.Text = motherBoard;
        }
    }
}
