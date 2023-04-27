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
    public partial class CaLamViec : Form
    {

        
        public CaLamViec()
        {
            InitializeComponent();
            QLNH_DB db = new QLNH_DB();
            dtgvCalamviec.DataSource = db.CHITIETCALAMs.Select(p => p).ToList();
        }

        public void ShowForminPanel(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlCalamviec.Controls.Add(form);
            this.pnlCalamviec.Controls.SetChildIndex(form, 0);
            form.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime ngaylam;
            if (DateTime.TryParseExact(dtmNgaylam.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaylam))
            {
                dtgvCalamviec.DataSource = QLCTBLL.Instance.GetAll_CaTruc(ngaylam);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ca trực nào cho ngày đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            ShowForminPanel(new DangKyCaLam());
        }
    }
}
