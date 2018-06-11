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
    public partial class QuanLiGiangDay : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SNTR6UK;Initial Catalog=QLGV-HS;Integrated Security=True");
        public QuanLiGiangDay()
        {
            InitializeComponent();
        }
        public void Show()
        {
            con.Open();
            string sql = "SELECT *FROM GiangDay";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "INSERT INTO GiangDay VALUES (@MaGV, @MaLop, @Thu, @Tiet)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaGV", cbx_mgv.Text);
            cmd.Parameters.AddWithValue("MaLop", cbx_malop.Text);
            cmd.Parameters.AddWithValue("Thu", txt_thu.Text);
            cmd.Parameters.AddWithValue("Tiet", txt_tietday.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "UPDATE GiangDay SET MaLop = @MaLop, Thu = @Thu, Tiet = @Tiet WHERE MaGV = @MaGV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaGV", cbx_mgv.Text);
            cmd.Parameters.AddWithValue("MaLop", cbx_malop.Text);
            cmd.Parameters.AddWithValue("Thu", txt_thu.Text);
            cmd.Parameters.AddWithValue("Tiet", txt_tietday.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "DELETE FROM GiangDay WHERE MaGV = @MaGV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaGV", cbx_mgv.Text);
            cmd.Parameters.AddWithValue("MaLop", cbx_malop.Text);
            cmd.Parameters.AddWithValue("Thu", txt_thu.Text);
            cmd.Parameters.AddWithValue("Tiet", txt_tietday.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Show();
        }

        private void QuanLiGiangDay_Load(object sender, EventArgs e)
        {
            Show();
        }
    }
}
