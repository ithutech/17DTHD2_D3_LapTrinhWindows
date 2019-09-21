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
        public frmDatVeXemPhim()
        {
            InitializeComponent();
            dsChon = new List<Button>();
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
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
            double tongTien = 0;
            foreach (var ve in dsChon)
            {
                int soGhe = int.Parse(ve.Text);
                if (soGhe <= 5)
                    tongTien += 50000;
                else if (soGhe <= 10)
                    tongTien += 70000;
                else
                    tongTien += 90000;
                ve.BackColor = Color.Yellow;
            }
            //txtThanhTien.Text = tongTien.ToString();

            txtThanhTien.Text = chkDonHoaDon.Checked ? (tongTien + double.Parse(txtThanhTien.Text)).ToString() : tongTien.ToString();

            dsChon.Clear();
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
    }
}
