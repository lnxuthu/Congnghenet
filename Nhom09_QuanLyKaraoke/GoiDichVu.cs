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
    public partial class GoiDichVu : Form
    {
        public GoiDichVu()
        {
            InitializeComponent();
            this.btn_thoat.Click += Btn_thoat_Click;
            this.dgv_dmon.CellMouseDown += Dgv_dmon_CellMouseDown;
        }

        private void Dgv_dmon_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    this.dgv_dmon.ClearSelection();
                    this.dgv_dmon.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
