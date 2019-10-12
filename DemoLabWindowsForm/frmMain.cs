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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
            SetControl(false);
            
        }

        private void SetControl(bool isUse)
        {
            menuBanVe.Enabled = isUse;
            menuKhachHang.Enabled = isUse;
            menuHoaDon.Enabled = isUse;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.loginSystemClick += Frm_loginSystemClick;
            frm.Show();
        }

        private void Frm_loginSystemClick(object sender, Utils.EventSetControlEnable e)
        {
            if (e.isUse)
            {
                SetControl(e.isUse);
                menuDangNhap.Enabled = false;
            }
        }

        private void MenuDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (ShowActiveChildForm(frm) == false)
            {
                frm.MdiParent = this;
                frm.loginSystemClick += Frm_loginSystemClick;
                frm.Show();
            }
            
        }

        private bool ShowActiveChildForm(Form frm)
        {
            foreach (Form formChild in this.MdiChildren)
            {
                if (formChild.Name == frm.Name)
                {
                    formChild.Activate();
                    return true;
                }
            }
            return false;
        }
    }
}
