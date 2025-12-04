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
            this.btn_huy.Click += Btn_huy_Click;
            this.btn_sua.Click += Btn_sua_Click;
            this.btn_tim.Click += Btn_tim_Click;
        }

        private void Btn_tim_Click(object sender, EventArgs e)
        {
            if (cbo_makh.SelectedValue != null)
            {
                string maKHDaChon = cbo_makh.SelectedValue.ToString();

                DataTable dttimphieu = qlpdp.TimPhieuTheoMaKH(maKHDaChon);

                dgv_dsphieudatphong.DataSource = dttimphieu;
                DataBingdingPDP(dttimphieu);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Mã khách hàng để tìm kiếm phiếu đặt.");
            }
        }

        private void Cbo_makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_makh.SelectedValue != null)
            {
                string maKHDaChon = cbo_makh.SelectedValue.ToString();
                DataTable dttimphieu = qlpdp.TimPhieuTheoMaKH(maKHDaChon);

                dgv_dsphieudatphong.DataSource = dttimphieu;

                DataBingdingPDP(dttimphieu);
            }
            
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            string maphieu = txt_maphieu.Text;
            DateTime ngaydatmoi;
            TimeSpan giovaomoi;
            TimeSpan gioramoi;
            if (!DateTime.TryParse(txt_ngaydat.Text, out ngaydatmoi))
            {
                MessageBox.Show("Ngày đặt không hợp lệ.");
                return;
            }
            
            if (!TimeSpan.TryParse(txt_giobatdau.Text, out giovaomoi))
            {
                MessageBox.Show("Giờ bắt đầu (Giờ vào) không hợp lệ.");
                return;
            }
            if (!TimeSpan.TryParse(txt_gioketthuc.Text, out gioramoi))
            {
                MessageBox.Show("Giờ kết thúc (Giờ ra) không hợp lệ.");
                return;
            }

            string makhmoi = cbo_makh.SelectedValue?.ToString();
            string loaiphongmoi = cmb_loaiphong.SelectedValue?.ToString();
            string phongmoi = txt_phong.Text;
            string manvmoi = txt_manv.Text;
            float tongtienmoi = float.Parse(txt_tongtien.Text);


            // ==========================================================
            // TÍNH TOÁN LẠI TỔNG TIỀN
            // ==========================================================

            float giaPhongMotGio = qlpdp.TimGiaPhong(loaiphongmoi);

            if (giaPhongMotGio <= 0)
            {
                MessageBox.Show("Không tìm thấy giá cho loại phòng này hoặc loại phòng không hợp lệ.");
                return;
            }
            TimeSpan thoiGianSuDung = gioramoi.Subtract(giovaomoi);

            if (thoiGianSuDung.TotalHours <= 0)
            {
                MessageBox.Show("Giờ ra phải lớn hơn Giờ vào.");
                return;
            }
            tongtienmoi = (float)thoiGianSuDung.TotalHours * giaPhongMotGio;
            txt_tongtien.Text = tongtienmoi.ToString();

            if (qlpdp.SuaPhieuDatPhong(maphieu, ngaydatmoi, giovaomoi, gioramoi, makhmoi, loaiphongmoi, phongmoi, manvmoi, tongtienmoi))
            {
                if (qlpdp.Luu())
                {
                    MessageBox.Show("Sửa phiếu đặt phòng thành công");
                    dgv_dsphieudatphong.DataSource = qlpdp.Load_PhieuDatPhong();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại trong cơ sở dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Sửa phiếu đặt phòng thất bại");
            }

        }

        private void Btn_huy_Click(object sender, EventArgs e)
        {
            if (dgv_dsphieudatphong.SelectedRows.Count > 0)
            {
                string mapdp = dgv_dsphieudatphong.SelectedRows[0].Cells["MAPHIEU"].Value.ToString();
                qlpdp.HuyPhieuDatPhong(mapdp);
                dgv_dsphieudatphong.Rows.Remove(dgv_dsphieudatphong.SelectedRows[0]);
                MessageBox.Show("Hủy phiếu đặt thành công");
            }
            else
            {
                MessageBox.Show("Hủy phiếu đặt thất bại");
            }
        }

        private void Btn_luu_Click(object sender, EventArgs e)
        {
            cls_PHIEUDATPHONG dtpdp = new cls_PHIEUDATPHONG();
            dtpdp.Maphieu = txt_maphieu.Text;

            DateTime ngaydat;
            if (!DateTime.TryParse(txt_ngaydat.Text, out ngaydat))
            {
                MessageBox.Show("Ngày đặt không hợp lệ");
                return;
            }

            TimeSpan giovaomoi;
            TimeSpan gioramoi;
            if (!TimeSpan.TryParse(txt_giobatdau.Text, out giovaomoi))
            {
                MessageBox.Show("Giờ bắt đầu (Giờ vào) không hợp lệ.");
                return;
            }
            if (!TimeSpan.TryParse(txt_gioketthuc.Text, out gioramoi))
            {
                MessageBox.Show("Giờ kết thúc (Giờ ra) không hợp lệ.");
                return;
            }

            dtpdp.Ngaydat = ngaydat;
            dtpdp.Giovao = giovaomoi;
            dtpdp.Giora = gioramoi;
            dtpdp.Makhachhang = cbo_makh.SelectedValue?.ToString();
            string maLoaiPhong = cmb_loaiphong.SelectedValue?.ToString();
            dtpdp.Maloai = maLoaiPhong;
            dtpdp.Maphong = txt_phong.Text;
            dtpdp.Manhanvien = txt_manv.Text;

            float tongtienmoi = TinhTongTienUocTinh(ngaydat, giovaomoi, gioramoi, maLoaiPhong);

            if (tongtienmoi == -1f)
            {
                return;
            }

            if (ngaydat.Date == DateTime.Today)
            {

                tongtienmoi = 0f;
                MessageBox.Show("Phiếu đặt phòng trong ngày hôm nay sẽ có Tổng tiền ban đầu là 0.");
            }

            dtpdp.Tongtien = tongtienmoi;
            txt_tongtien.Text = tongtienmoi.ToString("N0");
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

            // Reset form và Load lại dữ liệu
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
        private float TinhTongTienUocTinh(DateTime ngayDat, TimeSpan gioVao, TimeSpan gioRa, string maLoaiPhong)
        {
            DateTime thoiDiemVao = ngayDat.Date.Add(gioVao);
            DateTime thoiDiemRa = ngayDat.Date.Add(gioRa);

            if (thoiDiemRa <= thoiDiemVao)
            {
                thoiDiemRa = thoiDiemRa.AddDays(1);
            }

            TimeSpan thoiGianSuDung = thoiDiemRa.Subtract(thoiDiemVao);

            if (thoiGianSuDung.TotalHours <= 0)
            {
                MessageBox.Show("Giờ ra phải lớn hơn Giờ vào.", "Lỗi Thời Gian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1f;
            }

            float giaPhongMotGio = qlpdp.TimGiaPhong(maLoaiPhong);

            if (giaPhongMotGio <= 0)
            {
                MessageBox.Show("Không tìm thấy giá cho loại phòng này hoặc loại phòng không hợp lệ.", "Lỗi Giá", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1f;
            }

            float tongTien = (float)thoiGianSuDung.TotalHours * giaPhongMotGio;
            return tongTien;
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

            txt_maphieu.Clear();
            txt_ngaydat.Clear();
            txt_giobatdau.Clear();
            txt_gioketthuc.Clear();
            cbo_makh.Text = string.Empty;
            cmb_loaiphong.Text = string.Empty;
            txt_phong.Clear();
            txt_manv.Clear();
            txt_tongtien.Clear();
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
