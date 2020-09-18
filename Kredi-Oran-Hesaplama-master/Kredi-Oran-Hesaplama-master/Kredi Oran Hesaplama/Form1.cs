using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fina_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Verilen deeğrlere göre o ayki taksit tutarını hesaplar
        /// </summary>
        /// <param name="a">kredi tutarı</param>
        /// <param name="b">faiz oranı</param>
        /// <param name="c">taksit sayısı</param>
        /// <param name="d">kalan borç</param>
        /// <returns>taksit tutarı</returns>
        public double taksit_tutar(double a, double b, int c, double d)
        {
            double taksit = a * (b * Math.Pow(1 + b, c)) / (Math.Pow(1 + b, c) - 1);
            if (taksit > d)
            {
                return Math.Round(d, 2);
            }
            return Math.Round(taksit, 2);
        }


        /// <summary>
        /// TAksitin Faiz Kısmı
        /// </summary>
        /// <param name="a">kalan anapara</param>
        /// <param name="b">faiz</param>
        /// <returns></returns>
        public double taksit_faizi(double a, double b)
        {
            double faiz_tutari = a * b;
            return Math.Round(faiz_tutari, 2);
        }


        /// <summary>
        /// taksitin faizsiz kısmı 
        /// </summary>
        /// <param name="a">taksit tutar</param>
        /// <param name="b">faiz tutarı</param>
        /// <returns></returns>
        public double taksidin_anaparası(double a, double b)
        {
            double anapara_tutar = a - b;
            return Math.Round(anapara_tutar, 2);
        }


        /// <summary>
        /// Kalan Para
        /// </summary>
        /// <param name="a">kalan anapara</param>
        /// <param name="b">anapara tutarı</param>
        /// <returns></returns>
        public double kalan_anapara(double a, double b)
        {
            double kalanpara = a - b;
            return Math.Round(kalanpara, 2);
        }


        public void button1_Click(object sender, EventArgs e)
        {
            double kredi_tutar, faiz, oran;
            kredi_tutar = Convert.ToDouble(textBox3.Text);
            int vade = Convert.ToInt32(textBox4.Text);
            faiz = Convert.ToDouble(textBox5.Text);
            oran = faiz / 100;

            label7.Text = textBox1.Text;
            label9.Text = textBox2.Text;
            label6.BackColor = Color.White;
            label7.BackColor = Color.White;
            label8.BackColor = Color.White;
            label9.BackColor = Color.White;


            dataGridView1.RowCount = vade;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Aylar";
            dataGridView1.Columns[1].Name = "Aylık Taksit";
            dataGridView1.Columns[2].Name = "Taksidin Anapara Kısmı";
            dataGridView1.Columns[3].Name = "Taksidin Faiz Kısmı";
            dataGridView1.Columns[4].Name = "Kalan Anapara";

            Graphics bilgi = CreateGraphics();
            bilgi.FillRectangle(Brushes.White, 272, 10, 550, 30);


            double taksit;
            double taksitinparasi;
            double kalan_para = kredi_tutar;
            double taksit_faiz;

            for (int i = 0; i < vade; i++)
            {
                // o ayki taksit miktarını hesaplar
                taksit = taksit_tutar(kredi_tutar, oran, vade, kalan_para);

                // taksitin faiz kısmını hesaplar
                taksit_faiz = taksit_faizi(kalan_para, oran);

                // o ayki taksidin faizssiz tutarını hesaplar
                taksitinparasi = taksidin_anaparası(taksit, taksit_faiz);

                // o ayki taksit ödendiğinde kalan borcu hesaplar
                kalan_para = kalan_anapara(kalan_para, taksitinparasi);

                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = taksit;
                dataGridView1.Rows[i].Cells[2].Value = taksitinparasi;
                dataGridView1.Rows[i].Cells[3].Value = taksit_faiz;
                dataGridView1.Rows[i].Cells[4].Value = kalan_para;

                if (dataGridView1.AllowUserToAddRows)
                {
                    dataGridView1.Rows[vade - 1].Cells[4].Value = 0;
                }
            }
        }
    }
}
