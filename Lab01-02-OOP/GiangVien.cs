using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02_OOP
{
    class GiangVien : Nguoi
    {
        private int maSo;
        private string diaChi;

        public int MaSo { get => maSo; set => maSo = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public override void Nhap()
        {
            Console.Write("Ma so = ");
            this.maSo = int.Parse(Console.ReadLine());
            base.Nhap();
            Console.Write("Dia chi = ");
            this.diaChi = Console.ReadLine();
        }

        public override void Xuat()
        {
            Console.WriteLine("Ma so = {0}", this.maSo);
            base.Xuat();
            Console.WriteLine("Dia chi = {0}", this.diaChi);
        }
    }
}
