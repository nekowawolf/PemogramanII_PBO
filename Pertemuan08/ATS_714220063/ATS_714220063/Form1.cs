using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS_714220063
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(816, 363);
        }

        private void button_pilihKuliah_Click(object sender, EventArgs e)
        {
            if (textBox_nim.Text == "")
            {
                MessageBox.Show("NIM harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_nim.Focus();
                return;
            }

            if (textBox_nama.Text == "")
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_nama.Focus();
            }

            if (radioButton_laki.Checked == false && radioButton_perempuan.Checked == false)
            {
                MessageBox.Show("Jenis kelamin harus dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioButton_laki.Focus();
                return;
            }

            if (textBox_alamat.Text == "")
            {
                MessageBox.Show("Alamat harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_alamat.Focus();
                return;
            }

            if (comboBox_pStudi.SelectedIndex == -1)
            {
                MessageBox.Show("Program studi harus dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_pStudi.Focus();
                return;
            }

            if (textBox_akademik.Text == "")
            {
                MessageBox.Show("IPK akademik harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_akademik.Focus();
                return;
            }

            if (int.TryParse(textBox_semester.Text, out int semester) == false || semester < 1 || semester > 8)
            {

                MessageBox.Show("Semester harus diisi dengan angka antara 1 dan 8!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_semester.Focus();

                return;
            }

            MessageBox.Show("lengkap", "Informasi data submit", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Size = new Size(816, 639);
        }

        private void textBox_nim_TextChanged(object sender, EventArgs e)
        {
            if (!textBox_nim.Text.All(char.IsDigit))
            {

                errorProvider_worng.SetError(textBox_nim, "Wajib angka");
            }
            else
            {

                errorProvider_worng.SetError(textBox_nim, null);
            }
        }

        private void textBox_nama_TextChanged(object sender, EventArgs e)
        {
            if (!textBox_nama.Text.All(char.IsLetter))
            {

                errorProvider_worng.SetError(textBox_nama, "Wajib Huruf");
            }
            else
            {

                errorProvider_worng.SetError(textBox_nama, null);
            }
        }

        private void textBox_akademik_TextChanged(object sender, EventArgs e)
        {
            string regex = @"^[0-9]{4}\/[0-9]{4}$";

            if (!Regex.IsMatch(textBox_akademik.Text, regex))
            {

                errorProvider_worng.SetError(textBox_akademik, "Format tidak valid, contoh : 2023/2024");
            }
            else
            {

                errorProvider_worng.SetError(textBox_akademik, null);
            }
        }

        private void textBox_semester_TextChanged(object sender, EventArgs e)
        {
            if (!textBox_semester.Text.All(char.IsDigit))
            {

                errorProvider_worng.SetError(textBox_semester, "Wajib angka");
            }
            else
            {

                errorProvider_worng.SetError(textBox_semester, null);
            }
        }

        private void radioButtonKurikulum2006_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKurikulum2006.Checked)
            {
                foreach (Control control in groupBoxMataKuliah.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        if (checkBox == checkBoxPengantarLogistik || checkBox == checkBoxManajemenRantaiPasok)
                        {
                            checkBox.Enabled = false;
                            checkBox.Checked = false;
                        }
                        else
                        {
                            checkBox.Enabled = true;
                        }
                    }
                }
            }
        }

        private void radioButtonKurikulum2013_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKurikulum2013.Checked)
            {
                foreach (Control control in groupBoxMataKuliah.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        if (checkBox == checkBoxFisika || checkBox == checkBoxPendidikanKewarganegaraan)
                        {
                            checkBox.Enabled = false;
                            checkBox.Checked = false;
                        }
                        else
                        {
                            checkBox.Enabled = true;
                        }
                    }
                }
            }
        }

        private void radioButtonKurikulumMerdeka_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKurikulumMerdeka.Checked)
            {
                foreach (Control control in groupBoxMataKuliah.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        if (checkBox == checkBoxMatematika || checkBox == checkBoxFisika || checkBox == checkBoxPengantarLogistik)
                        {
                            checkBox.Enabled = false;
                            checkBox.Checked = false;
                        }
                        else
                        {
                            checkBox.Enabled = true;
                        }
                    }
                }
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string infoData = "";

            string nim = textBox_nim.Text;
            infoData += "NIM: " + nim + "\n";

            string nama = textBox_nama.Text;
            infoData += "Nama: " + nama + "\n";

            string jenisKelamin = radioButton_laki.Checked ? "Laki-laki" : "Perempuan";
            infoData += "Jenis Kelamin: " + jenisKelamin + "\n";

            string alamat = textBox_alamat.Text;
            infoData += "Alamat: " + alamat + "\n";

            string programStudi = comboBox_pStudi.Text;
            infoData += "Program Studi: " + programStudi + "\n";

            string tahunAkademik = textBox_akademik.Text;
            infoData += "Tahun Akademik: " + tahunAkademik + "\n";

            string semester = textBox_semester.Text;
            infoData += "Semester: " + semester + "\n";

            infoData += "=======================\n";

            string kurikulum = "";
            if (radioButtonKurikulum2006.Checked)
            {
                kurikulum = "Kurikulum 2006";
            }
            else if (radioButtonKurikulum2013.Checked)
            {
                kurikulum = "Kurikulum 2013";
            }
            else if (radioButtonKurikulumMerdeka.Checked)
            {
                kurikulum = "Kurikulum Merdeka";
            }
            infoData += "Kurikulum: " + kurikulum + "\n";

            infoData += "Mata Kuliah Pilihan: ";
            List<string> mataKuliahPilihan = new List<string>();
            foreach (Control control in groupBoxMataKuliah.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    mataKuliahPilihan.Add(checkBox.Text);
                }
            }
            infoData += string.Join(", ", mataKuliahPilihan) + "\n";


            MessageBox.Show(infoData, "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }

            foreach (RadioButton radioButton in groupBoxKurikulum.Controls.OfType<RadioButton>())
            {
                radioButton.Checked = false;
            }

            foreach (CheckBox checkBox in groupBoxMataKuliah.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }

            errorProvider_worng.Clear();

            this.Size = new Size(816, 363);

            MessageBox.Show("Form telah direset.", "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
