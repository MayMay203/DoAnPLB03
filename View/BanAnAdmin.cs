using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
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
    public partial class BanAnAdmin : Form
    {
        public BanAnAdmin()
        {
            InitializeComponent();
            ShowAllBABy("Tất cả", "");
            SetCBB();
        }

        public void ShowAllBABy(string trangThai, string soGhe)
        {
            dtgvBanan.DataSource = QLBABLL.Instance.GetAllBABy(trangThai, soGhe);
            SetSTT();
        }
        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlBanan.Controls.Add(form);
            pnlBanan.Controls.SetChildIndex(form, 0);
            form.Show();
        }

        public void SetCBB()
        {
            foreach(string trangThai in QLBABLL.Instance.GetTTBA())
            {
                cbbTrangThai.Items.Add(trangThai);
            }    
        }

        public void SetSTT()
        {
            for (int i = 1; i <= dtgvBanan.Rows.Count; i++)
            {
                dtgvBanan.Rows[i - 1].Cells[0].Value = i;
            }
        }

        private void BanAnAdmin_Load(object sender, EventArgs e)
        {
            SetSTT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXemlichsudatban_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new XemLichSuDatBanAdmin());
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string trangThai = txtTimkiem.Text;
            ShowAllBABy(trangThai, "");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbbTrangThai.SelectedIndex = 2;
            BANAN ba = new BANAN()
            {
                soGhe = Convert.ToInt32(txtSoghe.Text),
                trangThai = cbbTrangThai.SelectedItem.ToString(),
                ghiChu = txtGhichu.Text
            };
            QLBABLL.Instance.Add(ba);
            ShowAllBABy("Tất cả", "");
        }

        private void dtgvBanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaban.Text = dtgvBanan.SelectedRows[0].Cells["maBan"].Value.ToString();
            txtSoghe.Text = dtgvBanan.SelectedRows[0].Cells["soGhe"].Value.ToString();
            cbbTrangThai.SelectedIndex = cbbTrangThai.Items.IndexOf(dtgvBanan.SelectedRows[0].Cells["trangThai"].Value.ToString());
            txtGhichu.Text = dtgvBanan.SelectedRows[0].Cells["ghiChu"].Value.ToString();
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (dtgvBanan.SelectedRows.Count == 1)
            {
                BANAN ba = new BANAN()
                {
                    maBan = txtMaban.Text,
                    soGhe = Convert.ToInt32(txtSoghe.Text),
                    trangThai = cbbTrangThai.SelectedItem.ToString(),
                    ghiChu = txtGhichu.Text
                };
                QLBABLL.Instance.Update(ba);
                ShowAllBABy("Tất cả", "");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimkiem.Text = cbbTrangThai.SelectedItem.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn xóa bàn ăn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                if (dtgvBanan.SelectedRows.Count > 0)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow dr in dtgvBanan.SelectedRows)
                    {
                        list.Add(dr.Cells["maBan"].Value.ToString());
                    }
                    foreach (string maBan in list)
                    {
                        QLBABLL.Instance.Delete(maBan);
                    }
                    ShowAllBABy("Tất cả", "");
                }
                else
                {
                    MessageBox.Show("Chọn 1 bàn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
