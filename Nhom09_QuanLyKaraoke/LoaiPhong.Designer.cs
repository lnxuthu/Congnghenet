namespace Nhom09_QuanLyKaraoke
{
    partial class LoaiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiPhong));
            this.grb_dsloaiphong = new System.Windows.Forms.GroupBox();
            this.dgv_dsloaiphong = new System.Windows.Forms.DataGridView();
            this.grb_ttloaiphong = new System.Windows.Forms.GroupBox();
            this.txt_succhua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_maloaiphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_giaphong = new System.Windows.Forms.TextBox();
            this.txt_tenloai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCCHUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_dsloaiphong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsloaiphong)).BeginInit();
            this.grb_ttloaiphong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_dsloaiphong
            // 
            this.grb_dsloaiphong.Controls.Add(this.dgv_dsloaiphong);
            this.grb_dsloaiphong.Location = new System.Drawing.Point(507, 95);
            this.grb_dsloaiphong.Name = "grb_dsloaiphong";
            this.grb_dsloaiphong.Size = new System.Drawing.Size(521, 185);
            this.grb_dsloaiphong.TabIndex = 50;
            this.grb_dsloaiphong.TabStop = false;
            this.grb_dsloaiphong.Text = "Danh sách các loại phòng hát";
            // 
            // dgv_dsloaiphong
            // 
            this.dgv_dsloaiphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsloaiphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsloaiphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAI,
            this.TENLOAI,
            this.SUCCHUA,
            this.GIAPHONG});
            this.dgv_dsloaiphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsloaiphong.Location = new System.Drawing.Point(3, 18);
            this.dgv_dsloaiphong.Name = "dgv_dsloaiphong";
            this.dgv_dsloaiphong.RowHeadersWidth = 51;
            this.dgv_dsloaiphong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_dsloaiphong.RowTemplate.Height = 24;
            this.dgv_dsloaiphong.Size = new System.Drawing.Size(515, 164);
            this.dgv_dsloaiphong.TabIndex = 10;
            // 
            // grb_ttloaiphong
            // 
            this.grb_ttloaiphong.Controls.Add(this.txt_succhua);
            this.grb_ttloaiphong.Controls.Add(this.label6);
            this.grb_ttloaiphong.Controls.Add(this.txt_maloaiphong);
            this.grb_ttloaiphong.Controls.Add(this.label5);
            this.grb_ttloaiphong.Controls.Add(this.txt_giaphong);
            this.grb_ttloaiphong.Controls.Add(this.txt_tenloai);
            this.grb_ttloaiphong.Controls.Add(this.label2);
            this.grb_ttloaiphong.Controls.Add(this.label1);
            this.grb_ttloaiphong.Location = new System.Drawing.Point(49, 86);
            this.grb_ttloaiphong.Name = "grb_ttloaiphong";
            this.grb_ttloaiphong.Size = new System.Drawing.Size(419, 194);
            this.grb_ttloaiphong.TabIndex = 44;
            this.grb_ttloaiphong.TabStop = false;
            this.grb_ttloaiphong.Text = "Thông tin loại phòng";
            // 
            // txt_succhua
            // 
            this.txt_succhua.Location = new System.Drawing.Point(173, 109);
            this.txt_succhua.Name = "txt_succhua";
            this.txt_succhua.Size = new System.Drawing.Size(211, 22);
            this.txt_succhua.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sức chứa";
            // 
            // txt_maloaiphong
            // 
            this.txt_maloaiphong.Location = new System.Drawing.Point(173, 24);
            this.txt_maloaiphong.Name = "txt_maloaiphong";
            this.txt_maloaiphong.Size = new System.Drawing.Size(211, 22);
            this.txt_maloaiphong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã loại phòng";
            // 
            // txt_giaphong
            // 
            this.txt_giaphong.Location = new System.Drawing.Point(173, 149);
            this.txt_giaphong.Name = "txt_giaphong";
            this.txt_giaphong.Size = new System.Drawing.Size(211, 22);
            this.txt_giaphong.TabIndex = 5;
            // 
            // txt_tenloai
            // 
            this.txt_tenloai.Location = new System.Drawing.Point(173, 67);
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Size = new System.Drawing.Size(211, 22);
            this.txt_tenloai.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(472, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 26);
            this.label3.TabIndex = 43;
            this.label3.Text = "LOẠI PHÒNG HÁT";
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
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(815, 339);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(92, 33);
            this.btn_luu.TabIndex = 76;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(592, 339);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 33);
            this.btn_sua.TabIndex = 75;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(376, 339);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(92, 33);
            this.btn_xoa.TabIndex = 74;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(167, 339);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 33);
            this.btn_them.TabIndex = 73;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.HeaderText = "MÃ LOẠI";
            this.MALOAI.MinimumWidth = 6;
            this.MALOAI.Name = "MALOAI";
            // 
            // TENLOAI
            // 
            this.TENLOAI.DataPropertyName = "TENLOAI";
            this.TENLOAI.HeaderText = "TÊN LOẠI";
            this.TENLOAI.MinimumWidth = 6;
            this.TENLOAI.Name = "TENLOAI";
            // 
            // SUCCHUA
            // 
            this.SUCCHUA.DataPropertyName = "SUCCHUA";
            this.SUCCHUA.HeaderText = "SỨC CHỨA";
            this.SUCCHUA.MinimumWidth = 6;
            this.SUCCHUA.Name = "SUCCHUA";
            // 
            // GIAPHONG
            // 
            this.GIAPHONG.DataPropertyName = "GIAPHONG";
            this.GIAPHONG.HeaderText = "GIÁ PHÒNG";
            this.GIAPHONG.MinimumWidth = 6;
            this.GIAPHONG.Name = "GIAPHONG";
            // 
            // LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 473);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.grb_dsloaiphong);
            this.Controls.Add(this.grb_ttloaiphong);
            this.Controls.Add(this.label3);
            this.Name = "LoaiPhong";
            this.Text = "Loại Phòng Hát";
            this.grb_dsloaiphong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsloaiphong)).EndInit();
            this.grb_ttloaiphong.ResumeLayout(false);
            this.grb_ttloaiphong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_dsloaiphong;
        private System.Windows.Forms.DataGridView dgv_dsloaiphong;
        private System.Windows.Forms.GroupBox grb_ttloaiphong;
        private System.Windows.Forms.TextBox txt_maloaiphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_giaphong;
        private System.Windows.Forms.TextBox txt_tenloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_succhua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCCHUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAPHONG;
    }
}