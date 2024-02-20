using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class TrafficLight : Form
    {
        int hijau1 = 11, kuning1 = 6, merah1 = 46, merah2 = 16, hijau2 = 11, kuning2 = 6, merah3 = 31, merah23 = 46, hijau3 = 11, kuning3 = 6, merah34 = 46, merah4 = 46, hijau4 = 11, kuning4 = 6;

        public TrafficLight()
        {
            InitializeComponent();
        }

        private void TrafficLight_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        awal:

            Waktu.Text = DateTime.Now.ToString();
            hijau1 = hijau1 - 1;
            label1.Text = hijau1.ToString();
            merah2 = merah2 - 1;
            label12.Text = merah2.ToString();
            merah3 = merah3 - 1;
            label6.Text = merah3.ToString();
            merah4 = merah4 - 1;
            label7.Text = merah4.ToString();
            Hijau1.BackColor = Color.LightGreen;
            Kuning1.BackColor = Color.Black;
            Merah1.BackColor = Color.Black;
            Merah2.BackColor = Color.Red;
            Kuning2.BackColor = Color.Black;
            Hijau2.BackColor = Color.Black;
            Hijau3.BackColor = Color.Black;
            Kuning3.BackColor = Color.Black;
            Merah3.BackColor = Color.Red;
            Hijau4.BackColor = Color.Black;
            Kuning4.BackColor = Color.Black;
            Merah4.BackColor = Color.Red;
            if (hijau1 <= 0)
            {
                hijau1 = 1;
                kuning1 = kuning1 - 1;
                label2.Text = kuning1.ToString();
                Hijau1.BackColor = Color.Black;
                Kuning1.BackColor = Color.Yellow;

                if (kuning1 == 0)
                {
                    kuning1 = 1;
                    merah1 = merah1 - 1;
                    label3.Text = merah1.ToString();
                    Kuning1.BackColor = Color.Black;
                    Merah1.BackColor = Color.Red;
                }

                if (merah2 == 0)
                {
                    merah2 = 1;
                    hijau2 = hijau2 - 1;
                    label10.Text = hijau2.ToString();
                    Merah2.BackColor = Color.Black;
                    Hijau2.BackColor = Color.LightGreen;

                    if (hijau2 == 0)
                    {
                        hijau2 = 1;
                        kuning2 = kuning2 - 1;
                        label11.Text = kuning2.ToString();
                        Hijau2.BackColor = Color.Black;
                        Kuning2.BackColor = Color.Yellow;
                    }
                    if (kuning2 == 0)
                    {
                        kuning2 = 1;
                        merah23 = merah23 - 1;
                        label12.Text = merah23.ToString();
                        Kuning2.BackColor = Color.Black;
                        Merah2.BackColor = Color.Red;
                    }
                    if (merah3 == 0)
                    {
                        merah3 = 1;
                        hijau3 = hijau3 - 1;
                        label4.Text = hijau3.ToString();
                        Merah3.BackColor = Color.Black;
                        Hijau3.BackColor = Color.LightGreen;

                        if (hijau3 == 0)
                        {
                            hijau3 = 1;
                            kuning3 = kuning3 - 1;
                            label5.Text = kuning3.ToString();
                            Hijau3.BackColor = Color.Black;
                            Kuning3.BackColor = Color.Yellow;
                        }
                        if (kuning3 == 0)
                        {
                            kuning3 = 1;
                            merah34 = merah34 - 1;
                            label6.Text = merah34.ToString();
                            Kuning3.BackColor = Color.Black;
                            Merah3.BackColor = Color.Red;
                        }

                        if (merah4 == 0)
                        {
                            merah4 = 1;
                            hijau4 = hijau4 - 1;
                            label9.Text = hijau4.ToString();
                            Merah4.BackColor = Color.Black;
                            Hijau4.BackColor = Color.LightGreen;

                            if (hijau4 == 0)
                            {
                                hijau4 = 1;
                                kuning4 = kuning4 - 1;
                                label8.Text = kuning4.ToString();
                                Hijau4.BackColor = Color.Black;
                                Kuning4.BackColor = Color.Yellow;
                            }
                            if (kuning4 == 0)
                            {
                                hijau1 = 11; kuning1 = 6; merah1 = 46; merah2 = 16; hijau2 = 11; kuning2 = 6; merah3 = 31; merah23 = 46; hijau3 = 11; kuning3 = 6; merah34 = 46; merah4 = 46; hijau4 = 11; kuning4 = 6;
                                goto awal;
                            }
                        }
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
