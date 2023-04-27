namespace DoAnPBL3.View
{
    partial class CaLamViec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaLamViec));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCalamviec = new System.Windows.Forms.Panel();
            this.dtmNgaylam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnTatCa = new Guna.UI2.WinForms.Guna2Button();
            this.btDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvCalamviec = new System.Windows.Forms.DataGridView();
            this.pnlCalamviec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCalamviec)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCalamviec
            // 
            this.pnlCalamviec.Controls.Add(this.dtgvCalamviec);
            this.pnlCalamviec.Controls.Add(this.dtmNgaylam);
            this.pnlCalamviec.Controls.Add(this.btnTatCa);
            this.pnlCalamviec.Controls.Add(this.btDangKy);
            this.pnlCalamviec.Controls.Add(this.btnTimKiem);
            this.pnlCalamviec.Controls.Add(this.label1);
            this.pnlCalamviec.Controls.Add(this.label2);
            this.pnlCalamviec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalamviec.Location = new System.Drawing.Point(0, 0);
            this.pnlCalamviec.Name = "pnlCalamviec";
            this.pnlCalamviec.Size = new System.Drawing.Size(847, 611);
            this.pnlCalamviec.TabIndex = 0;
            // 
            // dtmNgaylam
            // 
            this.dtmNgaylam.Checked = true;
            this.dtmNgaylam.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaylam.FillColor = System.Drawing.Color.Silver;
            this.dtmNgaylam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmNgaylam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaylam.Location = new System.Drawing.Point(308, 69);
            this.dtmNgaylam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmNgaylam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmNgaylam.Name = "dtmNgaylam";
            this.dtmNgaylam.ShowUpDown = true;
            this.dtmNgaylam.Size = new System.Drawing.Size(264, 44);
            this.dtmNgaylam.TabIndex = 78;
            this.dtmNgaylam.Value = new System.DateTime(2023, 4, 26, 21, 40, 44, 808);
            // 
            // btnTatCa
            // 
            this.btnTatCa.BorderRadius = 15;
            this.btnTatCa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTatCa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTatCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTatCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTatCa.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnTatCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.ForeColor = System.Drawing.Color.White;
            this.btnTatCa.Image = ((System.Drawing.Image)(resources.GetObject("btnTatCa.Image")));
            this.btnTatCa.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTatCa.Location = new System.Drawing.Point(100, 152);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(154, 51);
            this.btnTatCa.TabIndex = 77;
            this.btnTatCa.Text = "Tất cả";
            // 
            // btDangKy
            // 
            this.btDangKy.BorderRadius = 15;
            this.btDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDangKy.FillColor = System.Drawing.Color.DarkSalmon;
            this.btDangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangKy.ForeColor = System.Drawing.Color.White;
            this.btDangKy.Image = ((System.Drawing.Image)(resources.GetObject("btDangKy.Image")));
            this.btDangKy.ImageSize = new System.Drawing.Size(25, 25);
            this.btDangKy.Location = new System.Drawing.Point(511, 152);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(251, 51);
            this.btDangKy.TabIndex = 76;
            this.btDangKy.Text = "Đăng ký ca làm";
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTimKiem.Location = new System.Drawing.Point(308, 152);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(167, 51);
            this.btnTimKiem.TabIndex = 74;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Thông tin ca làm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 73;
            this.label2.Text = "Ngày làm";
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 8;
            this.trangThai.Name = "trangThai";
            this.trangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.trangThai.Width = 150;
            // 
            // gioKetThuc
            // 
            this.gioKetThuc.DataPropertyName = "gioKetThuc";
            this.gioKetThuc.HeaderText = "Giờ kết thúc";
            this.gioKetThuc.MinimumWidth = 8;
            this.gioKetThuc.Name = "gioKetThuc";
            this.gioKetThuc.Width = 150;
            // 
            // gioBatDau
            // 
            this.gioBatDau.DataPropertyName = "gioBatDau";
            this.gioBatDau.HeaderText = "Giờ bắt đầu";
            this.gioBatDau.MinimumWidth = 8;
            this.gioBatDau.Name = "gioBatDau";
            this.gioBatDau.Width = 150;
            // 
            // ngayLam
            // 
            this.ngayLam.DataPropertyName = "ngayLam";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ngayLam.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayLam.HeaderText = "Ngày làm";
            this.ngayLam.MinimumWidth = 8;
            this.ngayLam.Name = "ngayLam";
            this.ngayLam.Width = 150;
            // 
            // maCT
            // 
            this.maCT.DataPropertyName = "maCT";
            this.maCT.HeaderText = "Mã ca làm";
            this.maCT.MinimumWidth = 8;
            this.maCT.Name = "maCT";
            this.maCT.Width = 150;
            // 
            // dtgvCalamviec
            // 
            this.dtgvCalamviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCalamviec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCT,
            this.ngayLam,
            this.gioBatDau,
            this.gioKetThuc,
            this.trangThai});
            this.dtgvCalamviec.Location = new System.Drawing.Point(3, 268);
            this.dtgvCalamviec.Name = "dtgvCalamviec";
            this.dtgvCalamviec.RowHeadersWidth = 62;
            this.dtgvCalamviec.RowTemplate.Height = 28;
            this.dtgvCalamviec.Size = new System.Drawing.Size(841, 331);
            this.dtgvCalamviec.TabIndex = 79;
            // 
            // CaLamViec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(847, 611);
            this.Controls.Add(this.pnlCalamviec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaLamViec";
            this.pnlCalamviec.ResumeLayout(false);
            this.pnlCalamviec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCalamviec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCalamviec;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmNgaylam;
        private Guna.UI2.WinForms.Guna2Button btnTatCa;
        private Guna.UI2.WinForms.Guna2Button btDangKy;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvCalamviec;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioKetThuc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThai;
    }
}