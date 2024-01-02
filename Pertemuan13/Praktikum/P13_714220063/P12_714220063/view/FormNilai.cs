using MySql.Data.MySqlClient;
using P12_714220063.controller;
using P12_714220063.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P12_714220063.view
{
    public partial class FormNilai : Form
    {
        Koneksi koneksi = new Koneksi();
        M_nilai m_nilai = new M_nilai();
        string id_nilai;

        public FormNilai()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            DataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul,kategori, t_nilai.npm, nama, nilai FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");

            //Ubah Nama Header Tabel
            DataNilai.Columns[0].HeaderText = "ID";
            DataNilai.Columns[1].HeaderText = "Matkul";
            DataNilai.Columns[2].HeaderText = "Kategori";
            DataNilai.Columns[3].HeaderText = "NPM";
            DataNilai.Columns[4].HeaderText = "Nama";
            DataNilai.Columns[5].HeaderText = "Nilai";
        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataMhs();
        }

        public void GetDataMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                cbnpm.Items.Add(reader.GetString("npm"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void DataNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_nilai = DataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbmatkul.Text = DataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbkategori.Text = DataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbnpm.Text = DataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbnilai.Text = DataNilai.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " + "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm " + "WHERE t_nilai.npm LIKE '%' '" + tbCariData.Text + "' '%' " + "OR nama LIKE '%' '" + tbCariData.Text + "' '%'" + "OR matkul LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        public void GetNamaMhs()
        {
            //ambil data nama ketika combobox npm dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama FROM t_mahasiswa WHERE npm = '" + cbnpm.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbnama.Text = reader.GetString(0);
                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void cbnpm_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataMhs();
        }

        public void ResetForm()
        {
            cbmatkul.SelectedIndex = -1;
            cbkategori.SelectedIndex = -1;
            cbnpm.SelectedIndex = -1;
            tbnilai.Text = "";
            tbnama.Text = "";
            tbCariData.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbmatkul.SelectedIndex == -1 || cbkategori.SelectedIndex == -1 || cbnpm.SelectedIndex == -1 || tbnilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = cbmatkul.Text;
                m_nilai.Kategori = cbkategori.Text;
                m_nilai.Npm = cbnpm.Text;
                m_nilai.Nilai = tbnilai.Text;

                nilai.Insert(m_nilai);

                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (cbmatkul.SelectedIndex == -1 || cbkategori.SelectedIndex == -1 || cbnpm.SelectedIndex == -1 || tbnilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = cbmatkul.Text;
                m_nilai.Kategori = cbkategori.Text;
                m_nilai.Npm = cbnpm.Text;
                m_nilai.Nilai = tbnilai.Text;

                nilai.Insert(m_nilai);

                ResetForm();
                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (cbmatkul.SelectedIndex == -1 || cbkategori.SelectedIndex == -1 || cbnpm.SelectedIndex == -1 || tbnilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = cbmatkul.Text;
                m_nilai.Kategori = cbkategori.Text;
                m_nilai.Npm = cbnpm.Text;
                m_nilai.Nilai = tbnilai.Text;

                nilai.Insert(m_nilai);

                ResetForm();
                Tampil();
            }
        }

        private void FormNilai_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
