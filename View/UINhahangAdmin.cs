using System;
using DoAnPBL3.View;
using Guna.UI2.WinForms;
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
    public partial class UINhahangAdmin : Form
    {

        public UINhahangAdmin()
        {
            InitializeComponent();
            ShowForminPanel(new UI());
            pnlUI.Hide();
           
        }

        public void ShowForminPanel(object Form)
        {
            if (pnlDeskTop.Controls.Count > 0)
            {
                pnlDeskTop.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnlDeskTop.Controls.Add(form);
            form.Show();
        }


        //Quản lý
        private void btnQuanly_MouseEnter(object sender, EventArgs e)
        {
            pnlUI.Height = btnQuanly.Height;
            pnlUI.Top = btnQuanly.Top;
            pnlUI.Show();
            ((Guna2Button)sender).ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
        }
        private void contextMenuStrip2_MouseLeave(object sender, EventArgs e)
        {
            ((ContextMenuStrip)sender).Hide();
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new QuanLyNhanVien());
        }
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new QuanLyKhachHang());
        }
        private void quảnLýCaTrựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ShowForminPanel(new QuanLyCaTruc());
        }
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ShowForminPanel(new QuanLyTaiKhoan());
        }
 

        //Thống kê
        private void btnThongke_MouseEnter(object sender, EventArgs e)
        {
            pnlUI.Height = btnThongke.Height;
            pnlUI.Top = btnThongke.Top;
            pnlUI.Show();
            ((Guna2Button)sender).ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void contextMenuStrip3_MouseLeave(object sender, EventArgs e)
        {
            ((ContextMenuStrip)sender).Hide();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ShowForminPanel(new ThongKeDoanhThu());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new ThongKeKhachHang());
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ShowForminPanel(new ThongKeThucDon());
        }






        private void btnBanan_Click(object sender, EventArgs e)
        {
            pnlUI.Height = btnBanan.Height;
            pnlUI.Top = btnBanan.Top;
            pnlUI.Show();
            ShowForminPanel(new BanAnAdmin());
        }
        private void btnHoadon_Click(object sender, EventArgs e)
        {
            pnlUI.Height = btnHoadon.Height;
            pnlUI.Top = btnHoadon.Top;
            pnlUI.Show();
            ShowForminPanel(new HoaDonAdmin());
        }

     
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            pnlUI.Height = btnTrangchu.Height;
            pnlUI.Top = btnTrangchu.Top;
            pnlUI.Show();
            ShowForminPanel(new TrangChuAdmin());
          
        }

        private void btnThucdon_Click(object sender, EventArgs e)
        {
            pnlUI.Height = btnThucdon.Height;
            pnlUI.Top = btnThucdon.Top;
            pnlUI.Show();
           ShowForminPanel(new ThemMonAn());
        }

        private void btnQuanly_Click(object sender, EventArgs e)
        {
            pnlUI.Height = btnQuanly.Height;
            pnlUI.Top = btnQuanly.Top;
            pnlUI.Show();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            pnlUI.Height = btnThongke.Height;
            pnlUI.Top = btnThongke.Top;
            pnlUI.Show();
        }

    }
}
