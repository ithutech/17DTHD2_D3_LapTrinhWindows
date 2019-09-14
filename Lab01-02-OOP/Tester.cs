using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02_OOP
{
    class Tester
    {
        static void Main(string[] args)
        {
            //Console.Write("Tong so Nguoi = ");
            //int soLuong = int.Parse(Console.ReadLine());
            List<Nguoi> danhSach = new List<Nguoi>();
            Nguoi nguoi;
            int chon;
            List<GiangVien> danhSachGiangVien;
            List<SinhVien> danhSachSinhVien;
            do
            {
                //Chon doi tuong can nhap
                Console.WriteLine("1. Nhap SV");
                Console.WriteLine("2. Nhap GV");
                Console.WriteLine("3. Xuat SV");
                Console.WriteLine("4. Xuat GV");
                Console.WriteLine("5. Danh sach sinh vien co diem Max thuoc CNTT");
                Console.WriteLine("0. Thoat");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nguoi = new SinhVien();
                        nguoi.Nhap();
                        danhSach.Add(nguoi);
                        break;
                    case 2:
                        nguoi = new GiangVien();
                        nguoi.Nhap();
                        danhSach.Add(nguoi);
                        break;
                    case 3:
                        //Xuat danh sach sinh vien
                        danhSachSinhVien = danhSach.OfType<SinhVien>().ToList();
                        foreach (var item in danhSachSinhVien)
                        {
                            item.Xuat();
                        }
                        break;
                    case 4:
                        //Xuat danh sach giang vien
                        danhSachGiangVien = danhSach.OfType<GiangVien>().ToList();
                        foreach (var item in danhSachGiangVien)
                        {
                            item.Xuat();
                        }
                        break;
                    case 5:
                        List<SinhVien> danhSachSinhVienCNTT = danhSach.OfType<SinhVien>().Where(p=>p.Khoa == "cntt").ToList();

                        float maxScore = danhSachSinhVienCNTT.Max(p => p.DiemTrungBinh);

                        List<SinhVien> danhSachSVDiemCaoNhatKhoaCNTT = danhSachSinhVienCNTT.Where(p => p.DiemTrungBinh == maxScore ).ToList();
                        //xuat
                        foreach (var item in danhSachSVDiemCaoNhatKhoaCNTT)
                        {
                            item.Xuat();
                        }
                        break;
                    default:
                        break;
                }

            } while (chon!=0);
           
            Console.Read();
        }
    }
}
