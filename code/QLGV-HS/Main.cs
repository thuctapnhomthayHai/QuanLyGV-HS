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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLHocSinh hs = new QLHocSinh();
            hs.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGiaoVien gv = new frmGiaoVien();
            gv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHocSinh hs = new QLHocSinh();
            hs.Show();
        }

        private void tìmKiếmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemHocSInh tk = new TimKiemHocSInh();
            tk.Show();
        }

        private void tìmKiếmGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemGiaoVien tk = new TimKiemGiaoVien();
            tk.Show();
        }

        private void quảnLýGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLiGiangDay gd = new QuanLiGiangDay();
            gd.Show();
        }

        private void xemDanhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGiaoVien gv = new frmGiaoVien();
            gv.Show();
        }
    }
}
