using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLabWindowsForm.Entities
{
    class DatVeOnlineContext : DbContext
    {
        public DatVeOnlineContext(): base("DatVeOnline17DTHD2D3")
        {
            
        }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Ghe> Ghes { get; set; }
        public DbSet<HangGhe> HangGhes { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
    }
}
