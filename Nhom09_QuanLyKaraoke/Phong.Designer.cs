namespace Nhom09_QuanLyKaraoke
{
    partial class Phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phong));
            this.grb_dsloaiphong = new System.Windows.Forms.GroupBox();
            this.dgv_dsphong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.grb_ttloaiphong = new System.Windows.Forms.GroupBox();
            this.txt_sophong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdb_hoatdong = new System.Windows.Forms.RadioButton();
            this.rdb_trong = new System.Windows.Forms.RadioButton();
            this.cbx_loaiphong = new System.Windows.Forms.ComboBox();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.grb_dsloaiphong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphong)).BeginInit();
            this.grb_ttloaiphong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_dsloaiphong
            // 
            this.grb_dsloaiphong.Controls.Add(this.dgv_dsphong);
            this.grb_dsloaiphong.Location = new System.Drawing.Point(237, 255);
            this.grb_dsloaiphong.Name = "grb_dsloaiphong";
            this.grb_dsloaiphong.Size = new System.Drawing.Size(626, 206);
            this.grb_dsloaiphong.TabIndex = 42;
            this.grb_dsloaiphong.TabStop = false;
            this.grb_dsloaiphong.Text = "Danh sách các phòng hát";
            // 
            // dgv_dsphong
            // 
            this.dgv_dsphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_dsphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsphong.Location = new System.Drawing.Point(3, 18);
            this.dgv_dsphong.Name = "dgv_dsphong";
            this.dgv_dsphong.RowHeadersWidth = 51;
            this.dgv_dsphong.RowTemplate.Height = 24;
            this.dgv_dsphong.Size = new System.Drawing.Size(620, 185);
            this.dgv_dsphong.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SỐ PHÒNG";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "LOẠI PHÒNG";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TRẠNG THÁI";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(768, 179);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(92, 33);
            this.btn_luu.TabIndex = 41;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(768, 140);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 33);
            this.btn_sua.TabIndex = 39;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(768, 101);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(92, 33);
            this.btn_xoa.TabIndex = 38;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(768, 62);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 33);
            this.btn_them.TabIndex = 37;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // grb_ttloaiphong
            // 
            this.grb_ttloaiphong.Controls.Add(this.txt_sophong);
            this.grb_ttloaiphong.Controls.Add(this.label4);
            this.grb_ttloaiphong.Controls.Add(this.radioButton3);
            this.grb_ttloaiphong.Controls.Add(this.rdb_hoatdong);
            this.grb_ttloaiphong.Controls.Add(this.rdb_trong);
            this.grb_ttloaiphong.Controls.Add(this.cbx_loaiphong);
            this.grb_ttloaiphong.Controls.Add(this.txt_maphong);
            this.grb_ttloaiphong.Controls.Add(this.label5);
            this.grb_ttloaiphong.Controls.Add(this.label2);
            this.grb_ttloaiphong.Controls.Add(this.label1);
            this.grb_ttloaiphong.Location = new System.Drawing.Point(237, 65);
            this.grb_ttloaiphong.Name = "grb_ttloaiphong";
            this.grb_ttloaiphong.Size = new System.Drawing.Size(525, 169);
            this.grb_ttloaiphong.TabIndex = 36;
            this.grb_ttloaiphong.TabStop = false;
            this.grb_ttloaiphong.Text = "Thông tin phòng";
            // 
            // txt_sophong
            // 
            this.txt_sophong.Location = new System.Drawing.Point(408, 37);
            this.txt_sophong.Name = "txt_sophong";
            this.txt_sophong.Size = new System.Drawing.Size(61, 22);
            this.txt_sophong.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số Phòng";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(383, 119);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(117, 20);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Đang sửa chữa";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdb_hoatdong
            // 
            this.rdb_hoatdong.AutoSize = true;
            this.rdb_hoatdong.Location = new System.Drawing.Point(245, 119);
            this.rdb_hoatdong.Name = "rdb_hoatdong";
            this.rdb_hoatdong.Size = new System.Drawing.Size(123, 20);
            this.rdb_hoatdong.TabIndex = 11;
            this.rdb_hoatdong.TabStop = true;
            this.rdb_hoatdong.Text = "Đang hoạt động";
            this.rdb_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rdb_trong
            // 
            this.rdb_trong.AutoSize = true;
            this.rdb_trong.Location = new System.Drawing.Point(137, 119);
            this.rdb_trong.Name = "rdb_trong";
            this.rdb_trong.Size = new System.Drawing.Size(85, 20);
            this.rdb_trong.TabIndex = 10;
            this.rdb_trong.TabStop = true;
            this.rdb_trong.Text = "Còn trống";
            this.rdb_trong.UseVisualStyleBackColor = true;
            // 
            // cbx_loaiphong
            // 
            this.cbx_loaiphong.FormattingEnabled = true;
            this.cbx_loaiphong.Location = new System.Drawing.Point(137, 72);
            this.cbx_loaiphong.Name = "cbx_loaiphong";
            this.cbx_loaiphong.Size = new System.Drawing.Size(151, 24);
            this.cbx_loaiphong.TabIndex = 9;
            // 
            // txt_maphong
            // 
            this.txt_maphong.Location = new System.Drawing.Point(137, 37);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(151, 22);
            this.txt_maphong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(495, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "PHÒNG HÁT";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.Location = new System.Drawing.Point(932, 19);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(99, 33);
            this.btn_thoat.TabIndex = 72;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(768, 216);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(92, 33);
            this.btn_tim.TabIndex = 73;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = false;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 473);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.grb_dsloaiphong);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.grb_ttloaiphong);
            this.Controls.Add(this.label3);
            this.Name = "Phong";
            this.Text = "Phòng Hát";
            this.grb_dsloaiphong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphong)).EndInit();
            this.grb_ttloaiphong.ResumeLayout(false);
            this.grb_ttloaiphong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_dsloaiphong;
        private System.Windows.Forms.DataGridView dgv_dsphong;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox grb_ttloaiphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdb_hoatdong;
        private System.Windows.Forms.RadioButton rdb_trong;
        private System.Windows.Forms.ComboBox cbx_loaiphong;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txt_sophong;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tim;
    }
}