using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FORM_DangNhap : Form
    {
        public FORM_DangNhap()
        {
            InitializeComponent();
        }

        private void FORM_DangNhap_Load(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void pictureBox_AnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.UseSystemPasswordChar)
            {
                pictureBox_AnHienMatKhau.Image = Properties.Resources.hien;
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_AnHienMatKhau.Image = Properties.Resources.an;
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(txt_MatKhau.Text.Trim().Equals("") || txt_TenDangNhap.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống !");
            }
            else
            {
                
            }
        }

        private void btn_QuenMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
