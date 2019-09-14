using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17DTHD2_D3_LapTrinhWIndows
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.Write("Tong so SV = ");
            int soLuong = int.Parse(Console.ReadLine());
            List<SinhVien> danhSach = new List<SinhVien>();
            SinhVien sinhVien;
            for (int i = 0; i < soLuong; i++)
            {
                sinhVien = new SinhVien();
                sinhVien.Nhap();
                danhSach.Add(sinhVien);
            }
            Console.WriteLine("Danh sach sinh vien");
            foreach (var sv in danhSach)
            {
                sv.Xuat();
            }
            //Xuat sinh vien co Khoa = CNTT
            Console.WriteLine("Sinh Vien Khoa CNTT");
            foreach (var sv in danhSach)
            {
                if (string.Compare("cntt", sv.Khoa) == 0)
                {
                    sv.Xuat();
                }
            }
            danhSach.Sort();
            //Xuat sinh vien co diem tang dan
            Console.WriteLine("Sinh Vien Co Diem Tang Dan");
            foreach (var sv in danhSach)
            {
                sv.Xuat();
            }
            Console.Read();
        }
    }
}
