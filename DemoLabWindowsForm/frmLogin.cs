using DemoLabWindowsForm.Entities;
using DemoLabWindowsForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLabWindowsForm
{
    public partial class frmLogin : Form
    {
        public event LoginSystemClick loginSystemClick;
        DatVeOnlineContext dbContext;
        public frmLogin()
        {
            InitializeComponent();
            dbContext = new DatVeOnlineContext();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = dbContext.TaiKhoans.Where(x => x.Name == txtName.Text.Trim()).FirstOrDefault<TaiKhoan>();

            if (taiKhoan != null)
            {
                if (MD5Demo.ValidateMD5HashData(txtPass.Text, taiKhoan.Pass))
                {
                    EventSetControlEnable thongBao = new EventSetControlEnable();
                    thongBao.isUse = true;
                    loginSystemClick(this, thongBao);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mat khau khong dung!");
                }
            }
            else
            {
                MessageBox.Show("Khong ton tai tai khoan nay!");
            }
        }
    }
}
