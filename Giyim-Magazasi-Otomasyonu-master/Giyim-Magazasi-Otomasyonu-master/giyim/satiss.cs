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
    public partial class satiss : Form
    {
        public satiss()
        {
            InitializeComponent();
        }

        private void satiss_Load(object sender, EventArgs e)
        {

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
            string sql = "insert into satis(SeriNo,ÜrünAdı,Fiyatı) values('" + textBox1.Text + "','"+comboBox1.Text+"','" + textBox2.Text + "')";
            OleDbCommand y = new OleDbCommand();
            y.CommandText = sql;
            y.Connection = z;
            y.ExecuteNonQuery();
            string serino = "", urunad = "", fiyat ="";
            serino = textBox1.Text; urunad =comboBox1.Text; fiyat = textBox2.Text;
            string[] a = { serino,urunad,fiyat };
            

            double alis = 0, satis = 0, urunkar = 0, gunlukkar = 0, aylikkar = 0, gunlukzarar = 0, aylikzarar = 0;
            alis = Convert.ToDouble(textBox2.Text);
            satis = Convert.ToDouble(textBox1.Text);
            urunkar = satis - alis;
            textBox3.Text = Convert.ToString(urunkar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection z = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kayit.accdb");
            z.Open();
            string sql = "select * from satis";
            OleDbDataAdapter a = new OleDbDataAdapter(sql, z);
            DataSet b = new DataSet();
            a.Fill(b);
            dataGridView1.DataSource = b.Tables[0];
            z.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection a = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kayit.accdb");
            a.Open();
            string sql = "delete from satis where SeriNo ÜrünAdı Fiyatı = '"+ dataGridView1.SelectedRows + "'";
            OleDbCommand b = new OleDbCommand(sql, a);
            b.Connection = a;
            b.CommandText = sql;
            b.ExecuteNonQuery();
            a.Close();
        }
        double kar = 0;
        double alis = 0;
        double satis = 0;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double alis = 0, satis = 0, urunkar = 0, gunlukkar = 0, aylikkar = 0, gunlukzarar = 0, aylikzarar = 0;
            alis = Convert.ToDouble(textBox2.Text);
            satis = Convert.ToDouble(textBox1.Text);
            urunkar = satis - alis;
            textBox3.Text = Convert.ToString(urunkar);
        }
    }
}
