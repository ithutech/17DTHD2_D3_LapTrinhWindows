using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLabWindowsForm.Entities
{
    class HangGhe
    {
        public int HangGheId { get; set; }
        public float GiaVe { get; set; }
        public string TenHangGhe { get; set; }

        public virtual ICollection<Ghe> Ghes { get; set; }
    }
}
