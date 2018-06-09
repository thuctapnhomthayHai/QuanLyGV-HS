using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLGV_HS.DataLayer;

namespace QLGV_HS.GUI
{
    public partial class QuanLyHocSinh : Form
    {
        public QuanLyHocSinh()
        {
            InitializeComponent();
        }

        DataTable HocSinh;
        
       

        private void QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            DataLayer.DataAccess.Connect();
            txtMaHS.Enabled = false;
            //btnLuu.Enabled = false;
            //btnHuy.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaHS,TenHS,GioiTinh,NgaySinh,DanToc,TenLop From HocSinh,LopHoc where HocSinh.MaLop =LopHoc.MaLop";
            HocSinh = DataAccess.GetDataToTable(sql); //lấy dữ liệu
            dtgHS.DataSource = HocSinh;

            dtgHS.Columns[0].HeaderText = "Mã học sinh";
            dtgHS.Columns[1].HeaderText = "Tên học sinh";
            dtgHS.Columns[2].HeaderText = "Giới tính";
            dtgHS.Columns[3].HeaderText = "Ngày sinh";
            dtgHS.Columns[4].HeaderText = "Dân tộc";
            dtgHS.Columns[5].HeaderText = "Tên lớp";

            dtgHS.Columns[0].Width = 150;
            dtgHS.Columns[1].Width = 200;
            dtgHS.Columns[2].Width = 150;
            dtgHS.Columns[3].Width = 150;
            dtgHS.Columns[4].Width = 150;
            dtgHS.Columns[5].Width = 150;

            dtgHS.AllowUserToAddRows = false;
            dtgHS.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

       

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtNhap.Enabled = false;
            btnTimKiem.Enabled = false;
            comboBox1.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHS.Enabled = true;
            txtMaHS.Focus();
        }
        private void ResetValues()
        {
            txtMaHS.Text = "";
            txtTenHS.Text = "";
            txtGT.Text = "";
            dtNS.Text = "";
            txtDT.Text = "";
            txtMaLop.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtNhap.Enabled = false;
            comboBox1.Enabled = false;
            txtMaHS.Enabled = true;
            string sql;
            if (HocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHS.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenHS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHS.Focus();
                return;
            }
            if (txtGT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGT.Focus();
                return;
            }
            if (dtNS.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNS.Focus();
                return;
            }
            if (txtDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDT.Focus();
                return;
            }
            if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }


            sql = "UPDATE HocSinh SET  TenHS=N'" + txtTenHS.Text.Trim().ToString() +
                    "',GioiTinh=N'" + txtGT.Text.Trim().ToString() +
                    "',NgaySinh='" + dtNS.Text.ToString() +
                    "',DanToc=N'" + txtDT.Text.Trim().ToString() +
                    "',MaLop=N'" + txtMaLop.Text.Trim().ToString() +
                    "' WHERE MaKH=N'" + txtMaHS.Text + "'";
            DataAccess.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            //btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string sql;
            txtMaHS.Enabled = true;
            if (HocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHS.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE HocSinh WHERE MaKH=N'" + txtMaHS.Text + "'";
                DataAccess.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaHS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHS.Focus();
                return;
            }
            if (txtTenHS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHS.Focus();
                return;
            }
            if (txtGT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGT.Focus();
                return;
            }
            if (dtNS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNS.Focus();
                return;
            }
            if (txtDT.Text == "  ")
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDT.Focus();
                return;
            }
            if (txtMaLop.Text == "  ")
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }


            sql = "SELECT MaHS FROM HocSinh WHERE MaHS=N'" + txtMaHS.Text.Trim() + "'";

            if (DataAccess.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHS.Focus();
                txtMaHS.Text = "";
                return;
            }
            sql = "INSERT INTO HocSinh(MaHS,TenHS, GioiTinh,NgaySinh,DanToc,MaLop) VALUES (N'" + txtMaHS.Text.Trim() + "',N'" + txtTenHS.Text.Trim() + "',N'" + txtGT.Text.Trim() + "','" + dtNS.Text + "',N'" + txtDT.Text.Trim() + "',N'" + txtMaLop.Text.Trim() + "')";
            DataAccess.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnThoat.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHS.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            comboBox1.Items.Add(new { Text = "Mã học sinh", Value = "Mã học sinh" });
            comboBox1.Items.Add(new { Text = "mã lớp", Value = "Tên lớp" });
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text.Trim() == "")
            {
                MessageBox.Show("Đề Nghị Bạn Nhập Từ Khóa Càn Tìm!", "Thông Báo!");
                return;
            }
            else
            {
                if (comboBox1.Text == "Mã học sinh")
                {
                    dtgHS.DataSource = DataAccess.GetDataToTable("select * from HocSinh where MaHS like '%" + txtNhap.Text.Trim() + "%'");
                }
                if (comboBox1.Text == "Mã lớp")
                {
                    dtgHS.DataSource = DataAccess.GetDataToTable("select * from HocSinh where MaLop like '%" + txtNhap.Text.Trim() + "%'");
                }

            }
        }
    }
}
