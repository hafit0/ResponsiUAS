using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi\n\n1. Tambah Penjualan\n2. Hapus Penjualan\n3. Tampilkan Penjualan\n4. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();
            Console.WriteLine("Tambah Data Penjualan\n");
            Console.Write("Nota: ");
            penjualan.Nota= Console.ReadLine();
            Console.Write("Tanggal: ");
            penjualan.Tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            penjualan.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            penjualan.Jenis = Console.ReadLine();
            Console.Write("Total Nota: ");
            penjualan.TotaL = Convert.ToInt32(Console.ReadLine());

            daftarPenjualan.Add(penjualan);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            bool ketemu = true;
            Console.WriteLine("Hapus Data Penjuala\n");
            Console.Write("Nota: ");
            string nota = Console.ReadLine();
            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                if (nota == daftarPenjualan[i].Nota)
                {
                    daftarPenjualan.Remove(daftarPenjualan[i]);
                    ketemu = true;
                    break;
                }
                else
                {
                    ketemu = false;
                }
            }

            if (!ketemu)
            {
                Console.WriteLine("\nData Penjualan tidak ditemukan");
            }
            else
            {
                Console.WriteLine("\nData Penjualan Berhasil Dihapus");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            
            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int no = 0;
            Console.WriteLine("Data Penjualan\n");
            
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                string jenis= "0";
                if (penjualan.Jenis=="T" || penjualan.Jenis == "t")
                {
                    jenis = "Tunai";
                    
                }else if (penjualan.Jenis == "K" || penjualan.Jenis == "k")
                {
                   jenis = "Kredit";
                };
                no++;
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", no, penjualan.Nota, penjualan.Tanggal, penjualan.Customer, jenis, penjualan.TotaL);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
