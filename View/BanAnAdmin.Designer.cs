namespace DoAnPBL3
{
    partial class BanAnAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanAnAdmin));
            this.pnlBanan = new System.Windows.Forms.Panel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dtgvBanan = new System.Windows.Forms.DataGridView();
            this.maBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnXemlichsudatban = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbbTrangthai = new System.Windows.Forms.ComboBox();
            this.txtGhichu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoghe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaban = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBanan.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanan)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanan
            // 
            this.pnlBanan.Controls.Add(this.guna2GradientPanel2);
            this.pnlBanan.Controls.Add(this.txtTimkiem);
            this.pnlBanan.Controls.Add(this.btnTimkiem);
            this.pnlBanan.Controls.Add(this.guna2GradientPanel1);
            this.pnlBanan.Controls.Add(this.guna2Panel2);
            this.pnlBanan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBanan.Location = new System.Drawing.Point(0, 0);
            this.pnlBanan.Name = "pnlBanan";
            this.pnlBanan.Size = new System.Drawing.Size(1093, 603);
            this.pnlBanan.TabIndex = 0;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.dtgvBanan);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(439, 140);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(635, 300);
            this.guna2GradientPanel2.TabIndex = 58;
            // 
            // dtgvBanan
            // 
            this.dtgvBanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBan,
            this.maPV,
            this.soGhe,
            this.trangThai,
            this.ghiChu});
            this.dtgvBanan.Location = new System.Drawing.Point(4, 4);
            this.dtgvBanan.Name = "dtgvBanan";
            this.dtgvBanan.RowHeadersWidth = 51;
            this.dtgvBanan.RowTemplate.Height = 24;
            this.dtgvBanan.Size = new System.Drawing.Size(628, 293);
            this.dtgvBanan.TabIndex = 0;
            this.dtgvBanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBanan_CellClick);
            // 
            // maBan
            // 
            this.maBan.DataPropertyName = "maBan";
            this.maBan.HeaderText = "Mã bàn";
            this.maBan.MinimumWidth = 6;
            this.maBan.Name = "maBan";
            this.maBan.Width = 125;
            // 
            // maPV
            // 
            this.maPV.DataPropertyName = "maPV";
            this.maPV.HeaderText = "Mã phục vụ";
            this.maPV.MinimumWidth = 6;
            this.maPV.Name = "maPV";
            this.maPV.Width = 125;
            // 
            // soGhe
            // 
            this.soGhe.DataPropertyName = "soGhe";
            this.soGhe.HeaderText = "Số ghế";
            this.soGhe.MinimumWidth = 6;
            this.soGhe.Name = "soGhe";
            this.soGhe.Width = 125;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.Width = 125;
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.MinimumWidth = 6;
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.Width = 125;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimkiem.BorderRadius = 15;
            this.txtTimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiem.DefaultText = "";
            this.txtTimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.Location = new System.Drawing.Point(129, 58);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PasswordChar = '\0';
            this.txtTimkiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.SelectedText = "";
            this.txtTimkiem.Size = new System.Drawing.Size(368, 38);
            this.txtTimkiem.TabIndex = 57;
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
            this.btnTimkiem.Location = new System.Drawing.Point(554, 51);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(169, 45);
            this.btnTimkiem.TabIndex = 56;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextOffset = new System.Drawing.Point(15, 0);
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.btnXemlichsudatban);
            this.guna2GradientPanel1.Controls.Add(this.btnCapnhat);
            this.guna2GradientPanel1.Controls.Add(this.btnThem);
            this.guna2GradientPanel1.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(160, 476);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(781, 75);
            this.guna2GradientPanel1.TabIndex = 55;
            // 
            // btnXemlichsudatban
            // 
            this.btnXemlichsudatban.BorderRadius = 15;
            this.btnXemlichsudatban.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemlichsudatban.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemlichsudatban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemlichsudatban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemlichsudatban.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnXemlichsudatban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemlichsudatban.ForeColor = System.Drawing.Color.Black;
            this.btnXemlichsudatban.Image = ((System.Drawing.Image)(resources.GetObject("btnXemlichsudatban.Image")));
            this.btnXemlichsudatban.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXemlichsudatban.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnXemlichsudatban.ImageSize = new System.Drawing.Size(25, 25);
            this.btnXemlichsudatban.Location = new System.Drawing.Point(493, 16);
            this.btnXemlichsudatban.Name = "btnXemlichsudatban";
            this.btnXemlichsudatban.Size = new System.Drawing.Size(246, 45);
            this.btnXemlichsudatban.TabIndex = 2;
            this.btnXemlichsudatban.Text = "Xem lịch sử đặt bàn";
            this.btnXemlichsudatban.TextOffset = new System.Drawing.Point(20, 0);
            this.btnXemlichsudatban.Click += new System.EventHandler(this.btnXemlichsudatban_Click);
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
            this.btnCapnhat.Location = new System.Drawing.Point(270, 16);
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
            this.btnThem.Location = new System.Drawing.Point(37, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(169, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextOffset = new System.Drawing.Point(5, 0);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.Controls.Add(this.cbbTrangthai);
            this.guna2Panel2.Controls.Add(this.txtGhichu);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.txtSoghe);
            this.guna2Panel2.Controls.Add(this.txtMaban);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel2.Location = new System.Drawing.Point(18, 140);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(415, 300);
            this.guna2Panel2.TabIndex = 54;
            // 
            // cbbTrangthai
            // 
            this.cbbTrangthai.FormattingEnabled = true;
            this.cbbTrangthai.Location = new System.Drawing.Point(142, 145);
            this.cbbTrangthai.Name = "cbbTrangthai";
            this.cbbTrangthai.Size = new System.Drawing.Size(229, 24);
            this.cbbTrangthai.TabIndex = 52;
            this.cbbTrangthai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangthai_SelectedIndexChanged);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhichu.DefaultText = "";
            this.txtGhichu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhichu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhichu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhichu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhichu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhichu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhichu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhichu.Location = new System.Drawing.Point(142, 194);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.PasswordChar = '\0';
            this.txtGhichu.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtGhichu.PlaceholderText = "";
            this.txtGhichu.SelectedText = "";
            this.txtGhichu.Size = new System.Drawing.Size(229, 38);
            this.txtGhichu.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ghi chú";
            // 
            // txtSoghe
            // 
            this.txtSoghe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoghe.DefaultText = "";
            this.txtSoghe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoghe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoghe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoghe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoghe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoghe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoghe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoghe.Location = new System.Drawing.Point(142, 75);
            this.txtSoghe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoghe.Name = "txtSoghe";
            this.txtSoghe.PasswordChar = '\0';
            this.txtSoghe.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSoghe.PlaceholderText = "";
            this.txtSoghe.SelectedText = "";
            this.txtSoghe.Size = new System.Drawing.Size(229, 38);
            this.txtSoghe.TabIndex = 48;
            // 
            // txtMaban
            // 
            this.txtMaban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaban.DefaultText = "";
            this.txtMaban.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaban.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaban.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaban.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaban.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaban.Location = new System.Drawing.Point(142, 15);
            this.txtMaban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.PasswordChar = '\0';
            this.txtMaban.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMaban.PlaceholderText = "";
            this.txtMaban.SelectedText = "";
            this.txtMaban.Size = new System.Drawing.Size(229, 38);
            this.txtMaban.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Số ghế";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã bàn";
            // 
            // BanAnAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 603);
            this.Controls.Add(this.pnlBanan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BanAnAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanAn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBanan.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanan)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanan;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.DataGridView dtgvBanan;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiem;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnXemlichsudatban;
        private Guna.UI2.WinForms.Guna2Button btnCapnhat;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtGhichu;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSoghe;
        private Guna.UI2.WinForms.Guna2TextBox txtMaban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.ComboBox cbbTrangthai;
    }
}