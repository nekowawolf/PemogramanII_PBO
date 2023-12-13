using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_714220063.model
{
    internal class M_mahasiswa
    {
        string npm, nama, angkatan, alamat, email, nohp;

        public M_mahasiswa() 
        {
            
        }

        public M_mahasiswa(string npm, string nama, string angkatan, string alamat, string email, string nohp)
        {
            this.Npm = npm;
            this.Nama = nama;
            this.Angkatan = angkatan;
            this.Alamat = alamat;
            this.Email = email;
            this.Nohp = nohp;
        }

        public string Npm { get => npm; set => npm = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Angkatan { get => angkatan; set => angkatan = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
        public string Nohp { get => nohp; set => nohp = value; }
    }
}
