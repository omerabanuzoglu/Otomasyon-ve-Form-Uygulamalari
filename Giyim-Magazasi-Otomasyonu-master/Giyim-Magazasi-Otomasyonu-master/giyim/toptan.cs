using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace giyim
{
    public partial class toptan : Form
    {
        public toptan()
        {
            InitializeComponent();
        }

        private void toptan_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection z = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kayit.accdb");
            z.Open();
            string sql = "select * from toptan";
            OleDbDataAdapter a = new OleDbDataAdapter(sql, z);
            DataSet b = new DataSet();
            a.Fill(b);
            dataGridView1.DataSource = b.Tables[0];
            z.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection z = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kayit.accdb");
            z.Open();
            string sql = "insert into toptan(FirmaAdı,Telefonu) values('" + textBox1.Text + "','" + textBox2.Text + "')";
            OleDbCommand y = new OleDbCommand();
            y.CommandText = sql;
            y.Connection = z;
            y.ExecuteNonQuery();
            string urunad = "", tel = "";
            urunad = textBox1.Text; tel = textBox2.Text;
            string[] a = { urunad, tel};
            textBox1.Clear();
            textBox2.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection a = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kayit.accdb");
            a.Open();
            string sql = "delete from toptan where Kimlik = '" + dataGridView1.SelectedRows + "'";
            OleDbCommand b = new OleDbCommand(sql, a);
            b.Connection = a;
            b.CommandText = sql;
            b.ExecuteNonQuery();
            a.Close();
        }
    }
}
