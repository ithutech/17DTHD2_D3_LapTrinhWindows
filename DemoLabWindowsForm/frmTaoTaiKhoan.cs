using DemoLabWindowsForm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLabWindowsForm.Utils;

namespace DemoLabWindowsForm
{
    public partial class frmTaoTaiKhoan : Form
    {
        DatVeOnlineContext dbContext;
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
            dbContext = new DatVeOnlineContext();
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.Name = txtName.Text;
            taiKhoan.Pass = MD5Demo.GetMD5HashData(txtPass.Text);
            dbContext.TaiKhoans.Add(taiKhoan);
            dbContext.SaveChanges();
            MessageBox.Show("Tai tai khoan thanh cong!");
        }
    }
}
