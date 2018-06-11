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

namespace QLGV_HS
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLGV_HS;Integrated Security=True");
        private void show()
        {
            con.Open();
            string sql = "SELECT * FROM GiaoVien";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "INSERT INTO GiaoVien VALUES (@MaGV, @TenGV, @GioiTinh, @NgaySinh, @Luong, @SDT, @MaMon)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaGV", txtma.Text);
            cmd.Parameters.AddWithValue("TenGV", txtten.Text);
            cmd.Parameters.AddWithValue("GioiTinh", txtgt.Text);
            cmd.Parameters.AddWithValue("NgaySinh", txtns.Text);
            cmd.Parameters.AddWithValue("Luong", txtluong.Text);
            cmd.Parameters.AddWithValue("SDT", txtsdt.Text);
            cmd.Parameters.AddWithValue("MaMon", txtmamon.Text);
            cmd.ExecuteNonQuery();
            show();
            con.Close();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "UPDATE KhachHang SET TenGV = @TenGV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, Luong = @Luong, SDT = @SDT, MaMon = @MaMon WHERE MaGV = @MaGV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaGV", txtma.Text);
            cmd.Parameters.AddWithValue("TenGV", txtten.Text);
            cmd.Parameters.AddWithValue("GioiTinh", txtgt.Text);
            cmd.Parameters.AddWithValue("NgaySinh", txtns.Text);
            cmd.Parameters.AddWithValue("Luong", txtluong.Text);
            cmd.Parameters.AddWithValue("SDT", txtsdt.Text);
            cmd.Parameters.AddWithValue("MaMon", txtmamon.Text);
            cmd.ExecuteNonQuery();
            show();
            con.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaGV", txtma.Text);
            cmd.Parameters.AddWithValue("TenGV", txtten.Text);
            cmd.Parameters.AddWithValue("GioiTinh", txtgt.Text);
            cmd.Parameters.AddWithValue("NgaySinh", txtns.Text);
            cmd.Parameters.AddWithValue("Luong", txtluong.Text);
            cmd.Parameters.AddWithValue("SDT", txtsdt.Text);
            cmd.Parameters.AddWithValue("MaMon", txtmamon.Text);
            cmd.ExecuteNonQuery();
            show();
            con.Close();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
