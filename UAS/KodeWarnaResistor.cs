using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS
{
    public partial class KodeWarnaResistor : Form
    {
        

        public KodeWarnaResistor()
        {
            InitializeComponent();
        }

        public void Hitung()
        {
            angka.Text = textBox1.Text + textBox2.Text + textBox5.Text + textBox4.Text;
        }


        private void Hi1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            pictureBox2.BackColor = Color.Black;
            Hitung();
        }

        private void Co1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            pictureBox2.BackColor = Color.Brown;
            Hitung();
        }

        private void Me1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
            pictureBox2.BackColor = Color.Red;
            Hitung();
        }

        private void Or1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
            pictureBox2.BackColor = Color.Orange;
            Hitung();
        }

        private void Ku1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
            pictureBox2.BackColor = Color.Yellow;
            Hitung();
        }

        private void Hij1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            pictureBox2.BackColor = Color.Green;
            Hitung();
        }

        private void Bi1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
            pictureBox2.BackColor = Color.Blue;
            Hitung();
        }

        private void Un1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
            pictureBox2.BackColor = Color.Purple;
            Hitung();
        }

        private void Ab1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
            pictureBox2.BackColor = Color.Gray;
            Hitung();
        }

        private void Pu1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
            pictureBox2.BackColor = Color.White;
            Hitung();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            pictureBox3.BackColor = Color.Black;
            Hitung();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1";
            pictureBox3.BackColor = Color.Black;
            Hitung();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "2";
            pictureBox3.BackColor = Color.Red;
            Hitung();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "3";
            pictureBox3.BackColor = Color.Orange;
            Hitung();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "4";
            pictureBox3.BackColor = Color.Yellow;
            Hitung();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "5";
            pictureBox3.BackColor = Color.Green;
            Hitung();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "6";
            pictureBox3.BackColor = Color.Blue;
            Hitung();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox2.Text = "7";
            pictureBox3.BackColor = Color.Purple;
            Hitung();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "8";
            pictureBox3.BackColor = Color.Gray;
            Hitung();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "9";
            pictureBox3.BackColor = Color.White;
            Hitung();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            textBox3.Text = "x 100000";
            textBox5.Text = "00K Ω";
            pictureBox4.BackColor = Color.Black;
            Hitung();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            textBox3.Text = "x 1";
            textBox5.Text = " Ω";
            pictureBox4.BackColor = Color.Brown;
            Hitung();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            textBox3.Text = "x 10";
            textBox5.Text = "0 Ω";
            pictureBox4.BackColor = Color.Red;
            Hitung();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            textBox3.Text = "x 100";
            textBox5.Text = "00 Ω";
            pictureBox4.BackColor = Color.Orange;
            Hitung();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            textBox3.Text = "x 1000";
            textBox5.Text = "K Ω";
            pictureBox4.BackColor = Color.Yellow;
            Hitung();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            textBox3.Text = "x 10000";
            textBox5.Text = "0K Ω";
            pictureBox4.BackColor = Color.Green;
            Hitung();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            textBox3.Text = "x 1000000";
            textBox5.Text = "M Ω";
            pictureBox4.BackColor = Color.Blue;
            Hitung();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            textBox3.Text = "x 10000000";
            textBox5.Text = "0M Ω";
            pictureBox4.BackColor = Color.Purple;
            Hitung();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            textBox3.Text = "x 100000000";
            textBox5.Text = "00M Ω";
            pictureBox4.BackColor = Color.Silver;
            Hitung();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            textBox3.Text = "x 1000000000";
            textBox5.Text = "G Ω";
            pictureBox4.BackColor = Color.Gold;

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ± 1%";
            pictureBox5.BackColor = Color.Brown;
            Hitung();
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ± 2%";
            pictureBox5.BackColor = Color.Red;
            Hitung();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ± 0.5%";
            pictureBox5.BackColor = Color.Green;
            Hitung();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ± 0.25%";
            pictureBox5.BackColor = Color.Blue;
            Hitung();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ± 0.1%";
            pictureBox5.BackColor = Color.Purple;
            Hitung();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ± 10%";
            pictureBox5.BackColor = Color.Silver;
            Hitung();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ± 5%";
            pictureBox5.BackColor = Color.Gold;
            Hitung();
        }

        private void KodeWarnaResistor_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form klk = new Kalkulator();
            this.Hide();
            klk.Show();
        }
        }
    }
