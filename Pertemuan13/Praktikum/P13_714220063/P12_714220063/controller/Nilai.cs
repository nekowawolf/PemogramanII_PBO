using P12_714220063.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_714220063.controller
{
    internal class Nilai
    {
        Koneksi koneksi = new Koneksi();
        //Method insert
        public bool Insert(M_nilai nilai)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_nilai (matkul, kategori, npm, nilai) VALUES('" + nilai.Matkul + "', '" + nilai.Kategori + "','" + nilai.Npm + "','" + nilai.Nilai + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }
        //Method update
        public bool Update(M_nilai nilai, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_nilai SET matkul='" + nilai.Matkul
               + "'," + "kategori='" + nilai.Kategori + "'," + "npm='" + nilai.Npm + "'," +
               "nilai='" + nilai.Nilai + "' WHERE id_nilai='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }
        //Method delete
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_nilai WHERE id_nilai='" + id
               + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }
    }
}