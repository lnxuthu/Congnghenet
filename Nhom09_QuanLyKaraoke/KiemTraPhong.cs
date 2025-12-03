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
    public partial class KiemTraPhong : Form
    {
        QLTIMPHONG tp = new QLTIMPHONG();
        public KiemTraPhong()
        {
            InitializeComponent();
            this.btn_thoat.Click += Btn_thoat_Click;
            this.Load += KiemTraPhong_Load;
            this.cmb_loaiphong.SelectedIndexChanged += Cmb_loaiphong_SelectedIndexChanged;
        }

        private void Cmb_loaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_loaiphong.SelectedValue != null)
            {
                string maLoaiDaChon = cmb_loaiphong.SelectedValue.ToString();
                DataTable dtPhongTrong = tp.TimPhongTrongTheoLoai(maLoaiDaChon);

                txt_phongtrong.Text = dtPhongTrong.Rows.Count.ToString();
                lv_phongtrong.Items.Clear();

                lv_phongtrong.View = View.List;
                foreach (DataRow row in dtPhongTrong.Rows)
                {
                    string soPhong = row["SOPHONG"].ToString();
                    ListViewItem item = new ListViewItem(soPhong);
                    item.Tag = row["MAPHONG"].ToString();
                    lv_phongtrong.Items.Add(item);
                }
            }
            else
            { 
                txt_phongtrong.Text = "0";
                lv_phongtrong.Items.Clear();
            }
        }

        private void KiemTraPhong_Load(object sender, EventArgs e)
        {
            //load cbo loại phòng
            cmb_loaiphong.DataSource = tp.Load_TimLoaiPhong();
            cmb_loaiphong.DisplayMember = "TENLOAI";
            cmb_loaiphong.ValueMember = "MALOAI";

        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
