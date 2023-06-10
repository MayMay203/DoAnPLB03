using System;
using DoAnPBL3.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
using System.Globalization;
using Microsoft.Win32;

namespace DoAnPBL3
{
    public partial class QuanLyCaLam : Form
    {
        public QuanLyCaLam()
        {
            InitializeComponent();
            ShowAllCT("");
            SetCBB();
        }

        public void SetSTT()
        {
            for (int i = 1; i <= dtgvCatruc.Rows.Count; i++)
            {
                dtgvCatruc.Rows[i - 1].Cells[0].Value = i;
            }
        }

        private void QuanLyCaTruc_Load(object sender, EventArgs e)
        {
            SetSTT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
        public void ShowAllCT(string date)
        {
            dtgvCatruc.AutoGenerateColumns = false;
            dtgvCatruc.DataSource = QLCaLamBLL.Instance.GetAllCaLam(date);
            SetSTT();
        }
        public void SetCBB()
        {
            cbbTrangthai.Items.AddRange(new object[]
            {
                "Tất cả", "1", "0"
            });
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string ngaylam = dtmTimkiem.Value.ToString("dd/MM/yyyy");
            ShowAllCT(ngaylam);
        }

        private void dtgvCatruc_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvCatruc.SelectedRows.Count > 0)
            {
                txtMaCT.Text = dtgvCatruc.SelectedRows[0].Cells["maCT"].Value.ToString();
                dtmNgaylam.Value = DateTime.Parse(dtgvCatruc.SelectedRows[0].Cells["ngayLam"].Value.ToString());
                dtmGiobatdau.Value = DateTime.Parse(dtgvCatruc.SelectedRows[0].Cells["gioBatDau"].Value.ToString());
                dtmGioketthuc.Value = DateTime.Parse(dtgvCatruc.SelectedRows[0].Cells["gioKetThuc"].Value.ToString());
                txtSoluong.Text = Convert.ToInt32(dtgvCatruc.SelectedRows[0].Cells["soLuong"].Value).ToString();
                cbbTrangthai.Text = Convert.ToInt32(dtgvCatruc.SelectedRows[0].Cells["trangThai"].Value).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtmNgaylam.Value.Date < DateTime.Now.Date || dtmGiobatdau.Value.TimeOfDay < DateTime.Now.TimeOfDay || dtmGiobatdau.Value.TimeOfDay > dtmGioketthuc.Value.TimeOfDay)
                {
                    MessageBox.Show("Thời gian ca làm không hợp lệ.\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CHITIETCALAM ct = new CHITIETCALAM
                    {
                        ngayLam = dtmNgaylam.Value,
                        gioBatDau = dtmGiobatdau.Value.TimeOfDay,
                        gioKetThuc = dtmGioketthuc.Value.TimeOfDay,
                        soLuong = Convert.ToInt32(txtSoluong.Text),
                        trangThai = false
                    };
                    QLCaLamBLL.Instance.Add(ct);
                    MessageBox.Show("Thêm ca làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllCT("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin không hợp lệ.\nVui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvCatruc.SelectedRows.Count == 1)
                {
                    if (dtmGiobatdau.Value.TimeOfDay > dtmGioketthuc.Value.TimeOfDay)
                    {
                        MessageBox.Show("Thời gian ca làm không hợp lệ.\nVui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CHITIETCALAM ct = new CHITIETCALAM
                        {
                            maCT = txtMaCT.Text,
                            ngayLam = dtmNgaylam.Value,
                            gioBatDau = dtmGiobatdau.Value.TimeOfDay,
                            gioKetThuc = dtmGioketthuc.Value.TimeOfDay,
                            soLuong = Convert.ToInt32(txtSoluong.Text),
                        };
                        QLCaLamBLL.Instance.Update(ct);
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllCT("");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một ca làm để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin không hợp lệ.\nVui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvCatruc.SelectedRows.Count > 0)
            {
                DialogResult kq = MessageBox.Show("Bạn chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                        List<string> maDel = new List<string>();
                        foreach (DataGridViewRow dr in dtgvCatruc.SelectedRows)
                        {
                            maDel.Add(dr.Cells["maCT"].Value.ToString());
                        }
                        foreach (string del in maDel)
                        {
                            QLCaLamBLL.Instance.Delete(del);
                        }
                        ShowAllCT("");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ca làm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaCT.Text = "";
            dtmNgaylam.Value = DateTime.Now;
            dtmGiobatdau.Value = DateTime.Now;
            dtmGioketthuc.Value = DateTime.Now;
            txtSoluong.Text = "";
            cbbTrangthai.Text = "";
        }
    }
}
