namespace Nhom09_QuanLyKaraoke
{
    partial class KhachHang
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
            this.grb_ttcanhan = new System.Windows.Forms.GroupBox();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_ttcanhan.SuspendLayout();
            this.SuspendLayout();
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
            this.grb_ttcanhan.Location = new System.Drawing.Point(353, 74);
            this.grb_ttcanhan.Name = "grb_ttcanhan";
            this.grb_ttcanhan.Size = new System.Drawing.Size(379, 150);
            this.grb_ttcanhan.TabIndex = 39;
            this.grb_ttcanhan.TabStop = false;
            this.grb_ttcanhan.Text = "Thông tin khách hàng";
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Location = new System.Drawing.Point(196, 102);
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
            this.rdb_nam.Location = new System.Drawing.Point(122, 102);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(57, 20);
            this.rdb_nam.TabIndex = 7;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Nam";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(122, 68);
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
            this.label5.Location = new System.Drawing.Point(24, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 71);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(412, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 473);
            this.Controls.Add(this.grb_ttcanhan);
            this.Controls.Add(this.label3);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.grb_ttcanhan.ResumeLayout(false);
            this.grb_ttcanhan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_ttcanhan;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.RadioButton rdb_nam;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}