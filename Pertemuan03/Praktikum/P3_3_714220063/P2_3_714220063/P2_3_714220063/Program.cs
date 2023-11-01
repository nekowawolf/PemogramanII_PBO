using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU PERSEGI PANJANG");

            char pilihanUlang;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.Write("Menu Pilihan: ");

                if (int.TryParse(Console.ReadLine(), out int pilihanMenu))
                {
                    switch (pilihanMenu)
                    {
                        case 1:
                            HitungLuasPersegiPanjang();
                            break;
                        case 2:
                            HitungKelilingPersegiPanjang();
                            break;
                        default:
                            Console.WriteLine("Pilihan menu tidak valid. Silakan coba lagi.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Silakan masukkan angka.");
                }

                Console.Write("\nIngin melanjutkan (Y/T)? ");
                pilihanUlang = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (char.ToUpper(pilihanUlang) == 'Y');
        }

        static void HitungLuasPersegiPanjang()
        {
            Console.WriteLine("\nMENGHITUNG LUAS PERSEGI PANJANG");
            Console.Write("Masukkan Panjang : ");
            if (double.TryParse(Console.ReadLine(), out double panjang) && panjang > 0)
            {
                Console.Write("Masukkan Lebar : ");
                if (double.TryParse(Console.ReadLine(), out double lebar) && lebar > 0)
                {
                    double luas = panjang * lebar;
                    Console.WriteLine($"\nLuas Persegi Panjang: {luas:F0}");
                }
                else
                {
                    Console.WriteLine("Masukkan lebar yang valid (bilangan positif).");
                }
            }
            else
            {
                Console.WriteLine("Masukkan panjang yang valid (bilangan positif).");
            }
        }

        static void HitungKelilingPersegiPanjang()
        {
            Console.WriteLine("\nMENGHITUNG KELILING PERSEGI PANJANG");
            Console.Write("Masukkan Panjang : ");
            if (double.TryParse(Console.ReadLine(), out double panjang) && panjang > 0)
            {
                Console.Write("Masukkan Lebar : ");
                if (double.TryParse(Console.ReadLine(), out double lebar) && lebar > 0)
                {
                    double keliling = 2 * (panjang + lebar);
                    Console.WriteLine($"\nKeliling Persegi Panjang: {keliling:F0}\n");
                }
                else
                {
                    Console.WriteLine("Masukkan lebar yang valid (bilangan positif).");
                }
            }
            else
            {
                Console.WriteLine("Masukkan panjang yang valid (bilangan positif).");
            }
        }
    }
}