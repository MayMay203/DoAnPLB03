using DoAnPBL3.BLL;
using DoAnPBL3.DTO;
using DoAnPBL3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace DoAnPBL3
{
    public partial class ThemMonAn : Form
    {
        public ThemMonAn()
        {
            InitializeComponent();
            ShowAllMABy("Tất cả");
            SetCBB();
        }

        public void SetCBB()
        {
            cbbTenLM.Items.Add("Tất cả");
            foreach(string LM in QLTDBLL.Instance.GetAllTLM())
            {
                cbbTenLM.Items.Add(LM);
            }    
        }

        public void SetSTT()
        {
            for (int i = 1; i <= dtgvDSMA.Rows.Count; i++)
            {
                dtgvDSMA.Rows[i - 1].Cells[0].Value = i;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ShowAllMABy(string tenLM)
        {
            dtgvDSMA.DataSource = QLTDBLL.Instance.GetAllMABy(tenLM);
        }
        private void ThemMonAn_Load(object sender, EventArgs e)
        {
            SetSTT();
        }

        private void cbbTenLM_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTimkiem.Text = cbbTenLM.SelectedItem.ToString();
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tenLM = txtTimkiem.Text;
            ShowAllMABy(tenLM);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MONAN monan = new MONAN()
            {
                tenMA = txtTenmonan.Text,
                GiaMA = Convert.ToDouble(txtGia.Text),
                donViTinh = txtDonvitinh.Text,
                maLM = QLTDBLL.Instance.GetMaLMByTLM(cbbTenLM.SelectedItem.ToString())
            };
            QLTDBLL.Instance.Add(monan);
            ShowAllMABy("Tất cả");
        }

        private void dtgvDSMA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMamonan.Text = dtgvDSMA.SelectedRows[0].Cells["maMA"].Value.ToString();
            txtTenmonan.Text = dtgvDSMA.SelectedRows[0].Cells["tenMA"].Value.ToString();
            txtGia.Text = dtgvDSMA.SelectedRows[0].Cells["GiaMA"].Value.ToString();
            txtDonvitinh.Text = dtgvDSMA.SelectedRows[0].Cells["donViTinh"].Value.ToString();
            cbbTenLM.SelectedIndex = cbbTenLM.Items.IndexOf(QLTDBLL.Instance.GetTLMByMaLM(dtgvDSMA.SelectedRows[0].Cells["maLM"].Value.ToString()));
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if(dtgvDSMA.SelectedRows.Count == 1)
            {
                MONAN ma = new MONAN()
                {
                    maMA = txtMamonan.Text,
                    tenMA = txtTenmonan.Text,
                    donViTinh = txtDonvitinh.Text,
                    GiaMA = Convert.ToDouble(txtGia.Text),
                    maLM = QLTDBLL.Instance.GetMaLMByTLM(cbbTenLM.SelectedItem.ToString())
                };
                QLTDBLL.Instance.Update(ma);
                ShowAllMABy("Tất cả");
            }    
            else
            {
                MessageBox.Show("Chọn một dòng để cập nhật","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn xóa món ăn","Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.OK)
            {
                if(dtgvDSMA.SelectedRows.Count > 0)
                {
                    List<string> maMA = new List<string>();
                    foreach(DataGridViewRow dr in dtgvDSMA.SelectedRows)
                    {
                        maMA.Add(dr.Cells["maMA"].Value.ToString()); 
                    }  
                    foreach(string ID in maMA)
                    {
                        QLTDBLL.Instance.Delete(ID);
                    }    
                }   
                else
                {
                    MessageBox.Show("Chọn 1 dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       

      
    }
}
