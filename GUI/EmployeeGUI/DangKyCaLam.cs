using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3.View
{
    public partial class DangKyCaLam : Form
    {
        public DangKyCaLam()
        {
            InitializeComponent();
            NHANVIEN nv = QLTaiKhoan.Instance.GetUserByUserName();
            txtMaTK.Text = nv.maTK;
            txtTenNV.Text = nv.tenNV;
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvDSCT.Rows.Count; i++)
            {
                dtgvDSCT.Rows[i - 1].Cells[0].Value = i;
            }
        }
        public void ShowAllCaLam(string ngayLam)
        {
            dtgvDSCT.Columns["maTK"].Visible = false;
            dtgvDSCT.Columns["tenNV"].Visible = false;
            dtgvDSCT.Columns["thoiGianDangKy"].Visible = false;
            dtgvDSCT.Columns["soLuong"].Visible = true;
            dtgvDSCT.Columns["trangThai"].Visible = true;
            dtgvDSCT.AutoGenerateColumns = false;
            dtgvDSCT.DataSource = QLCaLamBLL.Instance.GetAllCaLam(ngayLam);
            SetSTT();
        }
        public void ShowCaLamPC(string ngayLam, string maTK)
        {
            dtgvDSCT.Columns["maTK"].Visible = true;
            dtgvDSCT.Columns["tenNV"].Visible = true;
            dtgvDSCT.Columns["thoiGianDangKy"].Visible = true;
            dtgvDSCT.Columns["soLuong"].Visible = false;
            dtgvDSCT.Columns["trangThai"].Visible = false;
            dtgvDSCT.AutoGenerateColumns = false;
            dtgvDSCT.DataSource = QLCaLamBLL.Instance.GetCaLamPC(ngayLam, maTK);
            SetSTT();
        }
        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btDangKy_Click(object sender, EventArgs e)
        {
            if (txtCT.Text == "")
            {
                MessageBox.Show("Vui lòng chọn ca làm cần đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              
                string MaCT = txtCT.Text;
                DateTime ngayLam = QLCaLamBLL.Instance.GetCaLamByMa(MaCT).ngayLam.Date;
                TimeSpan gioLam = QLCaLamBLL.Instance.GetCaLamByMa(MaCT).gioBatDau;
                string MaTK = QLTaiKhoan.Instance.GetUserByUserName().maTK;
                if (ngayLam < DateTime.Now.Date || gioLam < DateTime.Now.TimeOfDay)
                {
                    MessageBox.Show("Hết thời gian đăng ký ca làm này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (QLCaLamBLL.Instance.CheckDaDK(MaCT, MaTK))
                {
                    MessageBox.Show("Bạn đã đăng ký ca làm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!QLCaLamBLL.Instance.CheckSoLuong(MaCT))
                {
                    MessageBox.Show("Ca làm này đã đủ số lượng. Vui lòng chọn ca khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!QLCaLamBLL.Instance.CheckSLToiDa(ngayLam, MaTK))
                {
                    MessageBox.Show("Bạn đã đăng ký đủ số lượng ca làm trong ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                else
                {
                    PHANCONGCALAM pc = new PHANCONGCALAM
                    {
                        maCT = MaCT,
                        maTK = MaTK,
                        thoiGianDangKy = DateTime.Now
                    };
                    QLCaLamBLL.Instance.DangKyCaLam(pc);
                    QLCaLamBLL.Instance.SetTrangThai(MaCT);
                    MessageBox.Show("Đăng ký ca làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    private void btnHuyDK_Click(object sender, EventArgs e)
    {
        if (dtgvDSCT.SelectedRows.Count > 0)
        {
            if ((MessageBox.Show("Bạn chắc chắn muốn hủy!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
            {
                string mact = dtgvDSCT.SelectedRows[0].Cells["maCT"].Value.ToString();
                DateTime ngayLam = QLCaLamBLL.Instance.GetCaLamByMa(mact).ngayLam.Date;
                string maTK = QLTaiKhoan.Instance.GetUserByUserName().maTK;
                if (!QLCaLamBLL.Instance.CheckHuyCaLam(mact,maTK) || ngayLam < DateTime.Now.Date)
                {
                    MessageBox.Show("Vui lòng chọn đúng ca làm của bạn hoặc thời gian ca làm hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    QLCaLamBLL.Instance.HuyCaLam(mact, maTK);
                    MessageBox.Show("Hủy ca làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn ca làm cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
   
    private void DangKyCaLam_Load(object sender, EventArgs e)
    {
        SetSTT();
    }

    private void btnWork_Click(object sender, EventArgs e)
    {
        string ngayLam = dtmNgaylam.Value.Date.ToString("dd/MM/yyyy");
        string tenDN = QLTaiKhoan.Instance.TenDangNhap;
        string maTK = QLTaiKhoan.Instance.GetAllAccount(tenDN)[0].maTK;
        ShowCaLamPC(ngayLam, maTK);
    }

    private void dtmNgaylam_ValueChanged(object sender, EventArgs e)
    {
        string ngayLam = dtmNgaylam.Value.Date.ToString("dd/MM/yyyy");
        ShowAllCaLam(ngayLam);
    }

     private void dtgvDSCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDSCT.SelectedRows.Count > 0)
            {
                txtCT.Text = dtgvDSCT.SelectedRows[0].Cells["maCT"].Value.ToString();
                dtmNgaylam.Value = Convert.ToDateTime(dtgvDSCT.SelectedRows[0].Cells["ngayLam"].Value.ToString());
                dtmGiobatdau.Value = Convert.ToDateTime(dtgvDSCT.SelectedRows[0].Cells["gioBatDau"].Value.ToString());
                dtmGioketthuc.Value = Convert.ToDateTime(dtgvDSCT.SelectedRows[0].Cells["gioKetThuc"].Value.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

