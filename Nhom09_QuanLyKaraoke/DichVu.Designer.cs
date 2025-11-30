namespace Nhom09_QuanLyKaraoke
{
    partial class DichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DichVu));
            this.label3 = new System.Windows.Forms.Label();
            this.grb_dsloaiphong = new System.Windows.Forms.GroupBox();
            this.dgv_dsmonan = new System.Windows.Forms.DataGridView();
            this.grb_ttloaiphong = new System.Windows.Forms.GroupBox();
            this.txt_maloaiphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_giacaodiem = new System.Windows.Forms.TextBox();
            this.txt_giabinhthuong = new System.Windows.Forms.TextBox();
            this.txt_tenloai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_dsloaiphong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsmonan)).BeginInit();
            this.grb_ttloaiphong.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(444, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "DỊCH VỤ ĂN UỐNG";
            // 
            // grb_dsloaiphong
            // 
            this.grb_dsloaiphong.Controls.Add(this.dgv_dsmonan);
            this.grb_dsloaiphong.Location = new System.Drawing.Point(235, 237);
            this.grb_dsloaiphong.Name = "grb_dsloaiphong";
            this.grb_dsloaiphong.Size = new System.Drawing.Size(641, 224);
            this.grb_dsloaiphong.TabIndex = 51;
            this.grb_dsloaiphong.TabStop = false;
            this.grb_dsloaiphong.Text = "Danh sách các món ăn";
            // 
            // dgv_dsmonan
            // 
            this.dgv_dsmonan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsmonan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsmonan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_dsmonan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsmonan.Location = new System.Drawing.Point(3, 18);
            this.dgv_dsmonan.Name = "dgv_dsmonan";
            this.dgv_dsmonan.RowHeadersWidth = 51;
            this.dgv_dsmonan.RowTemplate.Height = 24;
            this.dgv_dsmonan.Size = new System.Drawing.Size(635, 203);
            this.dgv_dsmonan.TabIndex = 10;
            // 
            // grb_ttloaiphong
            // 
            this.grb_ttloaiphong.Controls.Add(this.txt_maloaiphong);
            this.grb_ttloaiphong.Controls.Add(this.label5);
            this.grb_ttloaiphong.Controls.Add(this.txt_giacaodiem);
            this.grb_ttloaiphong.Controls.Add(this.txt_giabinhthuong);
            this.grb_ttloaiphong.Controls.Add(this.txt_tenloai);
            this.grb_ttloaiphong.Controls.Add(this.label4);
            this.grb_ttloaiphong.Controls.Add(this.label2);
            this.grb_ttloaiphong.Controls.Add(this.label1);
            this.grb_ttloaiphong.Location = new System.Drawing.Point(235, 60);
            this.grb_ttloaiphong.Name = "grb_ttloaiphong";
            this.grb_ttloaiphong.Size = new System.Drawing.Size(638, 120);
            this.grb_ttloaiphong.TabIndex = 50;
            this.grb_ttloaiphong.TabStop = false;
            this.grb_ttloaiphong.Text = "Thông tin món ăn";
            // 
            // txt_maloaiphong
            // 
            this.txt_maloaiphong.Location = new System.Drawing.Point(146, 27);
            this.txt_maloaiphong.Name = "txt_maloaiphong";
            this.txt_maloaiphong.Size = new System.Drawing.Size(150, 22);
            this.txt_maloaiphong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã món ăn";
            // 
            // txt_giacaodiem
            // 
            this.txt_giacaodiem.Location = new System.Drawing.Point(450, 69);
            this.txt_giacaodiem.Name = "txt_giacaodiem";
            this.txt_giacaodiem.Size = new System.Drawing.Size(150, 22);
            this.txt_giacaodiem.TabIndex = 6;
            // 
            // txt_giabinhthuong
            // 
            this.txt_giabinhthuong.Location = new System.Drawing.Point(450, 24);
            this.txt_giabinhthuong.Name = "txt_giabinhthuong";
            this.txt_giabinhthuong.Size = new System.Drawing.Size(150, 22);
            this.txt_giabinhthuong.TabIndex = 5;
            // 
            // txt_tenloai
            // 
            this.txt_tenloai.Location = new System.Drawing.Point(146, 69);
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Size = new System.Drawing.Size(150, 22);
            this.txt_tenloai.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng còn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món ăn";
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
            this.btn_thoat.TabIndex = 73;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(743, 186);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(92, 33);
            this.btn_tim.TabIndex = 78;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = false;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(622, 186);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(92, 33);
            this.btn_luu.TabIndex = 77;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(502, 186);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 33);
            this.btn_sua.TabIndex = 76;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(382, 186);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(92, 33);
            this.btn_xoa.TabIndex = 75;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(268, 186);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 33);
            this.btn_them.TabIndex = 74;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "MÃ MÓN";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TÊN MÓN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ĐƠN GIÁ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SỐ LƯỢNG CÒN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 473);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.grb_dsloaiphong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grb_ttloaiphong);
            this.Name = "DichVu";
            this.Text = "DỊch Vụ Ăn Uống";
            this.grb_dsloaiphong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsmonan)).EndInit();
            this.grb_ttloaiphong.ResumeLayout(false);
            this.grb_ttloaiphong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grb_dsloaiphong;
        private System.Windows.Forms.DataGridView dgv_dsmonan;
        private System.Windows.Forms.GroupBox grb_ttloaiphong;
        private System.Windows.Forms.TextBox txt_maloaiphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_giacaodiem;
        private System.Windows.Forms.TextBox txt_giabinhthuong;
        private System.Windows.Forms.TextBox txt_tenloai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}