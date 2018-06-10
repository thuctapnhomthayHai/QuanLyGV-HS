using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLGV_HS
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_pass.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công!", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain mf = new FrmMain();
                this.Hide();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_pass.Text = "";
                txt_username.Text = "";
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (dr == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
