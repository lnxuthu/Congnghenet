namespace Nhom09_QuanLyKaraoke
{
    partial class QuanLyDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDatPhong));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_dsphieudatphong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.grb_ttcanhan = new System.Windows.Forms.GroupBox();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_phong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ngayketthuc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_loaiphong = new System.Windows.Forms.ComboBox();
            this.txt_giobatdau = new System.Windows.Forms.TextBox();
            this.txt_ngaydat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphieudatphong)).BeginInit();
            this.grb_ttcanhan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(422, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "QUẢN LÝ PHIẾU ĐẶT PHÒNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_dsphieudatphong);
            this.groupBox2.Location = new System.Drawing.Point(82, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 188);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu đặt phòng";
            // 
            // dgv_dsphieudatphong
            // 
            this.dgv_dsphieudatphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsphieudatphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsphieudatphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_dsphieudatphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsphieudatphong.Location = new System.Drawing.Point(3, 18);
            this.dgv_dsphieudatphong.Name = "dgv_dsphieudatphong";
            this.dgv_dsphieudatphong.RowHeadersWidth = 51;
            this.dgv_dsphieudatphong.RowTemplate.Height = 24;
            this.dgv_dsphieudatphong.Size = new System.Drawing.Size(940, 167);
            this.dgv_dsphieudatphong.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MÃ PHIẾU";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "KHÁCH HÀNG";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SỐ ĐIỆN THOẠI";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NGÀY ĐẶT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "GIỜ BẮT ĐẦU";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "GIỜ KẾT THÚC";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "LOẠI PHÒNG";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "PHÒNG";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "TỔNG TIỀN";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.Location = new System.Drawing.Point(929, 19);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(99, 33);
            this.btn_thoat.TabIndex = 72;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // grb_ttcanhan
            // 
            this.grb_ttcanhan.Controls.Add(this.rdb_nu);
            this.grb_ttcanhan.Controls.Add(this.rdb_nam);
            this.grb_ttcanhan.Controls.Add(this.txt_sdt);
            this.grb_ttcanhan.Controls.Add(this.txt_hoten);
            this.grb_ttcanhan.Controls.Add(this.label5);
            this.grb_ttcanhan.Controls.Add(this.label4);
            this.grb_ttcanhan.Controls.Add(this.label2);
            this.grb_ttcanhan.Location = new System.Drawing.Point(82, 60);
            this.grb_ttcanhan.Name = "grb_ttcanhan";
            this.grb_ttcanhan.Size = new System.Drawing.Size(379, 160);
            this.grb_ttcanhan.TabIndex = 38;
            this.grb_ttcanhan.TabStop = false;
            this.grb_ttcanhan.Text = "Thông tin khách hàng";
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Location = new System.Drawing.Point(196, 115);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(45, 20);
            this.rdb_nu.TabIndex = 8;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "Nữ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Location = new System.Drawing.Point(122, 115);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(57, 20);
            this.rdb_nam.TabIndex = 7;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Nam";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(122, 75);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(234, 22);
            this.txt_sdt.TabIndex = 5;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(122, 36);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(234, 22);
            this.txt_hoten.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_phong);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_ngayketthuc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_tongtien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_loaiphong);
            this.groupBox1.Controls.Add(this.txt_giobatdau);
            this.groupBox1.Controls.Add(this.txt_ngaydat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(467, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 160);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt phòng";
            // 
            // txt_phong
            // 
            this.txt_phong.BackColor = System.Drawing.SystemColors.Control;
            this.txt_phong.Enabled = false;
            this.txt_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phong.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_phong.Location = new System.Drawing.Point(421, 75);
            this.txt_phong.Name = "txt_phong";
            this.txt_phong.Size = new System.Drawing.Size(102, 22);
            this.txt_phong.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tổng tiền";
            // 
            // txt_ngayketthuc
            // 
            this.txt_ngayketthuc.Location = new System.Drawing.Point(169, 119);
            this.txt_ngayketthuc.Name = "txt_ngayketthuc";
            this.txt_ngayketthuc.Size = new System.Drawing.Size(139, 22);
            this.txt_ngayketthuc.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Đến";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Từ";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.SystemColors.Control;
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(421, 119);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(102, 22);
            this.txt_tongtien.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Phòng";
            // 
            // cmb_loaiphong
            // 
            this.cmb_loaiphong.FormattingEnabled = true;
            this.cmb_loaiphong.Location = new System.Drawing.Point(421, 33);
            this.cmb_loaiphong.Name = "cmb_loaiphong";
            this.cmb_loaiphong.Size = new System.Drawing.Size(102, 24);
            this.cmb_loaiphong.TabIndex = 6;
            // 
            // txt_giobatdau
            // 
            this.txt_giobatdau.Location = new System.Drawing.Point(169, 75);
            this.txt_giobatdau.Name = "txt_giobatdau";
            this.txt_giobatdau.Size = new System.Drawing.Size(139, 22);
            this.txt_giobatdau.TabIndex = 5;
            // 
            // txt_ngaydat
            // 
            this.txt_ngaydat.Location = new System.Drawing.Point(122, 36);
            this.txt_ngaydat.Name = "txt_ngaydat";
            this.txt_ngaydat.Size = new System.Drawing.Size(186, 22);
            this.txt_ngaydat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giờ đặt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày đặt";
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(733, 226);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(92, 33);
            this.btn_tim.TabIndex = 83;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = false;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(612, 226);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(92, 33);
            this.btn_luu.TabIndex = 82;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(492, 226);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 33);
            this.btn_sua.TabIndex = 81;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(372, 226);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(92, 33);
            this.btn_huy.TabIndex = 80;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(258, 226);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 33);
            this.btn_them.TabIndex = 79;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // QuanLyDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 473);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_ttcanhan);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Name = "QuanLyDatPhong";
            this.Text = "Quản Lý Phiếu Đặt Phòng";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphieudatphong)).EndInit();
            this.grb_ttcanhan.ResumeLayout(false);
            this.grb_ttcanhan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_dsphieudatphong;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.GroupBox grb_ttcanhan;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.RadioButton rdb_nam;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ngayketthuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_loaiphong;
        private System.Windows.Forms.TextBox txt_giobatdau;
        private System.Windows.Forms.TextBox txt_ngaydat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_them;
    }
}