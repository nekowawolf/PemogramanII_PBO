using P11_714220063.controller;
using P11_714220063.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_714220063
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();

        public void Tampil()
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (npm.Text == "" || nama.Text == "" || angkatan.SelectedIndex == -1 ||
                alamat.Text == "" || email.Text == "" || nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = npm.Text;
                m_mhs.Nama = nama.Text;
                m_mhs.Angkatan = angkatan.Text;
                m_mhs.Alamat = alamat.Text;
                m_mhs.Email = email.Text;
                m_mhs.Nohp = nohp.Text;

                mhs.Insert(mhs_mhs);
            }
        }

    }
}
