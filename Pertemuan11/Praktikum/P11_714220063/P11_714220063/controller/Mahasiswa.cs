using P11_714220063.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P11_714220063.controller
{
    internal class Mahasiswa
    {
        Koneksi koneksi = new Koneksi();
    }
    public bool Insert( M_mahasiswa mahasiswa)
    {
        Boolean status = false;
        try
        {
            Koneksi.OpenConnection();
            Koneksi.ExecuteQuery("INSERT INTO t_mahasiswa
            (Npm, Nama, angkatan, alamat, email, nohp) VALUES('" + mahasiswa.Npm + "','" +
            mahasiswa.Nama + "','" + mahasiswa.Angkatan + "','" + mahasiswa.Alamat +
            "','" + mahasiswa.Email + "','" + mahasiswa.Nohp + "')");
            status = true;
            MessageBox.Show("Data berhasil ditambahkan", "Informasi",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Koneksi.CloseConnection();

        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return status;
    }
}
