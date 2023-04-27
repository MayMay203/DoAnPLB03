using System.Windows.Forms;

namespace DoAnPBL3
{
    partial class QuanLyCaTruc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyCaTruc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbbTrangthai = new System.Windows.Forms.ComboBox();
            this.dtmNgaylam = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtmGiobatdau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtmGioketthuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMacatruc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dtgvCatruc = new System.Windows.Forms.DataGridView();
            this.MaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dtmTimkiem = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel2.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatruc)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BorderRadius = 15;
            this.btnTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiem.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimkiem.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnTimkiem.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTimkiem.Location = new System.Drawing.Point(482, 6);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(169, 45);
            this.btnTimkiem.TabIndex = 47;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextOffset = new System.Drawing.Point(15, 0);
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.Controls.Add(this.cbbTrangthai);
            this.guna2Panel2.Controls.Add(this.dtmNgaylam);
            this.guna2Panel2.Controls.Add(this.dtmGiobatdau);
            this.guna2Panel2.Controls.Add(this.dtmGioketthuc);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.txtSoluong);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.txtMacatruc);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel2.Location = new System.Drawing.Point(69, 76);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(449, 366);
            this.guna2Panel2.TabIndex = 49;
            // 
            // cbbTrangthai
            // 
            this.cbbTrangthai.FormattingEnabled = true;
            this.cbbTrangthai.Location = new System.Drawing.Point(142, 315);
            this.cbbTrangthai.Name = "cbbTrangthai";
            this.cbbTrangthai.Size = new System.Drawing.Size(226, 24);
            this.cbbTrangthai.TabIndex = 58;
            // 
            // dtmNgaylam
            // 
            this.dtmNgaylam.Checked = true;
            this.dtmNgaylam.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaylam.FillColor = System.Drawing.Color.Silver;
            this.dtmNgaylam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmNgaylam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaylam.Location = new System.Drawing.Point(142, 71);
            this.dtmNgaylam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmNgaylam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmNgaylam.Name = "dtmNgaylam";
            this.dtmNgaylam.Size = new System.Drawing.Size(226, 36);
            this.dtmNgaylam.TabIndex = 57;
            this.dtmNgaylam.Value = new System.DateTime(2023, 4, 21, 8, 6, 18, 25);
            // 
            // dtmGiobatdau
            // 
            this.dtmGiobatdau.Checked = true;
            this.dtmGiobatdau.FillColor = System.Drawing.Color.Silver;
            this.dtmGiobatdau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmGiobatdau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmGiobatdau.Location = new System.Drawing.Point(142, 130);
            this.dtmGiobatdau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmGiobatdau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmGiobatdau.Name = "dtmGiobatdau";
            this.dtmGiobatdau.ShowUpDown = true;
            this.dtmGiobatdau.Size = new System.Drawing.Size(226, 36);
            this.dtmGiobatdau.TabIndex = 56;
            this.dtmGiobatdau.Value = new System.DateTime(2023, 4, 21, 8, 6, 18, 25);
            // 
            // dtmGioketthuc
            // 
            this.dtmGioketthuc.Checked = true;
            this.dtmGioketthuc.FillColor = System.Drawing.Color.Silver;
            this.dtmGioketthuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmGioketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmGioketthuc.Location = new System.Drawing.Point(142, 191);
            this.dtmGioketthuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmGioketthuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmGioketthuc.Name = "dtmGioketthuc";
            this.dtmGioketthuc.ShowUpDown = true;
            this.dtmGioketthuc.Size = new System.Drawing.Size(226, 36);
            this.dtmGioketthuc.TabIndex = 55;
            this.dtmGioketthuc.Value = new System.DateTime(2023, 4, 21, 8, 7, 48, 665);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Trạng thái";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoluong.DefaultText = "";
            this.txtSoluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoluong.ForeColor = System.Drawing.Color.Black;
            this.txtSoluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoluong.Location = new System.Drawing.Point(142, 246);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.PasswordChar = '\0';
            this.txtSoluong.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSoluong.PlaceholderText = "";
            this.txtSoluong.SelectedText = "";
            this.txtSoluong.Size = new System.Drawing.Size(229, 38);
            this.txtSoluong.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ngày làm";
            // 
            // txtMacatruc
            // 
            this.txtMacatruc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMacatruc.DefaultText = "";
            this.txtMacatruc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMacatruc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMacatruc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMacatruc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMacatruc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMacatruc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMacatruc.ForeColor = System.Drawing.Color.Black;
            this.txtMacatruc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMacatruc.Location = new System.Drawing.Point(142, 15);
            this.txtMacatruc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMacatruc.Name = "txtMacatruc";
            this.txtMacatruc.PasswordChar = '\0';
            this.txtMacatruc.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMacatruc.PlaceholderText = "";
            this.txtMacatruc.SelectedText = "";
            this.txtMacatruc.Size = new System.Drawing.Size(229, 38);
            this.txtMacatruc.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Giờ kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Giờ bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã ca trực";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.dtgvCatruc);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(524, 76);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(504, 366);
            this.guna2GradientPanel2.TabIndex = 51;
            // 
            // dtgvCatruc
            // 
            this.dtgvCatruc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCatruc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCT,
            this.ngayLam,
            this.gioBatDau,
            this.gioKetThuc,
            this.soLuong,
            this.trangThai});
            this.dtgvCatruc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCatruc.Location = new System.Drawing.Point(0, 0);
            this.dtgvCatruc.Name = "dtgvCatruc";
            this.dtgvCatruc.RowHeadersWidth = 51;
            this.dtgvCatruc.RowTemplate.Height = 24;
            this.dtgvCatruc.Size = new System.Drawing.Size(504, 366);
            this.dtgvCatruc.TabIndex = 0;
            this.dtgvCatruc.SelectionChanged += new System.EventHandler(this.dtgvCatruc_SelectionChanged);
            // 
            // MaCT
            // 
            this.MaCT.DataPropertyName = "maCT";
            this.MaCT.HeaderText = "Mã ca trực";
            this.MaCT.MinimumWidth = 6;
            this.MaCT.Name = "MaCT";
            this.MaCT.Width = 125;
            // 
            // ngayLam
            // 
            this.ngayLam.DataPropertyName = "ngayLam";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ngayLam.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngayLam.HeaderText = "Ngày làm";
            this.ngayLam.MinimumWidth = 6;
            this.ngayLam.Name = "ngayLam";
            this.ngayLam.Width = 125;
            // 
            // gioBatDau
            // 
            this.gioBatDau.DataPropertyName = "gioBatDau";
            this.gioBatDau.HeaderText = "Giờ bắt đầu";
            this.gioBatDau.MinimumWidth = 6;
            this.gioBatDau.Name = "gioBatDau";
            this.gioBatDau.Width = 125;
            // 
            // gioKetThuc
            // 
            this.gioKetThuc.DataPropertyName = "gioKetThuc";
            this.gioKetThuc.HeaderText = "Giờ kết thúc";
            this.gioKetThuc.MinimumWidth = 6;
            this.gioKetThuc.Name = "gioKetThuc";
            this.gioKetThuc.Width = 125;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 125;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.trangThai.Width = 125;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.btnXoa);
            this.guna2GradientPanel1.Controls.Add(this.btnCapnhat);
            this.guna2GradientPanel1.Controls.Add(this.btnThem);
            this.guna2GradientPanel1.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(197, 448);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(670, 75);
            this.guna2GradientPanel1.TabIndex = 52;
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 15;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnXoa.ImageSize = new System.Drawing.Size(25, 25);
            this.btnXoa.Location = new System.Drawing.Point(472, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(169, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextOffset = new System.Drawing.Point(10, 0);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BorderRadius = 15;
            this.btnCapnhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapnhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapnhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapnhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapnhat.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnCapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapnhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhat.Image")));
            this.btnCapnhat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCapnhat.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnCapnhat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCapnhat.Location = new System.Drawing.Point(248, 15);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(169, 45);
            this.btnCapnhat.TabIndex = 1;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextOffset = new System.Drawing.Point(20, 0);
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 15;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnThem.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThem.Location = new System.Drawing.Point(25, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(169, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextOffset = new System.Drawing.Point(10, 0);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtmTimkiem
            // 
            this.dtmTimkiem.Checked = true;
            this.dtmTimkiem.CustomFormat = "dd/MM/yyyy";
            this.dtmTimkiem.FillColor = System.Drawing.Color.Silver;
            this.dtmTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmTimkiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmTimkiem.Location = new System.Drawing.Point(133, 12);
            this.dtmTimkiem.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmTimkiem.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmTimkiem.Name = "dtmTimkiem";
            this.dtmTimkiem.ShowUpDown = true;
            this.dtmTimkiem.Size = new System.Drawing.Size(279, 36);
            this.dtmTimkiem.TabIndex = 53;
            this.dtmTimkiem.Value = new System.DateTime(2023, 4, 25, 23, 39, 57, 542);
            // 
            // QuanLyCaTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 603);
            this.Controls.Add(this.dtmTimkiem);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnTimkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyCaTruc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyCaTruc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatruc)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtMacatruc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.DataGridView dtgvCatruc;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnCapnhat;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmNgaylam;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmGiobatdau;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmGioketthuc;
        private System.Windows.Forms.ComboBox cbbTrangthai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmTimkiem;
        private DataGridViewTextBoxColumn MaCT;
        private DataGridViewTextBoxColumn ngayLam;
        private DataGridViewTextBoxColumn gioBatDau;
        private DataGridViewTextBoxColumn gioKetThuc;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewCheckBoxColumn trangThai;
    }
}