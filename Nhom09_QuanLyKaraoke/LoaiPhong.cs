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
    public partial class LoaiPhong : Form
    {
        QLPHONG ql =new QLPHONG();
        public LoaiPhong()
        {
            InitializeComponent();
            this.btn_thoat.Click += Btn_thoat_Click;
            this.Load += LoaiPhong_Load;
            this.btn_them.Click += Btn_them_Click;
            this.btn_luu.Click += Btn_luu_Click;
            this.btn_xoa.Click += Btn_xoa_Click;
            this.btn_sua.Click += Btn_sua_Click;
            this.dgv_dsloaiphong.CellClick += Dgv_dsloaiphong_CellClick;
        }

        private void Dgv_dsloaiphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_dsloaiphong.Rows[e.RowIndex];
                // Load dữ liệu từ dòng được chọn vào TextBox
                txt_maloaiphong.Text = row.Cells["MALOAI"].Value?.ToString() ?? "";
                txt_tenloai.Text = row.Cells["TENLOAI"].Value?.ToString() ?? "";
                txt_succhua.Text = row.Cells["SUCCHUA"].Value?.ToString() ?? "";
                txt_giaphong.Text = row.Cells["GIAPHONG"].Value?.ToString() ?? "";
                // Enable các textbox để sửa
                txt_maloaiphong.Enabled = false;
                txt_tenloai.Enabled = true;
                txt_succhua.Enabled = true;
                txt_giaphong.Enabled = true;
            }
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            string maloai = txt_maloaiphong.Text;
            string tenloaimoi = txt_tenloai.Text;
            //MessageBox.Show($"Giá trị txt_succhua: [{txt_succhua.Text}] - Length: {txt_succhua.Text.Length}");
            int newsucchua = int.Parse(txt_succhua.Text);
            float newgia = float.Parse(txt_giaphong.Text);
            if (ql.SuaLoaiPhong(maloai, tenloaimoi, newsucchua, newgia))
            {
                if (ql.Luu())
                {
                    MessageBox.Show("Sửa loại phòng thành công");
                    dgv_dsloaiphong.DataSource = ql.Load_LoaiPhong();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại trong cơ sở dữ liệu");
                }
                    
            }
            else
            {
                MessageBox.Show("Sửa loại phòng thất bại");
            }
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_dsloaiphong.SelectedRows.Count > 0)
            {
                string malp = dgv_dsloaiphong.SelectedRows[0].Cells["MALOAI"].Value.ToString();
                ql.XoaLoaiPhong(malp);
                dgv_dsloaiphong.Rows.Remove(dgv_dsloaiphong.SelectedRows[0]);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void Btn_luu_Click(object sender, EventArgs e)
        {
            cls_LOAIPHONG dtlp = new cls_LOAIPHONG();
            dtlp.Maloai = txt_maloaiphong.Text;
            dtlp.Tenloai = txt_tenloai.Text;
            dtlp.Succhua = Convert.ToInt32(txt_succhua.Text);
            dtlp.Giaphong = float.Parse(txt_giaphong.Text);

            if (ql.ThemLoaiPhong(dtlp))
            {
                if (ql.Luu())
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
            txt_maloaiphong.Clear();
            txt_tenloai.Clear();
            txt_succhua.Clear();
            txt_giaphong.Clear();
            
            DataTable kq = ql.Load_LoaiPhong();
            DataBingding(kq);
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            //enable
            txt_maloaiphong.Enabled = true;
            txt_tenloai.Enabled = true;
            txt_succhua.Enabled = true;
            txt_giaphong.Enabled = true;

            //focus
            txt_maloaiphong.Focus();
        }

        private void LoaiPhong_Load(object sender, EventArgs e)
        {
            //enable
            txt_maloaiphong.Enabled = false;
            txt_tenloai.Enabled = false;
            txt_succhua.Enabled = false;
            txt_giaphong.Enabled = false;
            //load datagridview loaiphong
            dgv_dsloaiphong.DataSource = ql.Load_LoaiPhong();
            dgv_dsloaiphong.ClearSelection();
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DataBingding(DataTable pdata)
        {
            txt_maloaiphong.DataBindings.Clear();
            txt_tenloai.DataBindings.Clear();
            txt_succhua.DataBindings.Clear();
            txt_giaphong.DataBindings.Clear();

            txt_maloaiphong.DataBindings.Add("Text", pdata, "MALOAI");
            txt_tenloai.DataBindings.Add("Text", pdata, "TENLOAI");
            txt_succhua.DataBindings.Add("Text", pdata, "SUCCHUA");
            txt_giaphong.DataBindings.Add("Text", pdata, "GIAPHONG");
        }
    }
}
