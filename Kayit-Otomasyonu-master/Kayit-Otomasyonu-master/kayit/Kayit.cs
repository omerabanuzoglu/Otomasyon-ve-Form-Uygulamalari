using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vize_Odev
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void d_olustur()
        {
            listBox1.Items.Clear();
            string[] dosyalar = Directory.GetFiles("Mezunlar/");
            foreach (string dosya in dosyalar)
            {
                if (dosya.EndsWith(".txt") || dosya.EndsWith(".txt"))
                {
                    string kontrol = Convert.ToString(dosya.Replace("Mezunlar/", "").Replace(".txt", ""));
                    listBox1.Items.Add(kontrol);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "")
            {
                FileStream file = new FileStream("Mezunlar/" + textBox1.Text + ".txt", FileMode.OpenOrCreate);
                file.Close();
                StreamWriter yaz = new StreamWriter(file.Name);
                yaz.WriteLine(textBox1.Text);
                yaz.WriteLine(textBox2.Text);
                yaz.WriteLine(textBox3.Text);
                yaz.WriteLine(textBox4.Text);
                yaz.WriteLine(textBox5.Text);
                yaz.WriteLine(textBox6.Text);
                yaz.WriteLine(textBox7.Text);
                yaz.WriteLine(textBox8.Text);
                yaz.WriteLine(textBox9.Text);
                yaz.WriteLine(textBox10.Text);
                yaz.Flush();
                yaz.Close();
                MessageBox.Show("Başarıyla Kaydedildi .");
            }
            else
            {
                if (textBox1.Text == "")
                {
                    label1.ForeColor = Color.Red;
                }
                else
                {
                    label1.ForeColor = Color.Black;
                }
                if (textBox2.Text == "")
                {
                    label2.ForeColor = Color.Red;
                }
                else
                {
                    label2.ForeColor = Color.Black;
                }
                if (textBox3.Text == "")
                {
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    label3.ForeColor = Color.Black;
                }
                if (textBox4.Text == "")
                {
                    label4.ForeColor = Color.Red;
                }
                else
                {
                    label4.ForeColor = Color.Black;
                }
                if (textBox5.Text == "")
                {
                    label5.ForeColor = Color.Red;
                }
                else
                {
                    label5.ForeColor = Color.Black;
                }
                if (textBox6.Text == "")
                {
                    label6.ForeColor = Color.Red;
                }
                else
                {
                    label6.ForeColor = Color.Black;
                }
                if (textBox7.Text == "")
                {
                    label7.ForeColor = Color.Red;
                }
                else
                {
                    label7.ForeColor = Color.Black;
                }
                if (textBox8.Text == "")
                {
                    label8.ForeColor = Color.Red;
                }
                else
                {
                    label8.ForeColor = Color.Black;
                }
                if (textBox9.Text == "")
                {
                    label9.ForeColor = Color.Red;
                }
                else
                {
                    label9.ForeColor = Color.Black;
                }
                if (textBox10.Text == "")
                {
                    label10.ForeColor = Color.Red;
                }
                else
                {
                    label10.ForeColor = Color.Black;
                }
            }
            d_olustur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goruntu a = new Goruntu();
            this.Hide();
            a.Show();
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            string yol = "Mezunlar";
            if (Directory.Exists(yol))
            {
                d_olustur();
            }
            else
            {
                string olustur = "Mezunlar";
                Directory.CreateDirectory(olustur);
                {
                    d_olustur();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }
    }
}
