namespace Nhom09_QuanLyKaraoke
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ts_QLNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_QLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_LoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Phong = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_DatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_QLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_DichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_AnUong = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_HoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_TraPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_GoiMon = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_DoiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_datphong = new System.Windows.Forms.Button();
            this.btn_nhanphong = new System.Windows.Forms.Button();
            this.btn_kiemtraphong = new System.Windows.Forms.Button();
            this.txt_ngaythang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_dsphong = new System.Windows.Forms.DataGridView();
            this.SOPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOVAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOGIOHAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONDAGOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phong = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphong)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_QLNhanSu,
            this.ts_QLPhong,
            this.ts_QLKhachHang,
            this.ts_DichVu,
            this.ts_ThongKe,
            this.ts_HoSo,
            this.ts_dangxuat});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1088, 28);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "menuStrip1";
            // 
            // ts_QLNhanSu
            // 
            this.ts_QLNhanSu.Name = "ts_QLNhanSu";
            this.ts_QLNhanSu.Size = new System.Drawing.Size(128, 24);
            this.ts_QLNhanSu.Text = "Quản lý nhân sự";
            // 
            // ts_QLPhong
            // 
            this.ts_QLPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_LoaiPhong,
            this.ts_Phong,
            this.ts_DatPhong});
            this.ts_QLPhong.Name = "ts_QLPhong";
            this.ts_QLPhong.Size = new System.Drawing.Size(120, 24);
            this.ts_QLPhong.Text = "Quản lý phòng";
            // 
            // ts_LoaiPhong
            // 
            this.ts_LoaiPhong.Name = "ts_LoaiPhong";
            this.ts_LoaiPhong.Size = new System.Drawing.Size(202, 26);
            this.ts_LoaiPhong.Text = "Loại Phòng";
            // 
            // ts_Phong
            // 
            this.ts_Phong.Name = "ts_Phong";
            this.ts_Phong.Size = new System.Drawing.Size(202, 26);
            this.ts_Phong.Text = "Phòng";
            // 
            // ts_DatPhong
            // 
            this.ts_DatPhong.Name = "ts_DatPhong";
            this.ts_DatPhong.Size = new System.Drawing.Size(202, 26);
            this.ts_DatPhong.Text = "Phiếu Đặt Phòng";
            // 
            // ts_QLKhachHang
            // 
            this.ts_QLKhachHang.Name = "ts_QLKhachHang";
            this.ts_QLKhachHang.Size = new System.Drawing.Size(152, 24);
            this.ts_QLKhachHang.Text = "Quản lý khách hàng";
            // 
            // ts_DichVu
            // 
            this.ts_DichVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_AnUong});
            this.ts_DichVu.Name = "ts_DichVu";
            this.ts_DichVu.Size = new System.Drawing.Size(72, 24);
            this.ts_DichVu.Text = "Dịch vụ";
            // 
            // tsm_AnUong
            // 
            this.tsm_AnUong.Name = "tsm_AnUong";
            this.tsm_AnUong.Size = new System.Drawing.Size(150, 26);
            this.tsm_AnUong.Text = "Ăn Uống";
            // 
            // ts_ThongKe
            // 
            this.ts_ThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_DoanhThu,
            this.ts_HoaDon});
            this.ts_ThongKe.Name = "ts_ThongKe";
            this.ts_ThongKe.Size = new System.Drawing.Size(84, 24);
            this.ts_ThongKe.Text = "Thống kê";
            // 
            // ts_DoanhThu
            // 
            this.ts_DoanhThu.Name = "ts_DoanhThu";
            this.ts_DoanhThu.Size = new System.Drawing.Size(161, 26);
            this.ts_DoanhThu.Text = "Doanh thu";
            // 
            // ts_HoaDon
            // 
            this.ts_HoaDon.Name = "ts_HoaDon";
            this.ts_HoaDon.Size = new System.Drawing.Size(161, 26);
            this.ts_HoaDon.Text = "Hoá đơn";
            // 
            // ts_HoSo
            // 
            this.ts_HoSo.Name = "ts_HoSo";
            this.ts_HoSo.Size = new System.Drawing.Size(62, 24);
            this.ts_HoSo.Text = "Hồ sơ";
            // 
            // ts_dangxuat
            // 
            this.ts_dangxuat.Name = "ts_dangxuat";
            this.ts_dangxuat.Size = new System.Drawing.Size(93, 24);
            this.ts_dangxuat.Text = "Đăng Xuất";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctm_TraPhong,
            this.ctm_GoiMon,
            this.ctm_DoiPhong});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 76);
            // 
            // ctm_TraPhong
            // 
            this.ctm_TraPhong.Name = "ctm_TraPhong";
            this.ctm_TraPhong.Size = new System.Drawing.Size(148, 24);
            this.ctm_TraPhong.Text = "Trả Phòng";
            // 
            // ctm_GoiMon
            // 
            this.ctm_GoiMon.Name = "ctm_GoiMon";
            this.ctm_GoiMon.Size = new System.Drawing.Size(148, 24);
            this.ctm_GoiMon.Text = "Gọi Món";
            // 
            // ctm_DoiPhong
            // 
            this.ctm_DoiPhong.Name = "ctm_DoiPhong";
            this.ctm_DoiPhong.Size = new System.Drawing.Size(148, 24);
            this.ctm_DoiPhong.Text = "Đổi Phòng";
            // 
            // btn_datphong
            // 
            this.btn_datphong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.SetColumnSpan(this.btn_datphong, 2);
            this.btn_datphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datphong.Location = new System.Drawing.Point(294, 53);
            this.btn_datphong.Name = "btn_datphong";
            this.btn_datphong.Size = new System.Drawing.Size(125, 31);
            this.btn_datphong.TabIndex = 20;
            this.btn_datphong.Text = "Đặt phòng";
            this.btn_datphong.UseVisualStyleBackColor = false;
            // 
            // btn_nhanphong
            // 
            this.btn_nhanphong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_nhanphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanphong.Location = new System.Drawing.Point(446, 53);
            this.btn_nhanphong.Name = "btn_nhanphong";
            this.btn_nhanphong.Size = new System.Drawing.Size(125, 31);
            this.btn_nhanphong.TabIndex = 10;
            this.btn_nhanphong.Text = "Nhận phòng";
            this.btn_nhanphong.UseVisualStyleBackColor = false;
            // 
            // btn_kiemtraphong
            // 
            this.btn_kiemtraphong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_kiemtraphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kiemtraphong.Location = new System.Drawing.Point(598, 53);
            this.btn_kiemtraphong.Name = "btn_kiemtraphong";
            this.btn_kiemtraphong.Size = new System.Drawing.Size(177, 31);
            this.btn_kiemtraphong.TabIndex = 21;
            this.btn_kiemtraphong.Text = "Kiểm tra phòng trống";
            this.btn_kiemtraphong.UseVisualStyleBackColor = false;
            // 
            // txt_ngaythang
            // 
            this.txt_ngaythang.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ngaythang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ngaythang.Location = new System.Drawing.Point(446, 18);
            this.txt_ngaythang.Name = "txt_ngaythang";
            this.txt_ngaythang.Size = new System.Drawing.Size(112, 15);
            this.txt_ngaythang.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 3);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(228, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hoạt động hôm nay";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.31092F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.68908F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 492F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgv_dsphong, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_kiemtraphong, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_nhanphong, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_ngaythang, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_phong, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_tim, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_datphong, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 491);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 9);
            this.label2.TabIndex = 8;
            // 
            // dgv_dsphong
            // 
            this.dgv_dsphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dsphong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dsphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOPHONG,
            this.HOTEN,
            this.GIOVAO,
            this.SOGIOHAT,
            this.MONDAGOI,
            this.TONGTIEN});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_dsphong, 6);
            this.dgv_dsphong.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dsphong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_dsphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsphong.Location = new System.Drawing.Point(3, 137);
            this.dgv_dsphong.Name = "dgv_dsphong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dsphong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_dsphong.RowHeadersWidth = 51;
            this.dgv_dsphong.RowTemplate.Height = 24;
            this.dgv_dsphong.Size = new System.Drawing.Size(1082, 342);
            this.dgv_dsphong.TabIndex = 17;
            // 
            // SOPHONG
            // 
            this.SOPHONG.DataPropertyName = "SOPHONG";
            this.SOPHONG.HeaderText = "SỐ PHÒNG";
            this.SOPHONG.MinimumWidth = 6;
            this.SOPHONG.Name = "SOPHONG";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "KHÁCH HÀNG";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            // 
            // GIOVAO
            // 
            this.GIOVAO.DataPropertyName = "GIOVAO";
            this.GIOVAO.HeaderText = "GIỜ VÀO";
            this.GIOVAO.MinimumWidth = 6;
            this.GIOVAO.Name = "GIOVAO";
            // 
            // SOGIOHAT
            // 
            this.SOGIOHAT.DataPropertyName = "SOGIOHAT";
            this.SOGIOHAT.HeaderText = "THỜI GIAN HÁT";
            this.SOGIOHAT.MinimumWidth = 6;
            this.SOGIOHAT.Name = "SOGIOHAT";
            // 
            // MONDAGOI
            // 
            this.MONDAGOI.DataPropertyName = "MONDAGOI";
            this.MONDAGOI.HeaderText = "MÓN ĐÃ GỌI";
            this.MONDAGOI.MinimumWidth = 6;
            this.MONDAGOI.Name = "MONDAGOI";
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "TỔNG TIỀN";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = " PHÒNG ĐANG SỬ DỤNG";
            // 
            // txt_phong
            // 
            this.txt_phong.Location = new System.Drawing.Point(228, 106);
            this.txt_phong.Name = "txt_phong";
            this.txt_phong.Size = new System.Drawing.Size(40, 22);
            this.txt_phong.TabIndex = 24;
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.SetColumnSpan(this.btn_tim, 2);
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(303, 106);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(85, 25);
            this.btn_tim.TabIndex = 23;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "Quản lý quán karaoke";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem ts_QLNhanSu;
        private System.Windows.Forms.ToolStripMenuItem ts_QLPhong;
        private System.Windows.Forms.ToolStripMenuItem ts_QLKhachHang;
        private System.Windows.Forms.ToolStripMenuItem ts_DichVu;
        private System.Windows.Forms.ToolStripMenuItem ts_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem ts_HoSo;
        private System.Windows.Forms.ToolStripMenuItem ts_LoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem ts_Phong;
        private System.Windows.Forms.ToolStripMenuItem ts_DatPhong;
        private System.Windows.Forms.ToolStripMenuItem ts_DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem ts_HoaDon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_TraPhong;
        private System.Windows.Forms.ToolStripMenuItem ctm_GoiMon;
        private System.Windows.Forms.Button btn_datphong;
        private System.Windows.Forms.Button btn_nhanphong;
        private System.Windows.Forms.Button btn_kiemtraphong;
        private System.Windows.Forms.TextBox txt_ngaythang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_dsphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem tsm_AnUong;
        private System.Windows.Forms.TextBox txt_phong;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.ToolStripMenuItem ctm_DoiPhong;
        private System.Windows.Forms.ToolStripMenuItem ts_dangxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOVAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOGIOHAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONDAGOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
    }
}

