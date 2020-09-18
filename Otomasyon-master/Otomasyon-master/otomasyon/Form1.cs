using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anıl_Staj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ParaMik = int.Parse(textBox1.Text);
            int Adet = 0;
            label2.Text = "";


            //%25i 50TL ve altı

            if (radioButton1.Checked)
            {
                if (ParaMik >= 200)
                {
                    int secme = ParaMik * 25 / 100;
                    int kalan = ParaMik - secme;

                    if (kalan >= 200)
                    {
                        Adet = kalan / 200;
                        kalan = kalan % 200;
                        label2.Text = Adet.ToString() + " Adet 200 TL \n";
                    }
                    if (kalan >= 100)
                    {
                        Adet = kalan / 100;
                        kalan = kalan % 100;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 100 TL \n";
                    }
                    if (kalan >= 50)
                    {
                        Adet = kalan / 50;
                        kalan = kalan % 50;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 50 TL \n";
                    }

                    if (kalan >= 20)
                    {
                        Adet = kalan / 20;
                        kalan = kalan % 20;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 20 TL \n";
                    }

                    if (kalan >= 10)
                    {
                        Adet = kalan / 10;
                        kalan = kalan % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }
                    if (kalan >= 5)
                    {
                        Adet = kalan / 5;
                        kalan = kalan % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }

                    if (kalan >= 1)
                    {
                        Adet = kalan / 1;
                        kalan = kalan % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }
                    if (secme >= 50)
                    {
                        Adet = secme / 50;
                        secme = secme % 50;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 50 TL \n";
                    }
                    if (secme >= 20)
                    {
                        Adet = secme / 20;
                        secme = secme % 20;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 20 TL \n";
                    }
                    if (secme >= 10)
                    {
                        Adet = secme / 10;
                        secme = secme % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }
                    if (secme >= 5)
                    {
                        Adet = secme / 5;
                        secme = secme % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }
                    if (secme >= 1)
                    {
                        Adet = secme / 1;
                        secme = secme % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }
                }
                else
                {
                    MessageBox.Show("Girilen Para değeri uygun değildir. Lütfen en az 200 TL giriniz.");
                }
            }


            // %50 si 50TL ve altı


            if (radioButton2.Checked)
            {
                if (ParaMik >= 100)
                {
                    int secme = ParaMik * 50 / 100;
                    int kalan = ParaMik - secme;

                    if (kalan >= 200)
                    {
                        Adet = kalan / 200;
                        kalan = kalan % 200;
                        label2.Text = Adet.ToString() + " Adet 200 TL \n";
                    }
                    if (kalan >= 100)
                    {
                        Adet = kalan / 100;
                        kalan = kalan % 100;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 100 TL \n";
                    }
                    if (kalan >= 50)
                    {
                        Adet = kalan / 50;
                        kalan = kalan % 50;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 50 TL \n";
                    }

                    if (kalan >= 20)
                    {
                        Adet = kalan / 20;
                        kalan = kalan % 20;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 20 TL \n";
                    }

                    if (kalan >= 10)
                    {
                        Adet = kalan / 10;
                        kalan = kalan % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }

                    if (kalan >= 5)
                    {
                        Adet = kalan / 5;
                        kalan = kalan % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }

                    if (kalan >= 1)
                    {
                        Adet = kalan / 1;
                        kalan = kalan % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }
                    if (secme >= 50)
                    {
                        Adet = secme / 50;
                        secme = secme % 50;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 50 TL \n";
                    }
                    if (secme >= 20)
                    {
                        Adet = secme / 20;
                        secme = secme % 20;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 20 TL \n";
                    }
                    if (secme >= 10)
                    {
                        Adet = secme / 10;
                        secme = secme % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }
                    if (secme >= 5)
                    {
                        Adet = secme / 5;
                        secme = secme % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }
                    if (secme >= 1)
                    {
                        Adet = secme / 1;
                        secme = secme % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }
                }
                else
                {
                    MessageBox.Show("Girilen Para değeri uygun değildir. Lütfen en az 100 TL giriniz.");
                }
            }


            //%75 i 50TL ve altı

            if (radioButton3.Checked)
            {
                if (ParaMik >= 70)
                {
                    int secme = ParaMik * 75 / 100;
                    int kalan = ParaMik - secme;

                    if (kalan >= 200)
                    {
                        Adet = kalan / 200;
                        kalan = kalan % 200;
                        label2.Text = Adet.ToString() + " Adet 200 TL \n";
                    }
                    if (kalan >= 100)
                    {
                        Adet = kalan / 100;
                        kalan = kalan % 100;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 100 TL \n";
                    }
                    if (kalan >= 50)
                    {
                        Adet = kalan / 50;
                        kalan = kalan % 50;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 50 TL \n";
                    }

                    if (kalan >= 20)
                    {
                        Adet = kalan / 20;
                        kalan = kalan % 20;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 20 TL \n";
                    }

                    if (kalan >= 10)
                    {
                        Adet = kalan / 10;
                        kalan = kalan % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }

                    if (kalan >= 5)
                    {
                        Adet = kalan / 5;
                        kalan = kalan % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }

                    if (kalan >= 1)
                    {
                        Adet = kalan / 1;
                        kalan = kalan % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }
                    if (secme >= 50)
                    {
                        Adet = secme / 50;
                        secme = secme % 50;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 50 TL \n";
                    }
                    if (secme >= 20)
                    {
                        Adet = secme / 20;
                        secme = secme % 20;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 20 TL \n";
                    }
                    if (secme >= 10)
                    {
                        Adet = secme / 10;
                        secme = secme % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }
                    if (secme >= 5)
                    {
                        Adet = secme / 5;
                        secme = secme % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }
                    if (secme >= 1)
                    {
                        Adet = secme / 1;
                        secme = secme % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }
                }
                else
                {
                    MessageBox.Show("Girilen Para değeri uygun değildir. Lütfen en az 70 TL giriniz.");
                }
            }


            // %25i 10TL ve altı

            if (radioButton4.Checked)
            {
                if (ParaMik >= 50)
                {
                    int secme = ParaMik * 25 / 100;
                    int kalan = ParaMik - secme;

                    if (kalan >= 200)
                    {
                        Adet = kalan / 200;
                        kalan = kalan % 200;
                        label2.Text = Adet.ToString() + " Adet 200 TL \n";
                    }
                    if (kalan >= 100)
                    {
                        Adet = kalan / 100;
                        kalan = kalan % 100;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 100 TL \n";
                    }
                    if (kalan >= 50)
                    {
                        Adet = kalan / 50;
                        kalan = kalan % 50;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 50 TL \n";
                    }

                    if (kalan >= 20)
                    {
                        Adet = kalan / 20;
                        kalan = kalan % 20;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 20 TL \n";
                    }

                    if (kalan >= 10)
                    {
                        Adet = kalan / 10;
                        kalan = kalan % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }

                    if (kalan >= 5)
                    {
                        Adet = kalan / 5;
                        kalan = kalan % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }

                    if (kalan >= 1)
                    {
                        Adet = kalan / 1;
                        kalan = kalan % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }

                    if (secme >= 10)
                    {
                        Adet = secme / 10;
                        secme = secme % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }
                    if (secme >= 5)
                    {
                        Adet = secme / 5;
                        secme = secme % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }
                    if (secme >= 1)
                    {
                        Adet = secme / 1;
                        secme = secme % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }
                }
                else
                {
                    MessageBox.Show("Girilen Para değeri uygun değildir. Lütfen en az 50 TL giriniz.");
                }
            }


            //%50 si 20TL ve altı

            if (radioButton5.Checked)
            {
                if (ParaMik >= 40)
                {
                    int secme = ParaMik * 50 / 100;
                    int kalan = ParaMik - secme;

                    if (kalan >= 200)
                    {
                        Adet = kalan / 200;
                        kalan = kalan % 200;
                        label2.Text = Adet.ToString() + " Adet 200 TL \n";
                    }
                    if (kalan >= 100)
                    {
                        Adet = kalan / 100;
                        kalan = kalan % 100;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 100 TL \n";
                    }
                    if (kalan >= 50)
                    {
                        Adet = kalan / 50;
                        kalan = kalan % 50;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 50 TL \n";
                    }

                    if (kalan >= 20)
                    {
                        Adet = kalan / 20;
                        kalan = kalan % 20;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 20 TL \n";
                    }

                    if (kalan >= 10)
                    {
                        Adet = kalan / 10;
                        kalan = kalan % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }

                    if (kalan >= 5)
                    {
                        Adet = kalan / 5;
                        kalan = kalan % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }

                    if (kalan >= 1)
                    {
                        Adet = kalan / 1;
                        kalan = kalan % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }

                    if (secme >= 20)
                    {
                        Adet = secme / 20;
                        secme = secme % 20;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 20 TL \n";
                    }
                    if (secme >= 10)
                    {
                        Adet = secme / 10;
                        secme = secme % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }
                    if (secme >= 5)
                    {
                        Adet = secme / 5;
                        secme = secme % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }
                    if (secme >= 1)
                    {
                        Adet = secme / 1;
                        secme = secme % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }
                }
                else
                {
                    MessageBox.Show("Girilen Para değeri uygun değildir. Lütfen en az 40 TL giriniz.");
                }
            }


            //%75i 100TL ve altı

            if (radioButton6.Checked)
            {
                if (ParaMik >= 140)
                {
                    int secme = ParaMik * 75 / 100;
                    int kalan = ParaMik - secme;

                    if (kalan >= 200)
                    {
                        Adet = kalan / 200;
                        kalan = kalan % 200;
                        label2.Text = Adet.ToString() + " Adet 200 TL \n";
                    }
                    if (kalan >= 100)
                    {
                        Adet = kalan / 100;
                        kalan = kalan % 100;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 100 TL \n";
                    }
                    if (kalan >= 50)
                    {
                        Adet = kalan / 50;
                        kalan = kalan % 50;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 50 TL \n";
                    }

                    if (kalan >= 20)
                    {
                        Adet = kalan / 20;
                        kalan = kalan % 20;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 20 TL \n";
                    }

                    if (kalan >= 10)
                    {
                        Adet = kalan / 10;
                        kalan = kalan % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }

                    if (kalan >= 5)
                    {
                        Adet = kalan / 5;
                        kalan = kalan % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }

                    if (kalan >= 1)
                    {
                        Adet = kalan / 1;
                        kalan = kalan % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }
                    if (secme >= 100)
                    {
                        Adet = secme / 100;
                        secme = secme % 50;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 50 TL \n";
                    }

                    if (secme >= 50)
                    {
                        Adet = secme / 50;
                        secme = secme % 50;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 50 TL \n";
                    }
                    if (secme >= 20)
                    {
                        Adet = secme / 20;
                        secme = secme % 20;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 20 TL \n";
                    }
                    if (secme >= 10)
                    {
                        Adet = secme / 10;
                        secme = secme % 10;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 10 TL \n";
                    }
                    if (secme >= 5)
                    {
                        Adet = secme / 5;
                        secme = secme % 5;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 5 TL \n";
                    }
                    if (secme >= 1)
                    {
                        Adet = secme / 1;
                        secme = secme % 1;
                        label2.Text = label2.Text + Adet.ToString() + " Adet 1 TL \n";
                    }
                }
                else
                {
                    MessageBox.Show("Girilen Para değeri uygun değildir. Lütfen en az 140 TL giriniz.");
                }
            }
        }
    }
}