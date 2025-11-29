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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ts_QLNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_QLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_LoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Phong = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_DatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_QLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_DichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_HoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_nhantraphong = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_dsphong = new System.Windows.Forms.DataGridView();
            this.txt_ngaythang = new System.Windows.Forms.TextBox();
            this.btn_kiemtraphong = new System.Windows.Forms.Button();
            this.btn_datphong = new System.Windows.Forms.Button();
            this.btn_goimon = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
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
            this.ts_HoSo});
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
            this.ts_LoaiPhong.Size = new System.Drawing.Size(215, 26);
            this.ts_LoaiPhong.Text = "Loại Phòng";
            // 
            // ts_Phong
            // 
            this.ts_Phong.Name = "ts_Phong";
            this.ts_Phong.Size = new System.Drawing.Size(215, 26);
            this.ts_Phong.Text = "Phòng";
            // 
            // ts_DatPhong
            // 
            this.ts_DatPhong.Name = "ts_DatPhong";
            this.ts_DatPhong.Size = new System.Drawing.Size(215, 26);
            this.ts_DatPhong.Text = "Quản lý đặt phòng";
            // 
            // ts_QLKhachHang
            // 
            this.ts_QLKhachHang.Name = "ts_QLKhachHang";
            this.ts_QLKhachHang.Size = new System.Drawing.Size(152, 24);
            this.ts_QLKhachHang.Text = "Quản lý khách hàng";
            // 
            // ts_DichVu
            // 
            this.ts_DichVu.Name = "ts_DichVu";
            this.ts_DichVu.Size = new System.Drawing.Size(72, 24);
            this.ts_DichVu.Text = "Dịch vụ";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(169, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hoạt động hôm nay";
            // 
            // btn_nhantraphong
            // 
            this.btn_nhantraphong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_nhantraphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhantraphong.Location = new System.Drawing.Point(356, 56);
            this.btn_nhantraphong.Name = "btn_nhantraphong";
            this.btn_nhantraphong.Size = new System.Drawing.Size(157, 31);
            this.btn_nhantraphong.TabIndex = 10;
            this.btn_nhantraphong.Text = "Nhận trả phòng";
            this.btn_nhantraphong.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.98413F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.01587F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 411F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgv_dsphong, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_ngaythang, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_kiemtraphong, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_datphong, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_nhantraphong, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_goimon, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 347F));
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 2);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Danh sách phòng đang sử dụng";
            // 
            // dgv_dsphong
            // 
            this.dgv_dsphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_dsphong, 5);
            this.dgv_dsphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsphong.Location = new System.Drawing.Point(3, 138);
            this.dgv_dsphong.Name = "dgv_dsphong";
            this.dgv_dsphong.RowHeadersWidth = 51;
            this.dgv_dsphong.RowTemplate.Height = 24;
            this.dgv_dsphong.Size = new System.Drawing.Size(1082, 341);
            this.dgv_dsphong.TabIndex = 17;
            // 
            // txt_ngaythang
            // 
            this.txt_ngaythang.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ngaythang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ngaythang.Location = new System.Drawing.Point(524, 18);
            this.txt_ngaythang.Name = "txt_ngaythang";
            this.txt_ngaythang.Size = new System.Drawing.Size(112, 15);
            this.txt_ngaythang.TabIndex = 18;
            // 
            // btn_kiemtraphong
            // 
            this.btn_kiemtraphong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_kiemtraphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kiemtraphong.Location = new System.Drawing.Point(679, 56);
            this.btn_kiemtraphong.Name = "btn_kiemtraphong";
            this.btn_kiemtraphong.Size = new System.Drawing.Size(194, 31);
            this.btn_kiemtraphong.TabIndex = 21;
            this.btn_kiemtraphong.Text = "Kiểm tra phòng trống";
            this.btn_kiemtraphong.UseVisualStyleBackColor = false;
            // 
            // btn_datphong
            // 
            this.btn_datphong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_datphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datphong.Location = new System.Drawing.Point(169, 56);
            this.btn_datphong.Name = "btn_datphong";
            this.btn_datphong.Size = new System.Drawing.Size(162, 31);
            this.btn_datphong.TabIndex = 20;
            this.btn_datphong.Text = "Đặt phòng";
            this.btn_datphong.UseVisualStyleBackColor = false;
            // 
            // btn_goimon
            // 
            this.btn_goimon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_goimon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goimon.Location = new System.Drawing.Point(524, 56);
            this.btn_goimon.Name = "btn_goimon";
            this.btn_goimon.Size = new System.Drawing.Size(143, 31);
            this.btn_goimon.TabIndex = 22;
            this.btn_goimon.Text = "Gọi món";
            this.btn_goimon.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_nhantraphong;
        private System.Windows.Forms.ToolStripMenuItem ts_HoSo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_ngaythang;
        private System.Windows.Forms.Button btn_datphong;
        private System.Windows.Forms.Button btn_kiemtraphong;
        private System.Windows.Forms.ToolStripMenuItem ts_LoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem ts_Phong;
        private System.Windows.Forms.ToolStripMenuItem ts_DatPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_dsphong;
        private System.Windows.Forms.Button btn_goimon;
        private System.Windows.Forms.ToolStripMenuItem ts_DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem ts_HoaDon;
    }
}

