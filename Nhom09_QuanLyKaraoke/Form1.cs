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
        QLPHONGDANGSD qlpdsd = new QLPHONGDANGSD();   
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
            this.btn_nhanphong.Click += Btn_nhanphong_Click;
            this.ctm_GoiMon.Click += Ctm_GoiMon_Click;
            this.ctm_TraPhong.Click += Ctm_TraPhong_Click;
            this.dgv_dsphong.CellMouseDown += Dgv_dsphong_CellMouseDown;
            this.tsm_AnUong.Click += Tsm_AnUong_Click;
            this.ts_QLKhachHang.Click += Ts_QLKhachHang_Click;
            this.ts_HoaDon.Click += Ts_HoaDon_Click;
            this.ctm_DoiPhong.Click += Ctm_DoiPhong_Click;
            this.ts_DoanhThu.Click += Ts_DoanhThu_Click;
            this.ts_HoSo.Click += Ts_HoSo_Click;
            this.btn_tim.Click += Btn_tim_Click;
        }
        private void Btn_tim_Click(object sender, EventArgs e)
        {
            string SoPhongCanTim = txt_phong.Text.Trim();

            if (string.IsNullOrEmpty(SoPhongCanTim))
            {
                dgv_dsphong.DataSource = qlpdsd.Load_PhongDangSD();
            }
            else
            {
                dgv_dsphong.DataSource = qlpdsd.TimPhongTheoSoPhong(SoPhongCanTim);
            }
        }

        private void Ts_HoSo_Click(object sender, EventArgs e)
        {
            Formchild(new HoSo());
        }

        private void Ts_DoanhThu_Click(object sender, EventArgs e)
        {
            Formchild(new DoanhThu());
        }

        private void Ctm_DoiPhong_Click(object sender, EventArgs e)
        {
            Formchild(new DoiPhong());
        }

        private void Ts_HoaDon_Click(object sender, EventArgs e)
        {
            Formchild(new HoaDon());
        }


        private void Ts_QLKhachHang_Click(object sender, EventArgs e)
        {
            Formchild(new KhachHang());
        }

        private void Tsm_AnUong_Click(object sender, EventArgs e)
        {
            Formchild(new DichVu());
        }

        private void Dgv_dsphong_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    this.dgv_dsphong.ClearSelection();
                    this.dgv_dsphong.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void Ctm_TraPhong_Click(object sender, EventArgs e)
        {
            Formchild(new TraPhong());
        }

        private void Btn_nhanphong_Click(object sender, EventArgs e)
        {
            Formchild(new NhanPhong());
        }

        private void Ctm_GoiMon_Click(object sender, EventArgs e)
        {
            Formchild(new GoiDichVu());
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
            dgv_dsphong.DataSource = qlpdsd.Load_PhongDangSD();

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
