using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
	
    class Program
    {
		
        static void Main(string[] args)
        {
			
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Collection";

            //membuat objek untuk semua karyawan
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "1308-1526-2226";
            karyawanTetap.Nama = "Byson LaMalikayen";
            karyawanTetap.GajiBulanan = 6000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "1308-1526-1222";
            karyawanHarian.Nama = "Sean Fikilati";
            karyawanHarian.JumlahJamKerja = 6;
            karyawanHarian.UpahPerJam = 50000;

            Sales sales = new Sales();
            sales.Nik = "1308-1526-3227";
            sales.Nama = "Aisyilla Hanara";
            sales.JumlahPenjualan = 30;
            sales.Komisi =120000;

            //objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrurt = 1;

            foreach(Karyawan karyawan in listKaryawan)
            {
				
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}",
                    noUrurt, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrurt++;
				
            }

            Console.ReadKey();
			
        }
		
    }
	
}