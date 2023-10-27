using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220063
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Laki-Laki");
            comboBox1.Items.Add("Perempuan");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string PilihJadwal = "";
            string pilihanKelas = "";
            string jenisKelamin = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "";

            
            if (string.IsNullOrEmpty(jenisKelamin))
            {
                MessageBox.Show("Harap pilih jenis kelamin",
                                "Warning!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked && !checkBox7.Checked && !checkBox8.Checked)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas",
                                "Warning!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal",
                                "Warning!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                

                if (checkBox1.Checked)
                {
                    pilihanKelas += "Biola, ";
                }
                if (checkBox2.Checked)
                {
                    pilihanKelas += "Gitar, ";
                }

                if (checkBox3.Checked)
                {
                    pilihanKelas += "Saxophone, ";
                }
                if (checkBox4.Checked)
                {
                    pilihanKelas += "Konduktor, ";
                }
                if (checkBox5.Checked)
                {
                    pilihanKelas += "Piano, ";
                }
                if (checkBox6.Checked)
                {
                    pilihanKelas += "Drum, ";
                }
                if (checkBox7.Checked)
                {
                    pilihanKelas += "Vokal, ";
                }
                if (checkBox8.Checked)
                {
                    pilihanKelas = "Komposer";
                }
                if (!string.IsNullOrEmpty(pilihanKelas))
                {
                    pilihanKelas = pilihanKelas.TrimEnd(' ', ',');
                }

                if (radioButton1.Checked)
                {
                    PilihJadwal = "Senin & Rabu, 14.00 - 16.00";
                }
                else if (radioButton2.Checked)
                {
                    PilihJadwal = "Selasa & Kamis, 14.00 - 16.00";
                }
                else if (radioButton3.Checked)
                {
                    PilihJadwal = "Sabtu & Minggu, 09.00 - 11.00";
                }
                else if (radioButton4.Checked)
                {
                    PilihJadwal = "Minggu, 13.00 - 17.00";
                }

                MessageBox.Show(

                    "Nama : " + textBox1.Text +
                    "\nJenis Kelamin : " + jenisKelamin +
                    "\nTanggal Lahir : " + dateTimePicker1.Text +
                    "\nPilihan Kelas : " + pilihanKelas +
                    "\nPilihan Jadwal : " + PilihJadwal,

                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}