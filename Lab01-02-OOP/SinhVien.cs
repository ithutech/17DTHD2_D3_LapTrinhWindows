using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02_OOP
{
    class SinhVien : Nguoi
    {
        private int maSo;
        
        private float diemTrungBinh;
        private string khoa;

        public int MaSo { get => maSo; set => maSo = value; }
        
        public float DiemTrungBinh { get => diemTrungBinh; set => diemTrungBinh = value; }
        public string Khoa { get => khoa; set => khoa = value; }

        public SinhVien()
        {

        }

        public SinhVien(int maSo, string hoTen, float diemTrungBinh, string khoa)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.diemTrungBinh = diemTrungBinh;
            this.khoa = khoa;
        }

        public override void Nhap()
        {
            Console.WriteLine("--- Thong tin SV ---");
            Console.Write("Ma so = ");
            this.maSo = int.Parse(Console.ReadLine());
            base.Nhap();
            Console.Write("Diem = ");
            this.diemTrungBinh = float.Parse(Console.ReadLine());
            Console.Write("Khoa = ");
            this.khoa = Console.ReadLine();
        }

        public override void Xuat()
        {
            Console.WriteLine("Ma so = {0}", this.maSo);
            base.Xuat();
            Console.WriteLine("Diem = {0}", this.diemTrungBinh);
            Console.WriteLine("Khoa = {0}", this.khoa);
        }

       
    }
}
