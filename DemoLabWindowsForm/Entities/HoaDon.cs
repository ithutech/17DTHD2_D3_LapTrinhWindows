using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLabWindowsForm.Entities
{
    class HoaDon
    {
        public int HoadonId { get; set; }
        public int KhachHangId { get; set; }
        public DateTime NgayDatVe { get; set; }

        public virtual KhachHang KhachHang { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
