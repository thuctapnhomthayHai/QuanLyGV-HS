using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGV_HS.GUI;

namespace QLGV_HS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyHocSinh hs = new QuanLyHocSinh();
            hs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGiaoVien GV = new frmGiaoVien();
            GV.Show();
        }

        private void thôngTinGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLiGiangDay gd = new QuanLiGiangDay();
            gd.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHocSinh hs = new QuanLyHocSinh();
            hs.Show();
        }

        private void danhSáchGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaoVien GV = new frmGiaoVien();
            GV.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tìmKIếmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemHocSInh tk = new TimKiemHocSInh();
            tk.Show();

        }

        private void timKiếmGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemGiaoVien tkgv = new TimKiemGiaoVien();
            tkgv.Show();
        }
    }
}
