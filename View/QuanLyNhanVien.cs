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
using TheArtOfDevHtmlRenderer.Adapters;
using DoAnPBL3.DTO;

namespace DoAnPBL3
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string txt = txtTimkiem.Text;
            dtgvNhanvien.DataSource = QLNVBLL.Instance.GetAll_NV(txt);
        }

        private void dtgvNhanvien_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvNhanvien.SelectedRows.Count > 0)
            {
                txtMaNV.Text = dtgvNhanvien.SelectedRows[0].Cells["maNV"].Value.ToString();
                txtMaTK.Text = dtgvNhanvien.SelectedRows[0].Cells["maTK"].Value.ToString();
                txtTenNV.Text = dtgvNhanvien.SelectedRows[0].Cells["tenNV"].Value.ToString();
                if (Convert.ToBoolean(dtgvNhanvien.SelectedRows[0].Cells["gioiTinh"].Value.ToString()))
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
                dtmNgaysinh.Value = Convert.ToDateTime(dtgvNhanvien.SelectedRows[0].Cells["ngaySinh"].Value);
                txtCCCD.Text = dtgvNhanvien.SelectedRows[0].Cells["CCCD"].Value.ToString();
                txtSDT.Text = dtgvNhanvien.SelectedRows[0].Cells["SDT"].Value.ToString();
                txtDiachi.Text = dtgvNhanvien.SelectedRows[0].Cells["diaChi"].Value.ToString();
                txtLuong.Text = Convert.ToDouble(dtgvNhanvien.SelectedRows[0].Cells["luong"].Value).ToString();
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaTK.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtDiachi.Text) || string.IsNullOrEmpty(txtLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    NHANVIEN nv = new NHANVIEN
                    {
                        maNV = txtMaNV.Text,
                        maTK = txtMaTK.Text,
                        tenNV = txtTenNV.Text,
                        gioiTinh = rdoNam.Checked ? true : false,
                        ngaySinh = dtmNgaysinh.Value,
                        CCCD = txtCCCD.Text,
                        SDT = txtSDT.Text,
                        diaChi = txtDiachi.Text,
                        luong = Convert.ToDouble(txtLuong.Text)
                        

                    };
                    
                    QLNVBLL.Instance.Add(nv);
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
            try
            {
                if (string.IsNullOrEmpty(txtMaTK.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtDiachi.Text) || string.IsNullOrEmpty(txtLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dtgvNhanvien.SelectedRows.Count > 0)
                    {
                        NHANVIEN nv = new NHANVIEN
                        {
                            maNV = txtMaNV.Text,
                            maTK = txtMaTK.Text,
                            tenNV = txtTenNV.Text,
                            gioiTinh = rdoNam.Checked ? true : false,
                            ngaySinh = dtmNgaysinh.Value,
                            CCCD = txtCCCD.Text,
                            SDT = txtSDT.Text,
                            diaChi = txtDiachi.Text,
                            luong = Convert.ToDouble(txtLuong.Text),
                            coXoa = false

                        };
                        QLNVBLL.Instance.Update(nv);
                        MessageBox.Show("Cập nhật thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn 1 dòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
