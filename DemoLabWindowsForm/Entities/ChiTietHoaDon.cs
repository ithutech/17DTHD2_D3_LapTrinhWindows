using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLabWindowsForm.Entities
{
    class ChiTietHoaDon
    {
        public int ChiTietHoaDonId { get; set; }
        public int HoaDonId { get; set; }
        public int GheId { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual Ghe Ghe { get; set; }
    }
}
