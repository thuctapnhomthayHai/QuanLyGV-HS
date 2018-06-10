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
    public partial class TimKiemGiaoVien : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SNTR6UK;Initial Catalog=QLGV-HS;Integrated Security=True");
        public TimKiemGiaoVien()
        {
            InitializeComponent();
        }

        private void TimKiemGiaoVien_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT *FROM GiaoVien";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mã giáo viên")
            {
                con.Open();
                string sql = "SELECT *FROM GiaoVien WHERE MaGV = @MaGV";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaGV", txt_tk.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (comboBox1.Text == "Tên giáo viên")
            {
                con.Open();
                string sql = "SELECT *FROM GiaoVien WHERE TenGV = @TenGV";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("TenGV", txt_tk.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (comboBox1.Text == "Số điện thoại")
            {
                con.Open();
                string sql = "SELECT *FROM GiaoVien WHERE SDT = @SDT";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("SDT", txt_tk.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (comboBox1.Text == "Mã môn")
            {
                con.Open();
                string sql = "SELECT *FROM GiaoVien WHERE MaMon = @MaMon";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaMon", txt_tk.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }
    }
}
