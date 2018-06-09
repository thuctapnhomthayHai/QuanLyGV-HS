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
    }
}
