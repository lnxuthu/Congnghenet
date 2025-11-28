using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom09_QuanLyKaraoke
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.Load += Form1_Load;
            this.ts_QLNhanSu.Click += Ts_QLNhanSu_Click;
            this.ts_LoaiPhong.Click += Ts_LoaiPhong_Click;
            this.ts_Phong.Click += Ts_Phong_Click;
            this.btn_datphong.Click += Btn_datphong_Click;
            this.ts_DatPhong.Click += Ts_DatPhong_Click;
            this.btn_kiemtraphong.Click += Btn_kiemtraphong_Click;
            this.btn_nhantraphong.Click += Btn_nhantraphong_Click;
            this.btn_dichvu.Click += Btn_dichvu_Click;
        }

        private void Btn_dichvu_Click(object sender, EventArgs e)
        {
            Formchild(new GoiDichVu());
        }

        private void Btn_nhantraphong_Click(object sender, EventArgs e)
        {
            Formchild(new NhanTraPhong());
        }

        private void Btn_kiemtraphong_Click(object sender, EventArgs e)
        {
            Formchild(new KiemTraPhong());
        }

        private void Ts_DatPhong_Click(object sender, EventArgs e)
        {
            Formchild(new QuanLyDatPhong());
        }

        private void Btn_datphong_Click(object sender, EventArgs e)
        {
            Formchild(new DatPhong());
        }

        private void Ts_Phong_Click(object sender, EventArgs e)
        {
            Formchild(new Phong());
        }

        private void Ts_LoaiPhong_Click(object sender, EventArgs e)
        {
            Formchild(new LoaiPhong());
        }

        private void Ts_QLNhanSu_Click(object sender, EventArgs e)
        {
            Formchild(new Nhanvien());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lấy ngày hiện tại cho trang chính
            txt_ngaythang.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        //mở các form con quản lý
        private Form fchild = null;
        private void Formchild(Form c)
        {
            if (fchild != null)
            {
                fchild.Close();
            }
            tableLayoutPanel1.Visible = false;
            c.MdiParent = this; // form con hiển thị trong form chính
            c.FormClosed += C_FormClosed; // gán sự kiện đóng form con
            c.FormBorderStyle = FormBorderStyle.None;
            c.Dock = DockStyle.Fill;
            c.Show();
            fchild = c;
        }
        private void C_FormClosed(object sender, FormClosedEventArgs e)
        {
            fchild = null;
            tableLayoutPanel1.Visible = true; // hiện lại hoạt động trong ngày
        }

    }
}
