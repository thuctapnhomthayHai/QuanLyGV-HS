using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLGV_HS
{

    
    public partial class QLHocSinh : Form
    {
        public QLHocSinh()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SNTR6UK;Initial Catalog=QLGV-HS;Integrated Security=True");
        public void Show()
        {
            con.Open();
            string sql = "SELECT *FROM HocSinh";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "INSERT INTO HocSinh VALUES (@MaHS, @TenHS, @GioiTinh, @NgaySinh, @DanToc, @MaLop)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaHS", txt_mahs.Text);
            cmd.Parameters.AddWithValue("TenHS", txt_tenhs.Text);
            cmd.Parameters.AddWithValue("GioiTinh", txt_gioitinh.Text);
            cmd.Parameters.AddWithValue("NgaySinh", txt_ngaysinh.Text);
            cmd.Parameters.AddWithValue("DanToc", txt_dantoc.Text);
            cmd.Parameters.AddWithValue("MaLop", txt_malop.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void QLHocSinh_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "UPDATE HocSinh SET TenHS = @TenHS, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh,DanToc =@DanToc,MaLop = @MaLop  WHERE MaHS = @MaHS";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaHS", txt_mahs.Text);
            cmd.Parameters.AddWithValue("TenHS", txt_tenhs.Text);
            cmd.Parameters.AddWithValue("GioiTinh", txt_gioitinh.Text);
            cmd.Parameters.AddWithValue("NgaySinh", txt_ngaysinh.Text);
            cmd.Parameters.AddWithValue("DanToc", txt_dantoc.Text);
            cmd.Parameters.AddWithValue("MaLop", txt_malop.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "DELETE FROM GiangDay WHERE MaHS = @MaHS";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaHS", txt_mahs.Text);
            cmd.Parameters.AddWithValue("TenHS", txt_tenhs.Text);
            cmd.Parameters.AddWithValue("GioiTinh", txt_gioitinh.Text);
            cmd.Parameters.AddWithValue("NgaySinh", txt_ngaysinh.Text);
            cmd.Parameters.AddWithValue("DanToc", txt_dantoc.Text);
            cmd.Parameters.AddWithValue("MaLop", txt_malop.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }
    }
}
