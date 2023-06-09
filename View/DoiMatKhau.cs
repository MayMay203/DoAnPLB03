﻿using DoAnPBL3.BLL;
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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
            txtTendangnhap.Text = QLTKBLL.Instance.tenDangNhap;
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtMK1.PasswordChar == '*')
            {
                txtMK1.PasswordChar = '\0';
            }
            else
            {
                txtMK1.PasswordChar = '*';
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtMK3.PasswordChar == '*')
            {
                txtMK3.PasswordChar = '\0';
            }
            else
            {
                txtMK3.PasswordChar = '*';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtMK2.PasswordChar == '*')
            {
                txtMK2.PasswordChar = '\0';
            }
            else
            {
                txtMK2.PasswordChar = '*';
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
                string MKCu = txtMK1.Text;
                string MKMoi = txtMK2.Text;
                string MKMoiNhapLai = txtMK3.Text;
                QLTKBLL.Instance.SetPassWord(MKCu, MKMoi,MKMoiNhapLai);
        }

        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
