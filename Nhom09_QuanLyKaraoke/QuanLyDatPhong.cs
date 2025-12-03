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
    public partial class QuanLyDatPhong : Form
    {
        QLPHIEUDATPHONG qlpdp = new QLPHIEUDATPHONG();

        public QuanLyDatPhong()
        {
            InitializeComponent();
            this.btn_thoat.Click += Btn_thoat_Click;
            this.btn_them.Click += Btn_them_Click;
            this.btn_luu.Click += Btn_luu_Click;
            this.Load += QuanLyDatPhong_Load;
        }
        private void Btn_luu_Click(object sender, EventArgs e)
        {
            cls_PHIEUDATPHONG dtpdp = new cls_PHIEUDATPHONG();
            dtpdp.Maphieu = txt_maphieu.Text;
            DateTime ngaydat;
            if (DateTime.TryParse(txt_ngaydat.Text, out ngaydat))
            {
                dtpdp.Ngaydat = ngaydat;
            }
            else
            {
                MessageBox.Show("Ngày đặt không hợp lệ");
                return;
            }
            DateTime giovao, giora;
            if (DateTime.TryParse(txt_giobatdau.Text, out giovao) &&
                DateTime.TryParse(txt_gioketthuc.Text, out giora))
            {
                dtpdp.Giovao = giovao.TimeOfDay;
                dtpdp.Giora = giora.TimeOfDay;
            }
            else
            {
                MessageBox.Show("Giờ vào hoặc giờ ra không hợp lệ");
                return;
            }
            dtpdp.Makhachhang = cbo_makh.SelectedValue?.ToString();
            dtpdp.Maloai = cmb_loaiphong.SelectedValue?.ToString();
            dtpdp.Maphong = txt_phong.Text;
            dtpdp.Manhanvien = txt_manv.Text;
            dtpdp.Tongtien = float.Parse(txt_tongtien.Text);

            if (qlpdp.ThemPhieuDatPhong(dtpdp))
            {
                if (qlpdp.Luu())
                {
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    MessageBox.Show("Lưu thất bại trong cơ sở dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
            txt_maphieu.Clear();
            txt_ngaydat.Clear();
            txt_giobatdau.Clear();
            txt_gioketthuc.Clear();
            cbo_makh.Text = string.Empty;
            cmb_loaiphong.Text = string.Empty;
            txt_phong.Clear();
            txt_manv.Clear();
            txt_tongtien.Clear();

            DataTable kqpdp = qlpdp.Load_PhieuDatPhong();
            DataBingdingPDP(kqpdp);
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            txt_maphieu.Enabled = true;
            txt_ngaydat.Enabled = true;
            txt_giobatdau.Enabled = true;
            txt_gioketthuc.Enabled = true;
            cbo_makh.Enabled = true;
            cmb_loaiphong.Enabled = true;
            txt_phong.Enabled = true;
            txt_manv.Enabled = true;
            txt_tongtien.Enabled = true;
        }
        public void DataBingdingPDP(DataTable pdata)
        {
            txt_maphieu.DataBindings.Clear();
            txt_ngaydat.DataBindings.Clear();
            txt_giobatdau.DataBindings.Clear();
            txt_gioketthuc .DataBindings.Clear();
            cbo_makh.DataBindings.Clear();
            cmb_loaiphong.DataBindings.Clear();
            txt_phong.DataBindings.Clear();
            txt_manv.DataBindings.Clear();
            txt_tongtien.DataBindings.Clear();

            txt_maphieu.DataBindings.Add("Text", pdata, "MAPHIEU");
            txt_ngaydat.DataBindings.Add("Text", pdata, "NGAYDAT");
            txt_giobatdau.DataBindings.Add("Text", pdata, "GIOVAO");
            txt_gioketthuc.DataBindings.Add("Text", pdata, "GIORA");
            cbo_makh.DataBindings.Add("Text", pdata, "MAKH");
            cmb_loaiphong.DataBindings.Add("SelectedValue", pdata, "MALOAI");
            txt_phong.DataBindings.Add("Text", pdata, "MAPHONG");
            txt_manv.DataBindings.Add("Text", pdata, "MANV");
            txt_tongtien.DataBindings.Add("Text", pdata, "TONGTIEN");
        }
        private void QuanLyDatPhong_Load(object sender, EventArgs e)
        {
            //load cbo loại phòng
            cmb_loaiphong.DataSource = qlpdp.Load_LoaiPhongPDP();
            cmb_loaiphong.DisplayMember = "TENLOAI";
            cmb_loaiphong.ValueMember = "MALOAI";

            //load cbo loại phòng
            cbo_makh.DataSource = qlpdp.Load_KhachHangPDP();
            cbo_makh.DisplayMember = "MAKH";
            cbo_makh.ValueMember = "MAKH";

            txt_maphieu.Enabled = false;
            txt_ngaydat.Enabled = false;
            txt_giobatdau.Enabled = false;
            txt_gioketthuc.Enabled = false;
            cbo_makh.Enabled = false;
            cmb_loaiphong.Enabled = false;
            txt_phong.Enabled = false;
            txt_manv.Enabled = false;
            txt_tongtien.Enabled = false;

            //if (dgv_dsphieudatphong.Columns.Contains("MALOAI"))
            //    dgv_dsphieudatphong.Columns["MALOAI"].Visible = false;

            //if (dgv_dsphieudatphong.Columns.Contains("MAPHONG"))
            //    dgv_dsphieudatphong.Columns["MAPHONG"].Visible = false;

            //if (dgv_dsphieudatphong.Columns.Contains("LOAIPHONG"))
            //    dgv_dsphieudatphong.Columns["LOAIPHONG"].HeaderText = "LOẠI PHÒNG";

            //if (dgv_dsphieudatphong.Columns.Contains("MAPHONG"))
            //    dgv_dsphieudatphong.Columns["MAPHONG"].HeaderText = "SỐ PHÒNG";

            DataTable dtPdp = qlpdp.Load_PhieuDatPhong();
            dgv_dsphieudatphong.DataSource = dtPdp;
            DataBingdingPDP(dtPdp);
        }
        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
