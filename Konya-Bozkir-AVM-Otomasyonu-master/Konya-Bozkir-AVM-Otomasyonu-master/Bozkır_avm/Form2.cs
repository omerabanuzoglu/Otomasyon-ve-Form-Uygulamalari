using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bozkır_avm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            string id = "", adi = "", fiyat = "";
            id = textBox1.Text; adi = textBox2.Text; fiyat = textBox3.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
