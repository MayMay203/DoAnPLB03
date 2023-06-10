using DoAnPBL3.View;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class UINhaHangNhanVien : Form
    {
       
        public UINhaHangNhanVien()
        {
            InitializeComponent();
            ShowForminPanel(new UI());
            pnlUI.Hide();
        }

        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlDeskTop.Controls.Add(form);
            this.pnlDeskTop.Controls.SetChildIndex(form, 0);
            form.Show();
        }
     
        public void ShowPanel(Guna2Button btn)
        {
            pnlUI.Height = btn.Height;
            pnlUI.Top = btn.Top;
            pnlUI.Show();
        }    
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ShowPanel( btnTrangChu);
            ShowForminPanel(new TrangChuNhanVien());
        }
        private void btnBanAn_Click(object sender, EventArgs e)
        {
            ShowPanel(btnBanAn);
            ShowForminPanel(new View.BanAn());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ShowPanel(btnHoaDon);
            ShowForminPanel(new QuanLyHoaDon());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ShowPanel(btnKhachHang);
            ShowForminPanel(new View.KhachHang());
        }

        private void btnCaLV_Click(object sender, EventArgs e)
        {
            ShowPanel(btnCaLV);
            ShowForminPanel(new CaLamViec());
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            ShowPanel(btnThucDon);
            ShowForminPanel(new ThucDon());
        }
    }
}
