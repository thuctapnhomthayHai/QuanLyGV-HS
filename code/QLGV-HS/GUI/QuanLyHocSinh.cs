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
        private void bt_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            ResetValues();
            txt_mahs.Enabled = true;
            txt_mahs.Focus();
        }
        private void ResetValues()
        {
            txt_mahs.Text = "";
            txt_tenhs.Text = "";
            txt_gioitinh.Text = "";
            dt_ngaysinh.Text = "";
            txt_dantoc.Text = "";
            txt_malop.Text = "";
        }

        private void QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            DataLayer.DataAccess.Connect();
            txt_mahs.Enabled = false;
            //btnLuu.Enabled = false;
            //btnHuy.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaHS,TenHS,GioiTinh,NgaySinh,DanToc,TenLop From HocSinh,LopHoc where HocSinh.MaLop =LopHoc.MaLop";
            HocSinh = DataAccess.GetDataToTable(sql); //lấy dữ liệu
            dt_hocsinh.DataSource = HocSinh;

            dt_hocsinh.Columns[0].HeaderText = "Mã học sinh";
            dt_hocsinh.Columns[1].HeaderText = "Tên học sinh";
            dt_hocsinh.Columns[2].HeaderText = "Giới tính";
            dt_hocsinh.Columns[3].HeaderText = "Ngày sinh";
            dt_hocsinh.Columns[4].HeaderText = "Dân tộc";
            dt_hocsinh.Columns[5].HeaderText = "Tên lớp";

            dt_hocsinh.Columns[0].Width = 150;
            dt_hocsinh.Columns[1].Width = 200;
            dt_hocsinh.Columns[2].Width = 150;
            dt_hocsinh.Columns[3].Width = 150;
            dt_hocsinh.Columns[4].Width = 150;
            dt_hocsinh.Columns[5].Width = 150;

            dt_hocsinh.AllowUserToAddRows = false;
            dt_hocsinh.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_mahs.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mahs.Focus();
                return;
            }
            if (txt_tenhs.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenhs.Focus();
                return;
            }
            if (txt_gioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_gioitinh.Focus();
                return;
            }
            if (dt_ngaysinh.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_ngaysinh.Focus();
                return;
            }
            if (txt_dantoc.Text == "  ")
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_dantoc.Focus();
                return;
            }
            if (txt_malop.Text == "  ")
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_malop.Focus();
                return;
            }


            sql = "SELECT MaHS FROM HocSinh WHERE MaHS=N'" + txt_mahs.Text.Trim() + "'";

            if (DataAccess.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mahs.Focus();
                txt_mahs.Text = "";
                return;
            }
            sql = "INSERT INTO HocSinh(MaHS,TenHS, GioiTinh,NgaySinh,DanToc,MaLop) VALUES (N'" + txt_mahs.Text.Trim() + "',N'" + txt_tenhs.Text.Trim() + "',N'" + txt_gioitinh.Text.Trim() + "','" + dt_ngaysinh.Text + "',N'" + txt_dantoc.Text.Trim() + "',N'" + txt_malop.Text.Trim() + "')";
            DataAccess.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_thoat.Enabled = false;
            btn_luu.Enabled = false;
            txt_mahs.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (HocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mahs.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenhs.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenhs.Focus();
                return;
            }
            if (txt_gioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_gioitinh.Focus();
                return;
            }
            if (dt_ngaysinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_ngaysinh.Focus();
                return;
            }
            if (txt_dantoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_dantoc.Focus();
                return;
            }
            if (txt_malop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_malop.Focus();
                return;
            }


            sql = "UPDATE HocSinh SET  TenHS=N'" + txt_tenhs.Text.Trim().ToString() +
                    "',GioiTinh=N'" + txt_gioitinh.Text.Trim().ToString() +
                    "',NgaySinh='" + dt_ngaysinh.Text.ToString() +
                    "',DanToc=N'" + txt_dantoc.Text.Trim().ToString() +
                    "',MaLop=N'" + txt_malop.Text.Trim().ToString() +
                    "' WHERE MaKH=N'" + txt_mahs.Text + "'";
            DataAccess.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            //btnHuy.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            txt_mahs.Enabled= true;
            if (HocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mahs.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE HocSinh WHERE MaKH=N'" + txt_mahs.Text + "'";
                DataAccess.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
