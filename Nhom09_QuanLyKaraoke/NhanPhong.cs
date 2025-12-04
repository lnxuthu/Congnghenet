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
    public partial class NhanPhong : Form
    {
        QLNHANPHONG qlnp = new QLNHANPHONG();
        public NhanPhong()
        {
            InitializeComponent();
            this.btn_thoat.Click += Btn_thoat_Click;
            this.btn_tim.Click += Btn_tim_Click;
            this.btn_nhanphong.Click += Btn_nhanphong_Click;
        }

        private void Btn_nhanphong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhận phòng thành công!");
        }

        private void Btn_tim_Click(object sender, EventArgs e)
        {
            string sdt = txt_sdt.Text;
            DataTable dtKetQua = qlnp.TimKhachDatPhong(sdt);

            if (dtKetQua.Rows.Count > 0)
            {
                txt_khnhan.Text = dtKetQua.Rows[0]["HOTEN"].ToString();
                txt_loaiphong.Text = dtKetQua.Rows[0]["TENLOAI"].ToString();
                txt_phong.Text = dtKetQua.Rows[0]["SOPHONG"].ToString();

                this.Tag = dtKetQua.Rows[0]["MAPHIEU"].ToString();
                MessageBox.Show("Tìm thấy thông tin đặt phòng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txt_khnhan.Clear();
                txt_loaiphong.Clear();
                txt_phong.Clear();
                this.Tag = null;
                MessageBox.Show("Không tìm thấy phiếu đặt phòng hợp lệ cho SĐT này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
