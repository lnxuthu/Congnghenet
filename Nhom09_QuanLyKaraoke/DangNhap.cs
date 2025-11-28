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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            this.btn_dangnhap.Click += Btn_dangnhap_Click;
        }

        private void Btn_dangnhap_Click(object sender, EventArgs e)
        {
            //xử lý đăng nhập.....

            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}
