using DoAnPBL3.BLL;
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
            SetCBB_TenNV();
        }
        public void SetCBB_TenNV()
        {
            foreach(string s in QLCTBLL.Instance.GetAll_TenNV())
            {
                cbbTenNV.Items.Add(s);
            }
        }

        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            txtMacatruc.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime ngaylam;
            if(DateTime.TryParseExact(dtmNgaylam.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaylam))
            {
                dtgvDSCT.DataSource = QLCTBLL.Instance.GetAll_CaTruc(ngaylam);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ca trực nào cho ngày đã chọn!", "Thông tin",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
