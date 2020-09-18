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

namespace anıl_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable tablo = new DataTable();

        public void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "Ürün Adı";
            dataGridView1.Columns[1].Name = "Ürün Sınıfı";
            dataGridView1.Columns[2].Name = "Ürün Türü";
            dataGridView1.Columns[3].Name = "Adet";
            dataGridView1.Columns[4].Name = "Alış fiyatı";
            dataGridView1.Columns[5].Name = "Kar";
            dataGridView1.Columns[6].Name = "ÖTV";
            dataGridView1.Columns[7].Name = "KDV";
            dataGridView1.Columns[8].Name = "Satış Fiyatı";
            dataGridView1.Columns[9].Name = "Beklenen Kar";


            double kdv_oran = 0;
            double otv_oran = 0;

            if (textBox2.Text == "Gıda")
            {
                otv_oran = 1;
                kdv_oran = 8 / 10;
            }
            if (textBox2.Text == "Elektronik")
            {
                otv_oran = 50;
                kdv_oran = 18 / 100;
            }
            if (textBox2.Text == "Beyaz Eşya")
            {
                otv_oran = 20 / 100;
                kdv_oran = 18 / 100;
            }
            if (textBox2.Text == "Temizlik")
            {
                otv_oran = 1;
                kdv_oran = 18 / 100;
            }
            if (textBox2.Text == "Züccaciye")
            {
                otv_oran = 1;
                kdv_oran = 18 / 100;
            }
            if (textBox2.Text == "Tuhafiye")
            {
                otv_oran = 1;
                kdv_oran = 18 / 100;
            }
            if (textBox2.Text == "Unlu Mamül")
            {
                otv_oran = 1;
                kdv_oran = 1 / 100;
            }

            


            double a_fiyat = Convert.ToDouble(textBox5.Text);
            int adet = Convert.ToInt32(textBox4.Text);
            double kar = adet;
            double otv = (a_fiyat + kar) * otv_oran;
            double kdv = (a_fiyat + kar + otv) * kdv_oran;
            double s_fiyat = a_fiyat + kar + otv + kdv;
            kar = s_fiyat - a_fiyat - kdv;
            double b_kar = adet * kar;





            int i = dataGridView1.Rows.Add();
            i = 0;
            dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[i].Cells[3].Value = adet;
            dataGridView1.Rows[i].Cells[4].Value = a_fiyat;
            dataGridView1.Rows[i].Cells[5].Value = kar;
            dataGridView1.Rows[i].Cells[6].Value = otv;
            dataGridView1.Rows[i].Cells[7].Value = kdv;
            dataGridView1.Rows[i].Cells[8].Value = s_fiyat;
            dataGridView1.Rows[i].Cells[9].Value = b_kar;




            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, adet, a_fiyat, kar, otv, kdv, s_fiyat, b_kar);
            dataGridView2.DataSource = tablo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Ürün Adı", typeof(string));
            tablo.Columns.Add("Ürün Sınıfı", typeof(string));
            tablo.Columns.Add("Ürün Türü", typeof(string));
            tablo.Columns.Add("Adet", typeof(int));
            tablo.Columns.Add("Alış Fiyatı", typeof(double));
            tablo.Columns.Add("Kar", typeof(double));
            tablo.Columns.Add("ÖTV", typeof(double));
            tablo.Columns.Add("KDV", typeof(double));
            tablo.Columns.Add("Satış Fiyatı", typeof(double));
            tablo.Columns.Add("Beklenen Kar", typeof(double));
            dataGridView2.DataSource = tablo;
        }
    }
}
