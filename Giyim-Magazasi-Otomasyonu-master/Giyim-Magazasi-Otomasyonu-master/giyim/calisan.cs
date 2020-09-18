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
    public partial class calisan : Form
    {
        public calisan()
        {
            InitializeComponent();
        }

        private void listele()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection z = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kayit.accdb");
            z.Open();
            string sql = "insert into calisan(AdıSoyadı,Telefonu,KanGrubu) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')";
            OleDbCommand y = new OleDbCommand();
            y.CommandText = sql;
            y.Connection = z;
            y.ExecuteNonQuery();

            string adsoyad = "", telefon = "", kangrubu = "";
            adsoyad = textBox1.Text; telefon = textBox2.Text; kangrubu = comboBox1.Text;
            string[] a = { adsoyad, telefon, kangrubu };
            textBox1.Clear();
            textBox2.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection list = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kayit.accdb");
            list.Open();
            string sql = "select * from calisan";
            OleDbDataAdapter a = new OleDbDataAdapter(sql, list);
            DataSet b = new DataSet();
            a.Fill(b);
            dataGridView1.DataSource = b.Tables[0];
            list.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection a = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kayit.accdb");
            a.Open();
            string sql = "delete from calisan where AdıSoyadı Telefonu KanGrubu = '" + textBox1 + "','" + textBox2 + "','" + comboBox1 + "'";
            OleDbCommand b = new OleDbCommand(sql, a);
            b.Connection = a;
            b.CommandText = sql;
            b.ExecuteNonQuery();
            a.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
