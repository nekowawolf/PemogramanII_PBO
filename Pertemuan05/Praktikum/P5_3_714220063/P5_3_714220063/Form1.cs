using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714220063
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string os = "";
            string status = "";


            if (rb_android.Checked == true)
            {
                os = "Android";
            }

            if (rb_ios.Checked == true)
            {
                os = "iOS";
            }

            if (cbYa.Checked == true)
            {
                status = "Ya sudah di perbaikin";
            }

            MessageBox.Show(
                "Merek HP : " + txtMerkHP.Text +
                "\nSistem Operasi : " + os +
                "\nStatus Perbaikan :" + status,
                "Informasi Service HP",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }        

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
