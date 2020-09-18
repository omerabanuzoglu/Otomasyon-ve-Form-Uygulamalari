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
    public partial class Goruntu : Form
    {
        public Goruntu()
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

        private void Goruntu_Load(object sender, EventArgs e)
        {
            d_olustur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Aranacak Bir Değer Giriniz !");
            }
            else
            {
                int sonuc;
                sonuc = listBox1.FindStringExact(textBox1.Text);
                if (sonuc < 0)
                    MessageBox.Show("Girilen Bilgiler Mevcut Değil !");
                else
                    listBox1.SelectedIndex = sonuc;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "")
                    {
                        try
                        {
                            File.Delete(label1.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Klasör Silinirken Hata Oluştu. Tekrar Deneyiniz !");
                        }
                        try
                        {

                            FileStream file = new FileStream(label1.Text, FileMode.OpenOrCreate);
                            file.Close();
                            try
                            {
                                StreamWriter yaz = new StreamWriter(file.Name);
                                yaz.WriteLine(textBox2.Text);
                                yaz.WriteLine(textBox3.Text);
                                yaz.WriteLine(textBox4.Text);
                                yaz.WriteLine(textBox5.Text);
                                yaz.WriteLine(textBox6.Text);
                                yaz.WriteLine(textBox7.Text);
                                yaz.WriteLine(textBox8.Text);
                                yaz.WriteLine(textBox9.Text);
                                yaz.WriteLine(textBox10.Text);
                                yaz.WriteLine(textBox11.Text);
                                yaz.Flush();
                                yaz.Close();
                                MessageBox.Show("Başarıyla Değiştirildi .");
                            }
                            catch
                            {}
                        }
                        catch{}
                    }
                    else{}
                }
                else
                {
                }
            }
            catch
            { }
            d_olustur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(label1.Text);
                {
                    d_olustur();
                    MessageBox.Show("Öğrenci Başarıyla Silindi .");
                }
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi Lütfen Biraz Bekleyin Ve Tekrar Deneyin !");
            }
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox1.Clear();
            label1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                label1.Text = "Mezunlar/" + listBox1.SelectedItem.ToString() + ".txt";
                StreamReader oku = new StreamReader(label1.Text);
                string metin = oku.ReadLine();
                while (metin != null)
                {
                    listBox2.Items.Add(metin);
                    metin = oku.ReadLine();
                }
                textBox2.Text = listBox2.Items[0].ToString();
                textBox3.Text = listBox2.Items[1].ToString();
                textBox4.Text = listBox2.Items[2].ToString();
                textBox5.Text = listBox2.Items[3].ToString();
                textBox6.Text = listBox2.Items[4].ToString();
                textBox7.Text = listBox2.Items[5].ToString();
                textBox8.Text = listBox2.Items[6].ToString();
                textBox9.Text = listBox2.Items[7].ToString();
                textBox10.Text = listBox2.Items[8].ToString();
                textBox11.Text = listBox2.Items[9].ToString();
            }
            catch
            { }
        }
    }
}
