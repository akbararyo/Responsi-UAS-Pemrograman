using System;
using System.Collections.Generic;
using System.Linq;

namespace UAS_pemrog
{
    class Program
    {
        static List<Produk> listProduk = new List<Produk>();

        static void Main(string[] args)
        {
            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4:
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar\n");
        }

        static void TambahProduk()
        {
            Console.Clear();
            Console.WriteLine("Tambahkan Data Produk\n");
            Produk produk = new Produk();
            Console.Write("Kode Produk : ");
            produk.Kode = Console.ReadLine();
            Console.Write("Nama Produk : ");
            produk.Nama = Console.ReadLine();
            Console.Write("Harga Beli : ");
            produk.HargaBeli = Console.ReadLine();
            Console.Write("Harga Jual : ");
            produk.HargaJual = Console.ReadLine();

            listProduk.Add(produk);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            Console.WriteLine("Hapus Data Produk\n");
            Console.Write("Kode Produk : ");
            string kode = Console.ReadLine();

            Produk deletePro = listProduk.SingleOrDefault(f => f.Kode == kode);
            if (listProduk.Contains(deletePro) == true)
            {
                listProduk.Remove(deletePro);
                Console.WriteLine("Data Produk Berhasil di hapus");
            }
            else
            {
                Console.WriteLine("Kode produk tidak ditemukan");
            }


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            Console.WriteLine("Data Produk\n");
            int nomor = 1;
            foreach (Produk produk in listProduk)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", nomor, produk.Kode, produk.Nama, produk.HargaBeli, produk.HargaJual);
                nomor++;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}