using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox1.Text);
            Vector v2 = Vector.Parse(textBox2.Text);    
            Vector somma = v1 + v2;
            label1.Text = somma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox1.Text);
            Vector v2 = Vector.Parse((textBox2.Text));
            Vector sottrazione = v1 - v2;
            label1.Text = sottrazione.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox1.Text);
            Vector v2 = Vector.Parse(textBox2.Text);
            Vector molt = v1 * v2;
            label1.Text = molt.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox1.Text);
            int scalare = int.Parse(textBox2.Text);
            Vector prodotto = scalare * v1;
            label1.Text = prodotto.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int scalare = int.Parse((textBox1.Text));
            Vector vector = Vector.Parse((textBox2.Text));
            Vector prod = scalare * vector;
            label1.Text = prod.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vector vector = Vector.Parse((textBox1.Text));
            Vector inv1 = -vector;
            label1.Text = inv1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vector v = Vector.Parse((textBox2.Text));
            Vector inv2 = -v;
            label1.Text = inv2.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vector v = Vector.Parse(textBox1.Text);
            Vector check = +v;
            label1.Text = check.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Vector v = Vector.Parse(textBox2.Text);
            Vector check = +v;
            label1.Text = check.ToString();
        }
    }
}
