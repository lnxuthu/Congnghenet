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
    public partial class HoSo : Form
    {
        public HoSo()
        {
            InitializeComponent();
            this.btn_thoat.Click += Btn_thoat_Click;
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
