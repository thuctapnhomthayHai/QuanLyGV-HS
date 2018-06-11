using QLGV_HS.DataLayer;
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
    public partial class QLGiangDay : Form
    {
        public QLGiangDay()
        {
            InitializeComponent();
        }

        private void QLGiangDay_Load(object sender, EventArgs e)
        {
            DataLayer.DataAccess.Connect();
            txtMaGV.Enabled = false;
            //btnLuu.Enabled = false;
            //btnHuy.Enabled = false;
            LoadDataGridView();
        }
        DataTable GiangDay;
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaGV,MaLop,Thu,Tiet From GiangDay";
            GiangDay = DataAccess.GetDataToTable(sql); //lấy dữ liệu
            dtGD.DataSource = GiangDay;

            dtGD.Columns[0].HeaderText = "Mã giáo viên";
            dtGD.Columns[1].HeaderText = "Mã lớp";
            dtGD.Columns[2].HeaderText = "Thứ";
            dtGD.Columns[3].HeaderText = "Tiết";
            //dtGD.Columns[4].HeaderText = "Dân tộc";
            //dtGD.Columns[5].HeaderText = "Tên lớp";

            dtGD.Columns[0].Width = 150;
            dtGD.Columns[1].Width = 200;
            dtGD.Columns[2].Width = 150;
            dtGD.Columns[3].Width = 150;
            //dtGD.Columns[4].Width = 150;
            //dtGD.Columns[5].Width = 150;

            dtGD.AllowUserToAddRows = false;
            dtGD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaGV.Enabled = false;
            btnTimKiem.Enabled = false;
            //cbMaLop.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            
           
            btnThem.Enabled = false;
            ResetValues();
            txtMaGV.Enabled = true;
            txtMaGV.Focus();
        }
        private void ResetValues()
        {
            txtMaGV.Text = "";
            cbMaLop.Text = "";
            txtThu.Text = "";
            txtTiet.Text = "";
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtMaGV.Enabled = false;
            cbMaLop.Enabled = false;
            txtThu.Enabled = true;
            string sql;
            if (GiangDay.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaLop.Focus();
                return;
            }
            if (txtThu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThu.Focus();
                return;
            }
            if (txtTiet.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTiet.Focus();
                return;
            }



            sql = "UPDATE GiangDay SET  MaLop=N'" + cbMaLop.Text.Trim().ToString() +
                    "',Thu=N'" + txtThu.Text.Trim().ToString() +
                    "',Tiet=N'" + txtTiet.Text.ToString() + 
                    "' WHERE MaGV=N'" + txtMaGV.Text + "'";
            DataAccess.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            //btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            txtMaGV.Enabled = true;
            if (GiangDay.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE GiangDay WHERE MaGV=N'" + txtMaGV.Text + "'";
                DataAccess.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaGV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã GV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGV.Focus();
                return;
            }
            if (cbMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaLop.Focus();
                return;
            }
            if (txtThu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thứ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThu.Focus();
                return;
            }
            if (txtTiet.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTiet.Focus();
                return;
            }
            


            sql = "SELECT MaGV FROM GiangDay WHERE MaGV=N'" + txtMaGV.Text.Trim() + "'";

            if (DataAccess.CheckKey(sql))
            {
                MessageBox.Show("Mã giáo viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGV.Focus();
                txtMaGV.Text = "";
                return;
            }
            sql = "INSERT INTO GiangDay(MaGV,MaLop,Thu,Tiet) VALUES (N'" + txtMaGV.Text.Trim() + "',N'" + cbMaLop.Text.Trim() + "',N'" + txtThu.Text.Trim()+ "',N'" + txtTiet.Text.Trim() + "')";
            DataAccess.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
           // btnThoat.Enabled = false;
            btnLuu.Enabled = false;
            txtMaGV.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Đề Nghị Bạn Nhập Từ Khóa Cần Tìm!", "Thông Báo!");
                return;
            }
            else
            {
                if (cbTK.Text == "Thứ")
                {
                    dtGD.DataSource = DataAccess.GetDataToTable("select * from GiangDay where Thu like '%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cbTK.Text == "Tiết")
                {
                    dtGD.DataSource = DataAccess.GetDataToTable("select * from GiangDay where Tiet like '%" + txtTimKiem.Text.Trim() + "%'");
                }

            }
        }
    }
}
