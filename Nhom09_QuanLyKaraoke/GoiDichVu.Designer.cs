namespace Nhom09_QuanLyKaraoke
{
    partial class GoiDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoiDichVu));
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.grb_dsloaiphong = new System.Windows.Forms.GroupBox();
            this.dgv_dmon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.grb_dsloaiphong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dmon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(476, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "GỌI MÓN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Đơn giá";
            // 
            // txt_dongia
            // 
            this.txt_dongia.BackColor = System.Drawing.SystemColors.Control;
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(588, 73);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(139, 22);
            this.txt_dongia.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Chọn món ";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(506, 210);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(99, 33);
            this.btn_them.TabIndex = 60;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Số lượng";
            // 
            // txt_soluong
            // 
            this.txt_soluong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_soluong.Location = new System.Drawing.Point(588, 119);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(139, 22);
            this.txt_soluong.TabIndex = 64;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(328, 80);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(131, 163);
            this.treeView1.TabIndex = 66;
            // 
            // grb_dsloaiphong
            // 
            this.grb_dsloaiphong.Controls.Add(this.dgv_dmon);
            this.grb_dsloaiphong.Location = new System.Drawing.Point(328, 264);
            this.grb_dsloaiphong.Name = "grb_dsloaiphong";
            this.grb_dsloaiphong.Size = new System.Drawing.Size(399, 154);
            this.grb_dsloaiphong.TabIndex = 67;
            this.grb_dsloaiphong.TabStop = false;
            this.grb_dsloaiphong.Text = "Danh sách món đã chọn";
            // 
            // dgv_dmon
            // 
            this.dgv_dmon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dmon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_dmon.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_dmon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dmon.Location = new System.Drawing.Point(3, 18);
            this.dgv_dmon.Name = "dgv_dmon";
            this.dgv_dmon.RowHeadersWidth = 51;
            this.dgv_dmon.RowTemplate.Height = 24;
            this.dgv_dmon.Size = new System.Drawing.Size(393, 133);
            this.dgv_dmon.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TÊN MÓN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SỐ LƯỢNG";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctm_xoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 28);
            // 
            // ctm_xoa
            // 
            this.ctm_xoa.Name = "ctm_xoa";
            this.ctm_xoa.Size = new System.Drawing.Size(104, 24);
            this.ctm_xoa.Text = "Xoá";
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(628, 210);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(99, 33);
            this.btn_luu.TabIndex = 68;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
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
            this.btn_thoat.TabIndex = 70;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Tổng tiền";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.SystemColors.Control;
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(588, 167);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(139, 22);
            this.txt_tongtien.TabIndex = 72;
            // 
            // GoiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 473);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.grb_dsloaiphong);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label3);
            this.Name = "GoiDichVu";
            this.Text = "Gọi Món Ăn";
            this.grb_dsloaiphong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dmon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox grb_dsloaiphong;
        private System.Windows.Forms.DataGridView dgv_dmon;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_xoa;
    }
}