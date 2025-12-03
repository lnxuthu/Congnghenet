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
    public partial class DatPhong : Form
    {
        QLDATPHONG qldatphong = new QLDATPHONG();
        public DatPhong()
        {
            InitializeComponent();
            this.btn_thoat.Click += Btn_thoat_Click;
            //this.Load += DatPhong_Load;
           // this.btn_datphong.Click += Btn_datphong_Click;

        }

        //private void Btn_datphong_Click(object sender, EventArgs e)
        //{
        //    // Lấy thông tin khách hàng
        //    string hoTen = txt_hoten.Text.Trim();
        //    string sdt = txt_sodienthoai.Text.Trim();
        //    string gioiTinh = GetGioiTinhTuRadioButtons(); // Viết hàm này để lấy 'Nam' hoặc 'Nữ'

        //    // Lấy thông tin đặt phòng
        //    string ngayDatText = txt_ngaydat.Text.Trim();
        //    string gioTuText = txt_giotudat.Text.Trim();
        //    string gioDenText = txt_giodendat.Text.Trim();

        //    // Giả sử bạn lấy mã phòng và mã loại từ DGV đã chọn
        //    string maPhong = txt_phong.Text.Trim(); // Lấy từ TextBox Phòng
        //    string maLoai = LayMaLoaiTuMaPhong(maPhong); // Cần tra cứu MALOAI từ MAPHONG
        //    decimal giaPhongMoiGio = LayGiaPhongTuMaLoai(maLoai); // Cần tra cứu GIAPHONG từ MALOAI

        //    // --- BƯỚC 1: Xử lý và Tính toán Thời gian/Tiền ---

        //    // Bạn cần sử dụng logic tính giờ đã sửa (dùng int để parse giờ, dùng DateTime để xử lý qua đêm)
        //    if (!DateTime.TryParse(ngayDatText, out DateTime ngayDat))
        //    {
        //        MessageBox.Show("Ngày đặt không hợp lệ."); return;
        //    }

        //    // Giả sử bạn đã có hàm tính toán này (bao gồm cả xử lý qua đêm)
        //    if (!TinhToanGioVaTien(ngayDat, gioTuText, gioDenText, giaPhongMoiGio,
        //                           out TimeSpan gioVaoTS, out TimeSpan gioRaTS, out decimal tongTien))
        //    {
        //        return; // Hàm tính toán đã báo lỗi nếu thất bại
        //    }

        //    // Cập nhật Tổng tiền lên TextBox (Tổng tiền này sẽ được lưu vào PHIEUDATPHONG)
        //    txt_tongtien.Text = tongTien.ToString("N0");

        //    // --- BƯỚC 2: Xử lý Khách hàng (Lưu vào KHACHHANG) ---

        //    QLKHACHHANG qlKh = new QLKHACHHANG();
        //    string maKhachHang = qlKh.GetMaKhachHangBySDT(sdt);

        //    if (string.IsNullOrEmpty(maKhachHang))
        //    {
        //        // Khách hàng mới: Thêm và lấy mã mới
        //        maKhachHang = qlKh.ThemKhachHang(hoTen, sdt, gioiTinh);
        //        if (string.IsNullOrEmpty(maKhachHang))
        //        {
        //            MessageBox.Show("Lỗi: Không thể thêm khách hàng mới."); return;
        //        }
        //    }
        //    // Ghi chú: Nếu KH đã tồn tại, bạn có thể chọn bỏ qua việc cập nhật thông tin cũ 
        //    // hoặc thêm hàm cập nhật nếu thông tin (như tên) có thay đổi.

        //    // --- BƯỚC 3: Lưu Phiếu đặt phòng (Lưu vào PHIEUDATPHONG) ---

        //    QLDATPHONG qlPdp = new QLDATPHONG();

        //    cls_PHIEUDATPHONG dtpdp = new cls_PHIEUDATPHONG
        //    {
        //        // Cần có hàm tự động tạo MAPHIEU mới
        //        Maphieu = qlPdp.TaoMaPhieuMoi(),
        //        Ngaydat = ngayDat,
        //        Giovao = gioVaoTS,
        //        Giora = gioRaTS,
        //        Makh = maKhachHang,
        //        Maloai = maLoai,
        //        Maphong = maPhong,
        //        Manv = null, // Giả sử phiếu đặt qua Form KH nên MANV là NULL
        //        Tongtien = tongTien
        //    };

        //    if (qlPdp.ThemPhieuDatPhong(dtpdp))
        //    {
        //        // --- BƯỚC 4: Cập nhật Trạng thái Phòng ---
        //        // Thường khi đặt phòng, trạng thái PHONG chưa đổi (vẫn Trống). 
        //        // Nó chỉ đổi khi nhấn "Nhận phòng". Nhưng bạn có thể đổi TINHTRANG thành 'Đã đặt' (nếu có)
        //        // qlPhong.CapNhatTrangThai(maPhong, "Đã đặt"); 

        //        MessageBox.Show($"Đặt phòng thành công! Phiếu: {dtpdp.Maphieu} đã được tạo.");
        //        // Sau đó bạn cần Refresh DGV Phòng
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lỗi: Không thể lưu thông tin đặt phòng.");
        //    }
        //}

        //private double TinhSoGioHat(TimeSpan gioVao, TimeSpan gioRa)
        //{
        //    double soGio = 0;
        //    if (gioRa < gioVao)
        //    {
        //        TimeSpan denCuoiNgay = TimeSpan.FromHours(24) - gioVao;
        //        TimeSpan tuDauNgay = gioRa;
        //        soGio = (denCuoiNgay + tuDauNgay).TotalHours;
        //    }
        //    else
        //    {
        //        soGio = (gioRa - gioVao).TotalHours;
        //    }
        //    soGio = Math.Ceiling(soGio);

        //    return soGio;
        //}
        //private void DatPhong_Load(object sender, EventArgs e)
        //{
        //    //dgv_dsphongtrong.DataSource = qldatphong.Load_DatPhong();
        //    //dgv_dsphongtrong.ClearSelection();

        //    //if (dgv_dsphongtrong.Columns.Contains("MAPHONG"))
        //    //{
        //    //    dgv_dsphongtrong.Columns["MAPHONG"].Visible = false;
        //    //}

        //    //if (dgv_dsphongtrong.Columns.Contains("MALOAI"))
        //    //{
        //    //    dgv_dsphongtrong.Columns["MALOAI"].Visible = false;
        //    //}
        //}

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
