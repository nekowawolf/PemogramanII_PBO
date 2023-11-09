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

namespace P7_1_714220063
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(356, 296);
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(tbNama.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }
            if (string.IsNullOrWhiteSpace(tbProdi.Text))
            {
                errorMessage += "Prodi belum diisi\n";
            }
            else if (!Regex.IsMatch(tbProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Strata]-[Prodi]\n";
            }

            if (string.IsNullOrWhiteSpace(tbKelas.Text))
            {
                errorMessage += "Kelas belum diisi\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Lengkap", "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(356, 637);
            }
            else
            {
                MessageBox.Show(errorMessage, "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTutupForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbSenin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSenin.Checked)
            {
                cbKuliah.Enabled = true; cbKuliah.Checked = true;
                cbTidur.Enabled = true; cbTidur.Checked = true;
                cbTravelling.Enabled = false; cbTravelling.Checked = false;
            }
        }

        private void rbMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMinggu.Checked)
            {
                cbKuliah.Enabled = false; cbKuliah.Checked = false;
                cbTidur.Enabled = true; cbTidur.Checked = true;
                cbTravelling.Enabled = true; cbTravelling.Checked = true;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            //tbNama.Text = null;
            //tbKelas.Text = null;
            //tbProdi.Text = null;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                //else if (control is ComboBox)
                //((ComboBox)control).SelectedIndex = -1;
            }
            this.Size = new Size(356, 296);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string pilihhari = haridipilih();
            string haridipilih()
            {
                if (rbMinggu.Checked)
                {
                    return rbMinggu.Text;
                }
                else if (rbSenin.Checked)
                {
                    return rbSenin.Text;
                }
                return "";
            }

            string pilihkegiatan = kegiatandipilih();
            string kegiatandipilih()
            {
                List<string> selectedActivitiesList = new List<string>();

                if (cbTidur.Checked)
                {
                    selectedActivitiesList.Add(cbTidur.Text);
                }
                if (cbKuliah.Checked)
                {
                    selectedActivitiesList.Add(cbKuliah.Text);
                }
                if (cbTravelling.Checked)
                {
                    selectedActivitiesList.Add(cbTravelling.Text);
                }
                return string.Join(", ", selectedActivitiesList);
            }

            string errorMsg = "";

            if (string.IsNullOrWhiteSpace(tbNama.Text))
            {
                errorMsg += "Nama belum diisi\n";
            }
            if (string.IsNullOrWhiteSpace(tbProdi.Text))
            {
                errorMsg += "Prodi belum diisi\n";
            }
            else if (!Regex.IsMatch(tbProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMsg += "Prodi harus berformat [Strata]-[Prodi]\n";
            }

            if (string.IsNullOrWhiteSpace(tbKelas.Text))
            {
                errorMsg += "Kelas belum diisi\n";
            }

            if (string.IsNullOrEmpty(pilihhari))
            {
                errorMsg += "Pilih salah satu hari.\n";
            }

            if (string.IsNullOrEmpty(pilihkegiatan))
            {
                errorMsg += "Pilih setidaknya satu kegiatan.\n";
            }

            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show($"Nama : {tbNama.Text}\nProdi : {tbProdi.Text}\nKelas : {tbKelas.Text}\nHari : {pilihhari}\nKegiatan : {pilihkegiatan}", "Cetak Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMsg, "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    } 
}
