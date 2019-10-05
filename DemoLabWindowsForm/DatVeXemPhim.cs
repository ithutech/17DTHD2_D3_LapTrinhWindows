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

namespace DemoLabWindowsForm
{
    public partial class frmDatVeXemPhim : Form
    {
        List<Button> dsChon;
        DatVeOnlineContext dbContext;
        List<Ghe> danhSachGhe;
        public frmDatVeXemPhim()
        {
            InitializeComponent();
            dsChon = new List<Button>();
            dbContext = new DatVeOnlineContext();
            LoadThongTinGheGiaVe();
            LoadThongTinGheDaMua();
        }

        private void LoadThongTinGheDaMua()
        {
            //Lay danh sach tat ca cac nut tren form
            List<Button> dsGhe = this.Controls.OfType<Button>().ToList();
            Button btnGhe;
            foreach (Ghe ghe in danhSachGhe)
            {
                if(ghe.ChiTietHoaDons.Count >0)
                {
                    btnGhe = dsGhe.Where(x => x.Text == ghe.TenGhe).FirstOrDefault<Button>();
                    btnGhe.BackColor = Color.Yellow;
                }
            }
        }

        private void LoadThongTinGheGiaVe()
        {
            danhSachGhe = dbContext.Ghes.Include("HangGhe").Include("ChiTietHoaDons").ToList();
        }

        private void btnChonVe_Click(object sender, EventArgs e)
        {
            Button veChon = (Button)sender;
            if(veChon.BackColor == Color.White)
            {
                veChon.BackColor = Color.Blue;
                dsChon.Add(veChon);
            }
            else if(veChon.BackColor == Color.Blue)
            {
                veChon.BackColor = Color.White;
                dsChon.Remove(veChon);
            }
            else
            {
                MessageBox.Show("Ve nay khong con trong!", "Thong bao");
            }

            double tienVe = TinhTienVe();
            txtThanhTien.Text = tienVe.ToString();
        }

        private double TinhTienVe()
        {
            double tongTien = 0;
            //tinh tien dsChon trong danhSachGhe
            foreach (var ve in dsChon)
            {
                tongTien += danhSachGhe.Where(x => x.TenGhe == ve.Text).FirstOrDefault<Ghe>().HangGhe.GiaVe;
            }
            return tongTien;
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
            //Luu thong tin mua ve
            //B1. Luu khach hang
            KhachHang khachHang = new KhachHang { TenKhachHang = txtKhachHang.Text };
            dbContext.KhachHangs.Add(khachHang);
            //B2. Luu Hoa Don
            HoaDon hoaDon = new HoaDon {KhachHangId = khachHang.KhachHangId, NgayDatVe = DateTime.Now};
            dbContext.HoaDons.Add(hoaDon);
            //B3. Luu Chi Tiet
            int gheId;
            foreach (var ve in dsChon)
            {
                gheId = dbContext.Ghes.Where(x => x.TenGhe == ve.Text).FirstOrDefault<Ghe>().GheId;
                dbContext.ChiTietHoaDons.Add(new ChiTietHoaDon {HoaDonId = hoaDon.HoadonId, GheId = gheId});
                ve.BackColor = Color.Yellow;
            }
            dbContext.SaveChanges();
            dsChon.Clear();
            txtKhachHang.Text = "";
            txtThanhTien.Text = "";
        }

        private void btnChonVe_Hover(object sender, EventArgs e)
        {
            Button veChon = (Button)sender;
            int soGhe = int.Parse(veChon.Text);
            int giaVe = 0;
            if (soGhe <= 5)
                giaVe = 50000;
            else if (soGhe <= 10)
                giaVe = 70000;
            else
                giaVe = 90000;

            totGiaGhe.SetToolTip(veChon, giaVe.ToString());
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
