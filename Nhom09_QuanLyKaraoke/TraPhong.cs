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
    public partial class TraPhong : Form
    {
        QLTRAPHONG qltp = new QLTRAPHONG();
        public TraPhong()
        {
            InitializeComponent();
            this.btn_thoat.Click += Btn_thoat_Click;
            //this.btn_xacnhan.Click += Btn_xacnhan_Click;
        }

        //private void Btn_xacnhan_Click(object sender, EventArgs e)
        //{
        //    string soPhong = txt_phong.Text;

        //    DataTable dtNhanPhong = qltp.Load_TraPhong(soPhong);

        //    if (dtNhanPhong.Rows.Count > 0)
        //    {
        //        DataRow row = dtNhanPhong.Rows[0];
        //        txt_khachtra.Text = row["TenKhachHang"].ToString();
        //        txt_sdt.Text = row["SDT"].ToString();
        //        txt_ngay.Text = DateTime.Today.ToShortDateString();
        //        txt_giovao.Text = row["GIOVAO"].ToString();
        //        txt_giora.Text = row["GIORA"].ToString();

        //        decimal giaHatMoiGio = Convert.ToDecimal(row["GIAPHONG"]);
        //        string maPhieuNhan = row["MAPHIEUNHAN"].ToString();
        //        string maKhachHang = row["MAKH"].ToString();

        //        TinhToanVaHienThiTien(row);

        //        Load_DichVu(maPhieuNhan);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không tìm thấy phòng đang sử dụng hoặc thông tin không hợp lệ.");
        //    }
        //}
        //private void TinhToanVaHienThiTien(DataRow rowNhanPhong)
        //{
        //    TimeSpan gioVao = (TimeSpan)rowNhanPhong["GIOVAO"];
        //    TimeSpan gioRa = (TimeSpan)rowNhanPhong["GIORA"];
        //    decimal giaHatMoiGio = Convert.ToDecimal(rowNhanPhong["GIAPHONG"]);
        //    string maPhieuNhan = rowNhanPhong["MAPHIEUNHAN"].ToString();

        //    TimeSpan thoiGianHat = gioRa - gioVao;

        //    if (thoiGianHat.TotalHours < 0)
        //    {
        //        thoiGianHat = thoiGianHat.Add(new TimeSpan(24, 0, 0));
        //    }

        //    double soGio = thoiGianHat.TotalHours;
        //    decimal tongTienHat = (decimal)soGio * giaHatMoiGio;

        //    decimal tongTienDichVu = qlThanhToan.TinhTongTienDichVu(maPhieuNhan);


        //    txt_thoigianhat.Text = $"{soGio:N1} giờ";
        //    txt_giahath.Text = tongTienHat.ToString("N0");
        //    txt_giadichvu.Text = tongTienDichVu.ToString("N0");

        //    decimal tongThanhToan = tongTienHat + tongTienDichVu;
        //    txt_tongthanhtoan.Text = tongThanhToan.ToString("N0");

        //    _TongTienCanThanhToan = tongThanhToan;
        //}
        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
