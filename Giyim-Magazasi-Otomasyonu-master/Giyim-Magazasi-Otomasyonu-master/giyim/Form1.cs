using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giyim
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            toptan a = new toptan();
            a.Show();
            this.Hide();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            satiss a = new satiss();
            a.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calisan c = new calisan();
            c.Show();
            this.Hide();
        }
    }
}
