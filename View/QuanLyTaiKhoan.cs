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
using System.Net.NetworkInformation;
using DoAnPBL3.DTO;

namespace DoAnPBL3
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            SetCbbVaitro();
        }
        public void SetCbbVaitro()
        {
            cbbVaitro.Items.AddRange(new object[]
            {
                "1","0"
            });
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string txt = txtTimkiem.Text;
            dtgvQLTK.DataSource = QLTKBLL.Instance.GetAll_TaiKhoan(txt);
        }

        private void dtgvQLTK_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvQLTK.SelectedRows.Count > 0)
            {
                txtMaTK.Text = dtgvQLTK.SelectedRows[0].Cells["maTK"].Value.ToString();
                txtTendangnhap.Text = dtgvQLTK.SelectedRows[0].Cells["tenDangNhap"].Value.ToString();
                txtMathau.Text = dtgvQLTK.SelectedRows[0].Cells["matKhau"].Value.ToString();
                cbbVaitro.Text = Convert.ToInt32(dtgvQLTK.SelectedRows[0].Cells["vaiTro"].Value).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTendangnhap.Text) || string.IsNullOrEmpty(txtMathau.Text) || cbbVaitro.SelectedItem == null)
                {
                    MessageBox.Show("Thêm không thành công! Vui lòng nhập đầy đủ thông tin!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TAIKHOAN tk = new TAIKHOAN
                    {
                        maTK = txtMaTK.Text,
                        tenDangNhap = txtTendangnhap.Text,
                        matKhau = txtMathau.Text,
                        vaiTro = Convert.ToBoolean(cbbVaitro.SelectedItem.ToString() == "1" ? true : false),
                        coXoa = false
                    };
                    QLTKBLL.Instance.Add(tk);
                    MessageBox.Show("Thêm thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTendangnhap.Text) || string.IsNullOrEmpty(txtMathau.Text) || cbbVaitro.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dtgvQLTK.SelectedRows.Count > 0)
                    {
                        TAIKHOAN tk = new TAIKHOAN
                        {
                            maTK = txtMaTK.Text,
                            tenDangNhap = txtTendangnhap.Text,
                            matKhau = txtMathau.Text,
                            vaiTro = Convert.ToBoolean(cbbVaitro.SelectedItem.ToString() == "1" ? true : false)
                        };
                        QLTKBLL.Instance.Update(tk);
                        MessageBox.Show("Cập nhật thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một dòng để cập nhật!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn xóa!","Thông tin",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(dtgvQLTK.SelectedRows.Count > 0)
                {
                    string matk = dtgvQLTK.SelectedRows[0].Cells["maTK"].Value.ToString();
                    QLTKBLL.Instance.Delete(matk);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }
    }
}
