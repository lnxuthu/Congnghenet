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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            this.dgv_hoadon.CellMouseDown += Dgv_hoadon_CellMouseDown;
            this.btn_thoat.Click += Btn_thoat_Click;
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_hoadon_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    this.dgv_hoadon.ClearSelection();
                    this.dgv_hoadon.Rows[e.RowIndex].Selected = true;
                }
            }
        }
    }
}
