using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLabWindowsForm.Entities
{
    class Ghe
    {
        public int GheId { get; set; }
        public string TenGhe { get; set; }
        public int HangGheId { get; set; }

        public virtual HangGhe HangGhe { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}

