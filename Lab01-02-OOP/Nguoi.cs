using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02_OOP
{
    class Nguoi
    {
        protected string hoTen;
        public string HoTen { get => hoTen; set => hoTen = value; }

        public virtual void Nhap()
        {
            Console.Write("Ho ten = ");
            this.hoTen = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ho ten = {0}", this.hoTen);
        }
    }
}
