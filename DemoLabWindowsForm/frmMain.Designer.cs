namespace DemoLabWindowsForm
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.hỆTHỐNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.tHOÁTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNTRỊHỆTHỐNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBanVe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hỆTHỐNGToolStripMenuItem,
            this.qUẢNTRỊHỆTHỐNGToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1127, 33);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // hỆTHỐNGToolStripMenuItem
            // 
            this.hỆTHỐNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangNhap,
            this.tHOÁTToolStripMenuItem});
            this.hỆTHỐNGToolStripMenuItem.Name = "hỆTHỐNGToolStripMenuItem";
            this.hỆTHỐNGToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.hỆTHỐNGToolStripMenuItem.Text = "HỆ THỐNG";
            // 
            // menuDangNhap
            // 
            this.menuDangNhap.Name = "menuDangNhap";
            this.menuDangNhap.Size = new System.Drawing.Size(270, 34);
            this.menuDangNhap.Text = "ĐĂNG NHẬP";
            this.menuDangNhap.Click += new System.EventHandler(this.MenuDangNhap_Click);
            // 
            // tHOÁTToolStripMenuItem
            // 
            this.tHOÁTToolStripMenuItem.Name = "tHOÁTToolStripMenuItem";
            this.tHOÁTToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.tHOÁTToolStripMenuItem.Text = "THOÁT";
            // 
            // qUẢNTRỊHỆTHỐNGToolStripMenuItem
            // 
            this.qUẢNTRỊHỆTHỐNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBanVe,
            this.menuHoaDon,
            this.menuKhachHang});
            this.qUẢNTRỊHỆTHỐNGToolStripMenuItem.Name = "qUẢNTRỊHỆTHỐNGToolStripMenuItem";
            this.qUẢNTRỊHỆTHỐNGToolStripMenuItem.Size = new System.Drawing.Size(202, 29);
            this.qUẢNTRỊHỆTHỐNGToolStripMenuItem.Text = "QUẢN TRỊ HỆ THỐNG";
            // 
            // menuBanVe
            // 
            this.menuBanVe.Name = "menuBanVe";
            this.menuBanVe.Size = new System.Drawing.Size(270, 34);
            this.menuBanVe.Text = "BÁN VÉ";
            // 
            // menuHoaDon
            // 
            this.menuHoaDon.Name = "menuHoaDon";
            this.menuHoaDon.Size = new System.Drawing.Size(270, 34);
            this.menuHoaDon.Text = "HÓA ĐƠN";
            // 
            // menuKhachHang
            // 
            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Size = new System.Drawing.Size(270, 34);
            this.menuKhachHang.Text = "KHÁCH HÀNG";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 686);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "frmMain";
            
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem hỆTHỐNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem tHOÁTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNTRỊHỆTHỐNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBanVe;
        private System.Windows.Forms.ToolStripMenuItem menuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHang;
    }
}