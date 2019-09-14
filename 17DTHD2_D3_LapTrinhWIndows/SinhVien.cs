using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17DTHD2_D3_LapTrinhWIndows
{
    class SinhVien : IComparable
    {
        private int maSo;
        private string hoTen;
        private float diemTrungBinh;
        private string khoa;

        public int MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
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

        public void Nhap()
        {
            Console.WriteLine("--- Thong tin SV ---");
            Console.Write("Ma so = ");
            this.maSo = int.Parse(Console.ReadLine());
            Console.Write("Ho ten = ");
            this.hoTen = Console.ReadLine();
            Console.Write("Diem = ");
            this.diemTrungBinh = float.Parse(Console.ReadLine());
            Console.Write("Khoa = ");
            this.khoa = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("Ma so = {0}", this.maSo);
            Console.WriteLine("Ho ten = {0}", this.hoTen);
            Console.WriteLine("Diem = {0}", this.diemTrungBinh);
            Console.WriteLine("Khoa = {0}", this.khoa);
        }

        public int CompareTo(object obj)
        {
            int iCompare = Convert.ToInt32(this.diemTrungBinh - (obj as SinhVien).diemTrungBinh);
            return iCompare;
        }
    }
}
