using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220063
{
    class FieldProperty
    {
        private DateTime _field; // Menggunakan tipe data DateTime untuk menyimpan tanggal

        // Property untuk mengakses dan memanipulasi variabel instance (field)
        public DateTime Field
        {
            get { return _field; }
            set { _field = value; }
        }

        public void DisplayField()
        {
            Console.WriteLine($"Initial Release: {_field.ToString("dd MMMM yyyy")}"); // Menampilkan tanggal dengan format tertentu
        }
    }
}
