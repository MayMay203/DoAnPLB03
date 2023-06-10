using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
using DoAnPBL3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DoAnPBL3
{
    public partial class QuanLyThucDon : Form
    {
        public QuanLyThucDon()
        {
            InitializeComponent();
            SetCBB();
            cbbTenLM.SelectedIndex = 0;
            ShowAllMABy("Tất cả");
        }

        public void SetCBB()
        {
            cbbTenLM.Items.Add(new CBBItem { value = "0", text = "Tất cả" });
            foreach (LOAIMON LM in QLThucDon.Instance.GetAllLMA())
            {
                cbbTenLM.Items.Add(new CBBItem { value = LM.maLM, text = LM.tenLM });
            }
        }
        public void SetSTT()
        {
            for (int i = 1; i <= dtgvMonan.Rows.Count; i++)
            {
                dtgvMonan.Rows[i - 1].Cells[0].Value = i;
            }
        }

        public void ShowAllMABy(string tenLM)
        {
            dtgvMonan.AutoGenerateColumns = false;
            dtgvMonan.DataSource = QLThucDon.Instance.GetAllMABy(tenLM);
            SetSTT();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaMA.Text = "";
            txtTenMA.Text = "";
            txtDonGia.Text = "";
            txtDVT.Text = "";
            cbbTenLM.Text = "";
            picAnh.Image = null;
        }

        private void ThucDonAdmin_Load(object sender, EventArgs e)
        {
            SetSTT();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLM.Text == "0")
                {
                    MessageBox.Show("Chọn loại món không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtTenMA.Text == "" || txtDVT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool check = true;
                    foreach (MONAN ma in QLThucDon.Instance.GetAllMABy("Tất cả"))
                    {
                        if (ma.tenMA == txtTenMA.Text)
                        {
                            MessageBox.Show("Món ăn đã có sẵn trong thực đơn vui lòng thêm món ăn khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        MONAN monan = new MONAN
                        {
                            tenMA = txtTenMA.Text,
                            maLM = ((CBBItem)cbbTenLM.SelectedItem).value,
                            donViTinh = txtDVT.Text,
                            giaMA = Convert.ToDouble(txtDonGia.Text),
                            anhMA = Convert_Image.ConvertByte(picAnh.Image),
                            coXoa = false

                        };
                        QLThucDon.Instance.Add(monan);
                        string TenLM = ((CBBItem)cbbTenLM.SelectedItem).text;
                        ShowAllMABy(TenLM);
                    }

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
                if (txtMaLM.Text == "0")
                {
                    MessageBox.Show("Chọn loại món không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (string.IsNullOrEmpty(txtTenMA.Text) || string.IsNullOrEmpty(txtDVT.Text) || string.IsNullOrEmpty(txtDonGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dtgvMonan.SelectedRows.Count == 1)
                    {
                        MONAN monAn = new MONAN()
                        {
                            maMA = txtMaMA.Text,
                            tenMA = txtTenMA.Text,
                            donViTinh = txtDVT.Text,
                            giaMA = Convert.ToDouble(txtDonGia.Text),
                            maLM = ((CBBItem)cbbTenLM.SelectedItem).value,
                            anhMA = Convert_Image.ConvertByte(picAnh.Image),
                        };
                        QLThucDon.Instance.Update(monAn);
                        string TenLM = ((CBBItem)cbbTenLM.SelectedItem).text;
                        ShowAllMABy(TenLM);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một món ăn để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin không hợp lệ.\nVui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa món ăn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                List<string> maDel = new List<string>();
                foreach (DataGridViewRow dr in dtgvMonan.SelectedRows)
                {
                    maDel.Add(dr.Cells["maMA"].Value.ToString());
                }
                foreach (string maMA in maDel)
                {
                    QLThucDon.Instance.Delete(maMA);
                }
                string TenLM = ((CBBItem)cbbTenLM.SelectedItem).text;
                ShowAllMABy(TenLM);
            }
        }

        private void dtgvMonan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLM.Text = dtgvMonan.SelectedRows[0].Cells["maLM"].Value.ToString();
            foreach (dynamic item in cbbTenLM.Items)
            {
                if (item.value == txtMaLM.Text)
                    cbbTenLM.SelectedItem = item;
            }
            txtMaMA.Text = dtgvMonan.SelectedRows[0].Cells["maMA"].Value.ToString();
            txtDVT.Text = dtgvMonan.SelectedRows[0].Cells["donViTinh"].Value.ToString();
            txtDonGia.Text = Convert.ToDouble(dtgvMonan.SelectedRows[0].Cells["giaMA"].Value).ToString("#,###");
            txtTenMA.Text = dtgvMonan.SelectedRows[0].Cells["tenMA"].Value.ToString();
            if (dtgvMonan.SelectedRows[0].Cells["anhMA"].Value != null)
            {
                byte[] imageBytes = (byte[])dtgvMonan.SelectedRows[0].Cells["anhMA"].Value;
                picAnh.Image = Convert_Image.ConvertImage(imageBytes);
            }
            else
            {
                picAnh.Image = null;
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ẢNH PBL (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                picAnh.Image = Image.FromFile(path);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string txt = ((CBBItem)cbbTenLM.SelectedItem).text;
            ShowAllMABy(txt);
        }

        private void cbbTenLM_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaLM.Text = ((CBBItem)cbbTenLM.SelectedItem).value;
        }
    }
}
