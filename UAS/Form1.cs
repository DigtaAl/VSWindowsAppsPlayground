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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetFont(string Nama, int Ukuran)
        {
            label1.Font = new System.Drawing.Font(Nama, Ukuran);
            label2.Font = new System.Drawing.Font(Nama, Ukuran);
            label3.Font = new System.Drawing.Font(Nama, Ukuran);
            homeToolStripMenuItem.Font = new System.Drawing.Font(Nama, Ukuran);
            kalkulatorToolStripMenuItem.Font = new System.Drawing.Font(Nama, Ukuran);
            viewToolStripMenuItem.Font = new System.Drawing.Font(Nama, Ukuran);
            formatToolStripMenuItem.Font = new System.Drawing.Font(Nama, Ukuran);
        }

        private void ChangeFont()
        {
            string Nama = (string)Jenis.SelectedItem;
            int Ukuran = Convert.ToInt32((string)Ukurann.SelectedItem);
            if (Ukuran != 0)
            {
                SetFont(Nama, Ukuran);
            }
        }

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kl = new Kalkulator();
            this.Hide();
            kl.Show();
        }

        private void minimazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Bold);
            label2.Font = new System.Drawing.Font(label2.Font.FontFamily, label2.Font.Size, FontStyle.Bold);
            label3.Font = new System.Drawing.Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Bold);
            homeToolStripMenuItem.Font = new System.Drawing.Font(homeToolStripMenuItem.Font.FontFamily, homeToolStripMenuItem.Font.Size, FontStyle.Bold);
            kalkulatorToolStripMenuItem.Font = new System.Drawing.Font(kalkulatorToolStripMenuItem.Font.FontFamily, kalkulatorToolStripMenuItem.Font.Size, FontStyle.Bold);
            viewToolStripMenuItem.Font = new System.Drawing.Font(viewToolStripMenuItem.Font.FontFamily, viewToolStripMenuItem.Font.Size, FontStyle.Bold);
            formatToolStripMenuItem.Font = new System.Drawing.Font(formatToolStripMenuItem.Font.FontFamily, formatToolStripMenuItem.Font.Size, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (System.Drawing.FontFamily family in fonts.Families)
            {
                Jenis.Items.Add(family.Name);

            }
            for (int i = 8; i < 60; i += 2)
            {
                Ukurann.Items.Add(i.ToString());
            }
            Jenis.SelectedIndex = 2;
            Ukurann.SelectedIndex = 2;
            Jenis.Text = "Arial";
            Ukurann.Text = "10";
            ChangeFont();
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Italic);
            label2.Font = new System.Drawing.Font(label2.Font.FontFamily, label2.Font.Size, FontStyle.Italic);
            label3.Font = new System.Drawing.Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Italic);
            homeToolStripMenuItem.Font = new System.Drawing.Font(homeToolStripMenuItem.Font.FontFamily, homeToolStripMenuItem.Font.Size, FontStyle.Italic);
            kalkulatorToolStripMenuItem.Font = new System.Drawing.Font(kalkulatorToolStripMenuItem.Font.FontFamily, kalkulatorToolStripMenuItem.Font.Size, FontStyle.Italic);
            viewToolStripMenuItem.Font = new System.Drawing.Font(viewToolStripMenuItem.Font.FontFamily, viewToolStripMenuItem.Font.Size, FontStyle.Italic);
            formatToolStripMenuItem.Font = new System.Drawing.Font(formatToolStripMenuItem.Font.FontFamily, formatToolStripMenuItem.Font.Size, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Underline);
            label2.Font = new System.Drawing.Font(label2.Font.FontFamily, label2.Font.Size, FontStyle.Underline);
            label3.Font = new System.Drawing.Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Underline);
            homeToolStripMenuItem.Font = new System.Drawing.Font(homeToolStripMenuItem.Font.FontFamily, homeToolStripMenuItem.Font.Size, FontStyle.Underline);
            kalkulatorToolStripMenuItem.Font = new System.Drawing.Font(kalkulatorToolStripMenuItem.Font.FontFamily, kalkulatorToolStripMenuItem.Font.Size, FontStyle.Underline);
            viewToolStripMenuItem.Font = new System.Drawing.Font(viewToolStripMenuItem.Font.FontFamily, viewToolStripMenuItem.Font.Size, FontStyle.Underline);
            formatToolStripMenuItem.Font = new System.Drawing.Font(formatToolStripMenuItem.Font.FontFamily, formatToolStripMenuItem.Font.Size, FontStyle.Underline);
        }

        private void strikeOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Strikeout);
            label2.Font = new System.Drawing.Font(label2.Font.FontFamily, label2.Font.Size, FontStyle.Strikeout);
            label3.Font = new System.Drawing.Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Strikeout);
            homeToolStripMenuItem.Font = new System.Drawing.Font(homeToolStripMenuItem.Font.FontFamily, homeToolStripMenuItem.Font.Size, FontStyle.Strikeout);
            kalkulatorToolStripMenuItem.Font = new System.Drawing.Font(kalkulatorToolStripMenuItem.Font.FontFamily, kalkulatorToolStripMenuItem.Font.Size, FontStyle.Strikeout);
            viewToolStripMenuItem.Font = new System.Drawing.Font(viewToolStripMenuItem.Font.FontFamily, viewToolStripMenuItem.Font.Size, FontStyle.Strikeout);
            formatToolStripMenuItem.Font = new System.Drawing.Font(formatToolStripMenuItem.Font.FontFamily, formatToolStripMenuItem.Font.Size, FontStyle.Strikeout);
        }

        private void jenisFontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Jenis_Click(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void Ukurann_Click(object sender, EventArgs e)
        {
            ChangeFont();
        }
    }
}
