using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714220063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Jumlah Anak Ayam: ");
            if (int.TryParse(Console.ReadLine(), out int jumlahAyam) && jumlahAyam >= 0 && jumlahAyam <= 10)
            {
                Console.WriteLine($"ANAK AYAM TURUN {jumlahAyam}\n");

                while (jumlahAyam > 1)
                {
                    Console.WriteLine($"anak ayam turunlah {jumlahAyam}, mati satu tinggallah {--jumlahAyam}");
                }

                Console.WriteLine("anak ayam turunlah 1, mati satu tinggallah induknya");
            }
            else
            {
                Console.WriteLine("Jumlah ayam tidak boleh dibawah 0 atau diatas 10");
            }
        }
    }
}