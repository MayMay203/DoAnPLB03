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
    public partial class QuanLyCaTruc : Form
    {
        public QuanLyCaTruc()
        {
            InitializeComponent();
            QLNH_DB db = new QLNH_DB();
            dtgvCatruc.DataSource = db.CHITIETCALAMs.Select(p => p).ToList();
            SetCBB();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
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
            DateTime ngaylam;
            if (DateTime.TryParseExact(dtmTimkiem.Value.ToString("dd/MM/yyyyy"), "dd/MM/yyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaylam))
            {
                dtgvCatruc.DataSource = QLCTBLL.Instance.GetAll_CaTruc(ngaylam);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ca trực nào cho ngày đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void dtgvCatruc_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvCatruc.SelectedRows.Count > 0)
            {
                txtMacatruc.Text = dtgvCatruc.SelectedRows[0].Cells["maCT"].Value.ToString();
                if (DateTime.TryParse(dtgvCatruc.SelectedRows[0].Cells["ngayLam"].Value.ToString(), CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaylam))
                {
                    dtmNgaylam.Value = ngaylam;
                }
                if (DateTime.TryParse(dtgvCatruc.SelectedRows[0].Cells["gioBatDau"].Value.ToString(), out DateTime giobatdau))
                {
                    dtmGiobatdau.Value = giobatdau;
                }
                if (DateTime.TryParse(dtgvCatruc.SelectedRows[0].Cells["gioKetThuc"].Value.ToString(), out DateTime gioketthuc))
                {
                    dtmGioketthuc.Value = gioketthuc;
                }
                txtSoluong.Text = Convert.ToInt32(dtgvCatruc.SelectedRows[0].Cells["soLuong"].Value).ToString();
                cbbTrangthai.Text = Convert.ToInt32(dtgvCatruc.SelectedRows[0].Cells["trangThai"].Value).ToString();
            }
            else return;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSoluong.Text) || cbbTrangthai.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CHITIETCALAM ct = new CHITIETCALAM
                    {
                        maCT = txtMacatruc.Text,
                        ngayLam = dtmNgaylam.Value,
                        gioBatDau = dtmGiobatdau.Value.TimeOfDay,
                        gioKetThuc = dtmGioketthuc.Value.TimeOfDay,
                        soLuong = Convert.ToInt32(txtSoluong.Text),
                        trangThai = Convert.ToBoolean(cbbTrangthai.SelectedItem.ToString() == "1" ? true : false)
                    };
                    QLCTBLL.Instance.Add(ct);
                    MessageBox.Show("Thêm thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try {
                if (dtgvCatruc.SelectedRows.Count > 0)
                {
                    if (string.IsNullOrEmpty(txtSoluong.Text) || cbbTrangthai.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CHITIETCALAM ct = new CHITIETCALAM
                        {
                            maCT = txtMacatruc.Text,
                            ngayLam = dtmNgaylam.Value,
                            gioBatDau = dtmGiobatdau.Value.TimeOfDay,
                            gioKetThuc = dtmGioketthuc.Value.TimeOfDay,
                            soLuong = Convert.ToInt32(txtSoluong.Text),
                            trangThai = Convert.ToBoolean(cbbTrangthai.SelectedItem.ToString() == "1" ? true : false)
                        };
                        QLCTBLL.Instance.Update(ct);
                        MessageBox.Show("Cập nhật thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để cập nhật!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa!", "Thông tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (dtgvCatruc.SelectedRows.Count > 0)
                    {
                        string mact = dtgvCatruc.SelectedRows[0].Cells[0].Value.ToString();
                        QLCTBLL.Instance.Delete(mact);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            
        }
    }
}
