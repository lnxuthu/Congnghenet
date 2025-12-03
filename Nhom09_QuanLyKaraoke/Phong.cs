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
    public partial class Phong : Form
    {
        QLPHONG ql = new QLPHONG();
        public Phong()
        {
            InitializeComponent();
            this.btn_thoat.Click += Btn_thoat_Click;
            this.Load += Phong_Load;
            this.btn_them.Click += Btn_them_Click;
            this.btn_luu.Click += Btn_luu_Click;
            this.btn_xoa.Click += Btn_xoa_Click;
            this.btn_sua.Click += Btn_sua_Click;
            this.btn_tim.Click += Btn_tim_Click;
        }

        private void Btn_tim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txt_maphong.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập mã phòng hoặc số phòng cần tìm");
                return;
            }

            DataTable dt = ql.TimPhong(tuKhoa);

            if (dt.Rows.Count > 0)
            {
                dgv_dsphong.DataSource = dt;

                if (dgv_dsphong.Columns.Contains("MALOAI"))
                {
                    dgv_dsphong.Columns["MALOAI"].Visible = false;
                }
                if (dgv_dsphong.Columns.Contains("TENLOAI"))
                {
                    dgv_dsphong.Columns["TENLOAI"].HeaderText = "LOẠI PHÒNG";
                }

                MessageBox.Show($"Tìm thấy {dt.Rows.Count} phòng");
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng nào");

                // Load lại toàn bộ
                dgv_dsphong.DataSource = ql.Load_Phong();
                if (dgv_dsphong.Columns.Contains("MALOAI"))
                {
                    dgv_dsphong.Columns["MALOAI"].Visible = false;
                }
                if (dgv_dsphong.Columns.Contains("TENLOAI"))
                {
                    dgv_dsphong.Columns["TENLOAI"].HeaderText = "LOẠI PHÒNG";
                }
            }
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maphong = txt_maphong.Text.Trim();

                if (string.IsNullOrWhiteSpace(txt_sophong.Text))
                {
                    MessageBox.Show("Vui lòng chọn phòng cần sửa");
                    return;
                }

                int sophongmoi = Convert.ToInt32(txt_sophong.Text.Trim());
                string trangthaimoi = GetRadio();

                if (cbx_loaiphong.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn loại phòng");
                    return;
                }

                string maloaimoi = cbx_loaiphong.SelectedValue.ToString();

                if (ql.SuaPhong(maphong, sophongmoi, trangthaimoi, maloaimoi))
                {
                    MessageBox.Show("Sửa phòng thành công");

                    DataTable dt = ql.Load_Phong();
                    bsPhong.DataSource = dt;
                    bsPhong.ResetBindings(false);

                    DataBingding(dt);
                    if (dgv_dsphong.Columns.Contains("MALOAI"))
                    {
                        dgv_dsphong.Columns["MALOAI"].Visible = false;
                    }
                    if (dgv_dsphong.Columns.Contains("TENLOAI"))
                    {
                        dgv_dsphong.Columns["TENLOAI"].HeaderText = "LOẠI PHÒNG";
                    }
                }
                else
                {
                    MessageBox.Show("Sửa phòng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_dsphong.SelectedRows.Count > 0)
            {
                string map = dgv_dsphong.SelectedRows[0].Cells["MAPHONG"].Value.ToString();
                ql.XoaPhong(map);
                dgv_dsphong.Rows.Remove(dgv_dsphong.SelectedRows[0]);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void Btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                cls_PHONG dtp = new cls_PHONG();
                dtp.Maphong = txt_maphong.Text;
                dtp.Sophong = Convert.ToInt32(txt_sophong.Text);
                dtp.Maloai = cbx_loaiphong.SelectedValue?.ToString();
                dtp.Tinhtrang = GetRadio();

                if (ql.ThemPhong(dtp))
                {
                    if (ql.Luu())
                    {
                        MessageBox.Show("Lưu thành công");

                        txt_maphong.Clear();
                        txt_sophong.Clear();
                        cbx_loaiphong.Text = string.Empty;

                        txt_maphong.Enabled = false;
                        txt_sophong.Enabled = false;
                        cbx_loaiphong.Enabled = false;
                        rdb_dangsua.Enabled = false;
                        rdb_hoatdong.Enabled = false;
                        rdb_trong.Enabled = false;

                        dgv_dsphong.DataSource = ql.Load_Phong();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        //các radio button
        private string GetRadio()
        {
            if (rdb_trong.Checked)
                return "Trống";
            else if (rdb_hoatdong.Checked)
                return "Đang sử dụng";
            else if (rdb_dangsua.Checked)
                return "Đang sửa chữa";
            else
                return "Trống";
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            //enable
            txt_maphong.Enabled = true;
            txt_sophong.Enabled = true;
            cbx_loaiphong.Enabled = true;
            rdb_dangsua.Enabled = true;
            rdb_hoatdong.Enabled = true;
            rdb_trong.Enabled = true;

            //focus
            txt_maphong.Focus();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            //enable
            txt_maphong.Enabled = false;
            txt_sophong.Enabled = false;
            cbx_loaiphong.Enabled = false;
            rdb_dangsua.Enabled = false;
            rdb_hoatdong.Enabled = false;
            rdb_trong.Enabled = false;

            //load dgvPhong
            dgv_dsphong.DataSource = ql.Load_Phong();
            dgv_dsphong.ClearSelection();

            //load cboloaiphong
            cbx_loaiphong.DataSource = ql.Load_LoaiPhong();
            cbx_loaiphong.DisplayMember = "TENLOAI";
            cbx_loaiphong.ValueMember = "MALOAI";

            //hiện tên trên dgv thay vì mã loại
            if (dgv_dsphong.Columns.Contains("MALOAI"))
            {
                dgv_dsphong.Columns["MALOAI"].Visible = false;
            }

            // Đổi tên header cho cột ten loai
            if (dgv_dsphong.Columns.Contains("TENLOAI"))
            {
                dgv_dsphong.Columns["TENLOAI"].HeaderText = "LOẠI PHÒNG";
            }

            DataTable dt = ql.Load_Phong();
            bsPhong.DataSource = dt;
            dgv_dsphong.DataSource = bsPhong;

            DataBingding(dt);
        }
        public void DataBingding(DataTable pdata)
        {
            txt_maphong.DataBindings.Clear();
            txt_sophong.DataBindings.Clear();
            cbx_loaiphong.DataBindings.Clear();

            txt_maphong.DataBindings.Add("Text", pdata, "MAPHONG");
            txt_sophong.DataBindings.Add("Text", pdata, "SOPHONG");
            cbx_loaiphong.DataBindings.Add("SelectedValue", pdata, "MALOAI");

            bsPhong.PositionChanged -= bsPhong_PositionChanged;
            bsPhong.PositionChanged += bsPhong_PositionChanged;
        }
        private void bsPhong_PositionChanged(object sender, EventArgs e)
        {
            BindingSource bs = sender as BindingSource;

            if (bs != null && bs.Current != null)
            {
                DataRowView drv = bs.Current as DataRowView;
                if (drv != null && drv["TINHTRANG"] != DBNull.Value)
                {
                    string trangThai = drv["TINHTRANG"].ToString();

                    rdb_trong.Checked = (trangThai == "Trống");
                    rdb_hoatdong.Checked = (trangThai == "Đang sử dụng");
                    rdb_dangsua.Checked = (trangThai == "Đang sửa chữa");
                }
                else
                {
                    rdb_trong.Checked = false;
                    rdb_hoatdong.Checked = false;
                    rdb_dangsua.Checked = false;
                }
            }
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
