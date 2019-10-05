using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLabWindowsForm.Entities
{
    class KhachHang
    {
        public int KhachHangId { get; set; }
        public string TenKhachHang { get; set; }
        
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
