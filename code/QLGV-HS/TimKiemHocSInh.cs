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
    public partial class TimKiemHocSInh : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SNTR6UK;Initial Catalog=QLGV-HS;Integrated Security=True");
        public TimKiemHocSInh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Mã học sinh")
            {
                con.Open();
                string sql = "SELECT *FROM HocSinh WHERE MaHS = @MaHS";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaHS",txt_tk.Text);                
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (comboBox1.Text == "Tên học sinh")
            {
                con.Open();
                string sql = "SELECT *FROM HocSinh WHERE TenHS = @TenHS";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("TenHS", txt_tk.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (comboBox1.Text == "Dân tộc")
            {
                con.Open();
                string sql = "SELECT *FROM HocSinh WHERE DanToc = @DanToc";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("DanToc", txt_tk.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (comboBox1.Text == "Mã lớp")
            {
                con.Open();
                string sql = "SELECT *FROM HocSinh WHERE MaLop = @MaLop";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaLop", txt_tk.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void TimKiemHocSInh_Load(object sender, EventArgs e)
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
    }
}
