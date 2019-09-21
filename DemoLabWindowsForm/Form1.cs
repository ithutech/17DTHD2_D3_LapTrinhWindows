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
    public partial class Form1 : Form
    {
        string msgError;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            float soA = 0;
            float soB = 0;
            if (ValidateInput(out soA, out soB))
            {
                float ketQua = 0;
                
                //B1. Chuyen doi sender thanh button
                Button btnPhepTinh = (Button)sender;
                switch (btnPhepTinh.Name)
                {
                    case "btnCong":
                        ketQua = soA + soB;
                        break;
                    case "btnTru":
                        ketQua = soA - soB;
                        break;
                    case "btnNhan":
                        ketQua = soA * soB;
                        break;
                    case "btnChia":
                        ketQua = soA / soB;
                        break;
                    default:
                        break;
                }
                txtKetQua.Text = ketQua.ToString();
            }
            else
            {
                MessageBox.Show(msgError);
            }

        }

        private bool ValidateInput(out float soA, out float soB)
        {
            msgError = "";
            if (!float.TryParse(txtSoA.Text, out soA))
            {
                msgError = "So A khong hop le!";
            }
            if (!float.TryParse(txtSoB.Text, out soB))
            {
                msgError += "\nSo B khong hop le!";
            }
            return msgError == "" ? true : false;
        }
    }
}
