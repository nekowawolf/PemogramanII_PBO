using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714220063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Angka Pertama : ");
            float angkaPertama = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Angka Kedua : ");
            float angkaKedua = Convert.ToInt32(Console.ReadLine());

            float hasilPenjumblahan = angkaPertama + angkaKedua; Console.WriteLine($"Penjumblahan:{angkaPertama} + {angkaKedua} = {hasilPenjumblahan}");

            float hasilPengurangan = angkaPertama - angkaKedua; Console.WriteLine($"Pengurangan:{angkaPertama} - {angkaKedua} = {hasilPengurangan}");

            float hasilPerkalian = angkaPertama * angkaKedua; Console.WriteLine($"Perkalian:{angkaPertama} * {angkaKedua} = {hasilPerkalian}");

            float hasilPembagian = angkaPertama / angkaKedua; Console.WriteLine($"Perkalian:{angkaPertama} / {angkaKedua} = {hasilPembagian}");

        }
    }
}
