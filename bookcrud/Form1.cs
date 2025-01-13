using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bookcrud
{
    public partial class print : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=booktask1;Integrated Security=True");

        private void add_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            string name = txtti.Text;
            string author = txtau.Text;
            int price = int.Parse(txtpr.Text);

            SqlCommand cmd = new SqlCommand($"insert into librarybooktask values({id},'{name}','{author}',{price})", con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show((result != 0) ? "Book Details Saved..." : "D...");
            con.Close();
            txtid.Clear();
            txtti.Clear();
            txtau.Clear();
            txtpr.Clear();
        }
        private void update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            int price = int.Parse(txtpr.Text);

            SqlCommand cmd = new SqlCommand($"update librarybooktask set price ={price} where id = {id}", con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show((result != 0) ? "Data updated..." : "Invalid Id");
            con.Close();
            txtid.Clear();
            txtpr.Clear();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            SqlCommand cmd = new SqlCommand($"delete from librarybooktask where id = {id}", con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show((result != 0) ? "Data deleted..." : "Invalid Id");
            con.Close();
            txtid.Clear();
            txtpr.Clear();
        }
        private void find_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            SqlCommand cmd = new SqlCommand($"select * from librarybooktask where id ={id} ", con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            gv.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"select * from librarybooktask", con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            gv.DataSource = ds.Tables[0];
            con.Close();
        }
        public print()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

       
    }
}