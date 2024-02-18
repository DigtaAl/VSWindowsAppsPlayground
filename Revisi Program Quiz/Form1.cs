using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;
using Application = Microsoft.Office.Interop.Excel._Application;

namespace Revisi_Program_Quiz
{
    public partial class Form1 : Form
    {
        int a, K, i = 0, j = 0, b = 0, r = 0, no1 = 1, t = 0;
        int[] y = new int[10], Acak = { 8, 4, 3, 7, 9, 1, 10, 2, 5, 6 };
        double JmlSkor = 0, nilai;
        char kunci = ' ', jwb = ' ';
        int z = 0;
        int[] skor = new int[12];
        double[] X = new double[25];
        string[] Y = new string[25];
        double AC = 1;
        int q = 1;
        string NamaFile = "";



        public Form1()
        {
            InitializeComponent();
            while (Acak.Length > 0)
            {
                Random btr = new Random();
                int AcakSoal = btr.Next(Acak.Length);

                int x = Acak[AcakSoal];
                y[i] = x;
                int numToRemove = x;
                int numAcakSoal = Array.IndexOf(Acak, numToRemove);
                Acak = Acak.Where((val, idx) => idx != numAcakSoal).ToArray();
                i++;
            }
            K = y[0];
            i = 0;
            Quiz();
            int xy = 1;
            butir.Text = (xy.ToString());
        }

        public void Pesan()
        {
            MessageBox.Show("Selesai");
        }

        public void Quiz()
        {
            switch (K)
            {
                case 1:
                    Soal.Text = "Bagian MCB yang berfungsi sebagai magnetic trip adalah ....";
                    PA.Text = "Pemadam busur api";
                    PB.Text = "Bimetal";
                    PC.Text = "Solenoid Coil";
                    PD.Text = "Actuator Lever";
                    PE.Text = " toggle switch;";
                    kunci = 'C';
                    break;
                case 2:
                    Soal.Text = "Bagian magnetic kontaktor yang berfungsi sebagai tempat terjadinya magnetisasi adalah ...";
                    PA.Text = "Normally close";
                    PB.Text = "Normally open";
                    PC.Text = "Coil";
                    PD.Text = "Terminal NO";
                    PE.Text = "Kontak-kontak";
                    kunci = 'C';
                    break;
                case 3:
                    Soal.Text = "Supaya efisiensi dalam menghidupkan dan mematikan lampu pada tangga rumah bertingkat dapat berikut memerlukan bahan, diantaranya......";
                    PA.Text = "1 sakelar tunggal, 1 lampu, kabel";
                    PB.Text = "2 sakelar tukar, 1 lampu, kabel";
                    PC.Text = "2 sakelar tunggal, 2 lampu, kabel";
                    PD.Text = "1 sakelar seri, 2 lampu, kabel";
                    PE.Text = "1 sakelar tukar. 2 lampu, kabel";
                    kunci = 'B';
                    break;
                case 4:
                    Soal.Text = "Urutan pemasangan instalasi listrik adalah....";
                    PA.Text = "KWHmeter - MCB- Box sekring – peralatanlistrik";
                    PB.Text = "MCB - KWHmeter - Box sekring–peralatanlistrik";
                    PC.Text = "Box sekring – MCB – KWHmeter–peralatanlistrik";
                    PD.Text = "MCB –peralatanlistrik –KWHmeter - Box sekring";
                    PE.Text = "Box sekring – KWHmeter– MCB - peralatanlistrik";
                    kunci = 'A';
                    break;
                case 5:
                    Soal.Text = "Jenis arus yang dihasilkan oleh pembangkit listrik sebelum diubah oleh inverter pada pembangkit listrik tenaga surya adalah ….";
                    PA.Text = "Alternatif current";
                    PB.Text = "Direct current";
                    PC.Text = "Voltase";
                    PD.Text = "Daya";
                    PE.Text = "Ampere";
                    kunci = 'B';
                    break;
                case 6:
                    Soal.Text = "Sebutkan satuan tegangan?";
                    PA.Text = "Volt";
                    PB.Text = "Ampere";
                    PC.Text = "Ohm";
                    PD.Text = "Jam";
                    PE.Text = "Secon";
                    kunci = 'A';
                    break;
                case 7:
                    Soal.Text = "Alat ukur yang digunakan untuk mengukur besar hambatan disebut? ";
                    PA.Text = "Ampere meter";
                    PB.Text = "Volt meter";
                    PC.Text = "Watt meter";
                    PD.Text = "Ohm meter";
                    PE.Text = "Kwh meter";
                    kunci = 'D';
                    break;
                case 8:
                    Soal.Text = " Bagian MCB yang berfungsi sebagai magnetic trip adalah ....";
                    PA.Text = "Pemadam busur api";
                    PB.Text = "Solenoid Coil";
                    PC.Text = "Actuator Lever";
                    PD.Text = "Bimetal";
                    PE.Text = "Toggle switch";
                    kunci = 'B';
                    break;
                case 9:
                    Soal.Text = "Magnetic Kontaktor berkerja menggunakan prinsip ....";
                    PA.Text = "Induksi elektro statis";
                    PB.Text = "Konduksi";
                    PC.Text = "Hukum Newton";
                    PD.Text = "Radiasi";
                    PE.Text = "Induksi Elektro magnetic";
                    kunci = 'E';
                    break;
                case 10:
                    Soal.Text = "Pada kontaktor magnet yang berfungsi sebagai NC adalah ....";
                    PA.Text = "1 - 2";
                    PB.Text = "2 – 7";
                    PC.Text = "21 - 22";
                    PD.Text = "43 - 44";
                    PE.Text = "13 - 14";
                    kunci = 'C';
                    break;
            }
        }
        public void Salah()
        {
            MessageBox.Show("Maaf Anda sudah mengerjakan semua !!", "Kesalahan..!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (PA.Checked) jwb = 'A';
            else if (PB.Checked) jwb = 'B';
            else if (PC.Checked) jwb = 'C';
            else if (PD.Checked) jwb = 'D';
            else jwb = 'E';

            if (jwb == kunci) skor[K] = 1; else skor[K] = 0;
            JmlSkor = skor[1] + skor[2] + skor[3] + skor[4] + skor[5] + skor[6] + skor[7] + skor[8] + skor[9] + skor[10];
            nilai = JmlSkor * 10;
            score.Text = JmlSkor.ToString();
            Nilaii.Text = nilai.ToString();

            if (jwb == kunci && nilai <= 100)
            {

                if (b == 0) Satu.BackColor = Color.Green;
                else if (b == 1) dua.BackColor = Color.Green;
                else if (b == 2) tiga.BackColor = Color.Green;
                else if (b == 3) empat.BackColor = Color.Green;
                else if (b == 4) lima.BackColor = Color.Green;
                else if (b == 5) enam.BackColor = Color.Green;
                else if (b == 6) tujuh.BackColor = Color.Green;
                else if (b == 7) delapan.BackColor = Color.Green;
                else if (b == 8) sembilan.BackColor = Color.Green;
                else if (b == 9) sepuluh.BackColor = Color.Green;

            }
            if (jwb != kunci)
            {
                if (b == 0) Satu.BackColor = Color.Red;
                else if (b == 1) dua.BackColor = Color.Red;
                else if (b == 2) tiga.BackColor = Color.Red;
                else if (b == 3) empat.BackColor = Color.Red;
                else if (b == 4) lima.BackColor = Color.Red;
                else if (b == 5) enam.BackColor = Color.Red;
                else if (b == 6) tujuh.BackColor = Color.Red;
                else if (b == 7) delapan.BackColor = Color.Red;
                else if (b == 8) sembilan.BackColor = Color.Red;
                else if (b == 9) sepuluh.BackColor = Color.Red;

            }
        }

        private void Satu_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                PA.Checked = false;
                PB.Checked = false;
                PC.Checked = false;
                PD.Checked = false;
                PE.Checked = false;
                K = y[0];
                b = 0;
                int btr = 1;
                z = 0;
                butir.Text = btr.ToString();
                Quiz();
            }
            else Pesan();
        }

        private void dua_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                PA.Checked = false;
                PB.Checked = false;
                PC.Checked = false;
                PD.Checked = false;
                PE.Checked = false;
                K = y[1];
                b = 1;
                int btr = 2;
                z = 0;
                butir.Text = btr.ToString();
                Quiz();
            }
            else Pesan();

        }

        private void tiga_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                PA.Checked = false;
                PB.Checked = false;
                PC.Checked = false;
                PD.Checked = false;
                PE.Checked = false;
                K = y[2];
                b = 2;
                int btr = 3;
                z = 0;
                butir.Text = btr.ToString();
                Quiz();
            }
            else Pesan();

        }

        private void empat_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                PA.Checked = false;
                PB.Checked = false;
                PC.Checked = false;
                PD.Checked = false;
                PE.Checked = false;
                K = y[3];
                b = 3;
                int btr = 4;
                z = 0;
                butir.Text = btr.ToString();
                Quiz();
            }
            else Pesan();

        }

        private void lima_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                PA.Checked = false;
                PB.Checked = false;
                PC.Checked = false;
                PD.Checked = false;
                PE.Checked = false;
                K = y[4];
                b = 4;
                int btr = 5;
                z = 0;
                butir.Text = btr.ToString();
                Quiz();
            }
            else Pesan();
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ARE YOU SURE TO FINISH ?", "!!!",
         MessageBoxButtons.OK, MessageBoxIcon.Question);

            Y[r] = Nama.Text;
            DATA1.Items.Add(nilai.ToString());
            X[r] = nilai;
            r++;
           

            ListViewItem item2 = new ListViewItem(q.ToString());
            item2.SubItems.Add(Nama.Text);
            item2.SubItems.Add(nilai.ToString());
            if (nilai > 75) item2.SubItems.Add("Lulus");
            else item2.SubItems.Add("Tidak Lulus");
            listView1.Items.AddRange(new ListViewItem[] { item2 });
            q++;

           
            {
                PA.Checked = false;
                PB.Checked = false;
                PC.Checked = false;
                PD.Checked = false;
                PE.Checked = false;
                K = y[0];
                b = 0;
                int btr = 1;
                z = 0;
                butir.Text = btr.ToString();
                Quiz();
            }
            z++;
         

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            int ac = 0;
            Acak = new int[10];
            foreach (var n in y)
            {
                Acak[ac] = n;
                ac++;

            }
            ac = 0;

            while (Acak.Length > 0)
            {
                Random Rand = new Random();
                int index = Rand.Next(Acak.Length);
                int x = Acak[index];
                y[i] = x;

                int Remove = x;
                int NumberIndex = Array.IndexOf(Acak, Remove);
                Acak = Acak.Where((val, idx) => idx != NumberIndex).ToArray();
                i++;
            }
            K = y[0];
            t = 0;
            i = 0;
            j = 0;
            z = 0;
            Quiz();
            int xy = 1;
            butir.Text = (xy.ToString());
        }

        private void score_TextChanged(object sender, EventArgs e)
        {

        }

        private void enam_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                PA.Checked = false;
                PB.Checked = false;
                PC.Checked = false;
                PD.Checked = false;
                PE.Checked = false;
                K = y[5];
                b = 5;
                int btr = 6;
                z = 0;
                butir.Text = btr.ToString();
                Quiz();
            }
            else Pesan();
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                PA.Checked = false;
                PB.Checked = false;
                PC.Checked = false;
                PD.Checked = false;
                PE.Checked = false;
                K = y[6];
                b = 6;
                int btr = 7;
                z = 0;
                butir.Text = btr.ToString();
                Quiz();
            }
            else Pesan();
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                PA.Checked = false;
                PB.Checked = false;
                PC.Checked = false;
                PD.Checked = false;
                PE.Checked = false;
                K = y[7];
                b = 7;
                int btr = 8;
                z = 0;
                butir.Text = btr.ToString();
                Quiz();
            }
            else Pesan();
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                PA.Checked = false;
                PB.Checked = false;
                PC.Checked = false;
                PD.Checked = false;
                PE.Checked = false;
                K = y[8];
                b = 8;
                int btr = 9;
                z = 0;
                butir.Text = btr.ToString();
                Quiz();
            }
            else Pesan();
        }

        private void sepuluh_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                PA.Checked = false;
                PB.Checked = false;
                PC.Checked = false;
                PD.Checked = false;
                PE.Checked = false;
                K = y[9];
                b = 9;
                int btr = 10;
                z = 0;
                butir.Text = btr.ToString();
                Quiz();
            }
            else Pesan();
        }

        private void CLEAR_Click_1(object sender, EventArgs e)
        {
            for (int ujian = 0; ujian < 9; ujian++) skor[ujian] = 0;
            {
                for (int ujian = 0; ujian < 9; ujian++) skor[ujian] = 0;
                Soal.Text = "";
                Nama.Text = "";
                PA.Checked = false; Satu.BackColor = Color.White;
                PB.Checked = false; dua.BackColor = Color.White;
                PC.Checked = false; tiga.BackColor = Color.White;
                PD.Checked = false; empat.BackColor = Color.White;
                lima.BackColor = Color.White;
                enam.BackColor = Color.White;
                tujuh.BackColor = Color.White;
                delapan.BackColor = Color.White;
                sembilan.BackColor = Color.White;
                sepuluh.BackColor = Color.White;
                score.Text = "";
                Nilaii.Text = "";
                z = 0;



            }
        }

        private void Minimum_Click(object sender, EventArgs e)
        {
            double[] new1 = new double[r];
            for (int i = 0; i < r; i++) new1[i] = X[i];
            double Minn = new1.Min();
            minimal.Text = Minn.ToString();
        }

        private void Maximum_Click(object sender, EventArgs e)
        {
            double[] new2 = new double[r];
            for (int i = 0; i < r; i++) new2[i] = X[i];
            double maxi = new2.Max();
            maximal.Text = maxi.ToString();
        }

        private void Rerata_Click(object sender, EventArgs e)
        {
            double[] new3 = new double[r];
            for (int i = 0; i < r; i++) new3[i] = X[i];
            double rata2 = new3.Average();
            Rata2.Text = rata2.ToString();
        }

        private void Kkm_Click(object sender, EventArgs e)
        {
            double stdd, jk = 0;
            for (int i = 0; i < 25; i++)
                jk += Math.Pow((X[i] - X.Average()), 2);
            stdd = Math.Sqrt(jk / 24);
            deviasi.Text = stdd.ToString("###.###");

        }

        private void Acak1_Click(object sender, EventArgs e)
        {
            DATA1.Items.Clear();
            Random acak = new Random();
            for (int i = 0; i < 25; i++) ;
            {
                X[i] = acak.Next(70, 90);
                DATA1.Items.Add(X[i].ToString("###"));
            }
        }

        private void Urutkan_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            double[] NewX = new double[r];
            DATA2.Items.Clear();
            double dummy = 0, no = 1;
            string faiz;


            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (X[i] > X[j])
                    {
                        dummy = X[i];
                        X[i] = X[j];
                        X[j] = dummy;
                        faiz = Y[i];
                        Y[i] = Y[j];
                        Y[j] = faiz;
                    }
                }

            }

            for (int i = 0; i < r; i++) NewX[i] = X[i];


            for (int i = 0; i < r; i++)
            {
                if (NewX[i] == 0) DATA2.Items.Add("0");
                else DATA2.Items.Add(NewX[i].ToString("###"));

                ListViewItem item = new ListViewItem(no.ToString());
                item.SubItems.Add(Y[i].ToString());
                if (X[i] == 0) item.SubItems.Add("0");
                else item.SubItems.Add(X[i].ToString("###"));
                if (X[i] > 70) item.SubItems.Add("Lulus");
                else item.SubItems.Add("Tidak Lulus");
                listView2.Items.AddRange(new ListViewItem[] { item });
                no++;

            }
        }

        private void Soal_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ARE YOU SURE TO EXIT ?", "WARNING !",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            NamaFile = "";
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Untuk Keluar ?", "WARNING !",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt|csv files (*.csv)|*.csv";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in DATA2.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Success");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
          listView2.Items.Clear();
          OpenFileDialog ofd = new OpenFileDialog();
          if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          {
              this.textBox1.Text = ofd.FileName;
          }
          System.Data.DataTable EXC = new System.Data.DataTable();
          EXC.TableName = "ExcelData";
          string SRC = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
          OleDbConnection CNT = new OleDbConnection(SRC);
          string SHT = "Select * from [Sheet1$]";
          OleDbDataAdapter DATA = new OleDbDataAdapter(SHT, CNT);
          DATA.Fill(EXC);

          //listView1.Items.Clear();
          for (int i = 0; i < EXC.Rows.Count; i++)
          {
              q++;
              DataRow drow = EXC.Rows[i];
              if (drow.RowState != DataRowState.Deleted)
              {
                  ListViewItem lvi = new ListViewItem(drow["Nama"].ToString());
                  lvi.SubItems.Add(drow["Nilai"].ToString());
                  lvi.SubItems.Add(drow["Keterangan"].ToString());
                  listView2.Items.Add(lvi);
              }
          }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog Sv = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (Sv.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Nama";
                    ws.Cells[1, 2] = "Nilai";
                    ws.Cells[1, 3] = "Keterangan";
                    int i = 2;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;

                        i++;
                    }
                    wb.SaveAs(Sv.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Your data complete", "Messege", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
