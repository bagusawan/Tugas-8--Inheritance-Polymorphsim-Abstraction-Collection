using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "999 999 999";
            karyawanTetap.Nama = "Bagus kurniawan";
            karyawanTetap.GajiBulanan = 7000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "888 888 888";
            karyawanHarian.Nama = "awan wow";
            karyawanHarian.JumlahJamKerja = 6;
            karyawanHarian.UpahPerJam = 15000;

            Sales sales = new Sales();
            sales.Nik = "777 777 777";
            sales.Nama = "bagus wow";
            sales.JumlahPenjualan = 50;
            sales.Komisi = 50000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
