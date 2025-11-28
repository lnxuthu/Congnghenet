namespace Nhom09_QuanLyKaraoke
{
    partial class KiemTraPhong
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_phongtrong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_loaiphong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(381, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "KIỂM TRA PHÒNG TRỐNG";
            // 
            // txt_phongtrong
            // 
            this.txt_phongtrong.BackColor = System.Drawing.SystemColors.Control;
            this.txt_phongtrong.Enabled = false;
            this.txt_phongtrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phongtrong.Location = new System.Drawing.Point(526, 142);
            this.txt_phongtrong.Name = "txt_phongtrong";
            this.txt_phongtrong.Size = new System.Drawing.Size(105, 22);
            this.txt_phongtrong.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(410, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Phòng còn trống";
            // 
            // cmb_loaiphong
            // 
            this.cmb_loaiphong.FormattingEnabled = true;
            this.cmb_loaiphong.Location = new System.Drawing.Point(529, 97);
            this.cmb_loaiphong.Name = "cmb_loaiphong";
            this.cmb_loaiphong.Size = new System.Drawing.Size(102, 24);
            this.cmb_loaiphong.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Loại phòng";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(526, 191);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(105, 78);
            this.listView1.TabIndex = 49;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Số phòng trống";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(482, 296);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(112, 33);
            this.btn_thoat.TabIndex = 51;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // KiemTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 473);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txt_phongtrong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_loaiphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "KiemTraPhong";
            this.Text = "KiemTraPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_phongtrong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_loaiphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_thoat;
    }
}