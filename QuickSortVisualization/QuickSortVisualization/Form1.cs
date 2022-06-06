using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSortVisualization
{
    public partial class Form1 : Form
    {
        int[] niz = new int[31];
        DateTime pocetak, kraj;
        int BrPoziva = 0;
        int BrZamijena = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //BOJE:
        Color Pozadina = Color.FromArgb(183, 228, 199);
        Color index1 = Color.FromArgb(239, 99, 81);
        Color index2 = Color.FromArgb(243, 131, 117);
        Color clan1 = Color.FromArgb(82, 183, 136);
        Color  clan2 = Color.FromArgb(60,60,60);
        //FUNKCIJE
        private void Nacrtaj(int p,int c)
        {
            Graphics g = pictureBox1.CreateGraphics();
            SolidBrush Cetka = new SolidBrush(Color.FromArgb(70, 70, 70));
            pictureBox1.Refresh();
            int x = 1;
            for (int i = 0; i < 30; i++)
            {
                if (p == i) Cetka.Color = index1;
                else if (c == i) Cetka.Color = index2;
                else if (i > p && i < c) Cetka.Color = clan1;
                else Cetka.Color = clan2;
                g.FillRectangle(Cetka, x, pictureBox1.Height - niz[i] * 8, 20, niz[i] * 8 - 1);
                x += 21;
            }
            kraj = DateTime.Now;
            TimeSpan ts = kraj - pocetak;
            VrijemeLabel.Text = "Vrijeme: " + ts.TotalSeconds.ToString() + " s";
            label1.Text = "Broj poziva: " + BrPoziva;
            label2.Text = "Broj zamijena: " + BrZamijena;
            VrijemeLabel.Update();
            label1.Update();
            label2.Update();
            System.Threading.Thread.Sleep(trackBar1.Value);
            g.Dispose();
            Cetka.Dispose();
        }
        private void Swap(int i, int j)
        {
            int temp = niz[i];
            niz[i] = niz[j];
            niz[j] = temp;
            BrZamijena++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(216, 243, 220);
            pictureBox1.BackColor = Pozadina;
            for (int i = 0; i < 30; i++)
                niz[i] = i + 1;
            RS_button_Click(this, null);
        }

        private void RS_button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                int j = rnd.Next(i, 30);
                Swap(i, j);
            }
            Nacrtaj(-1,-1);
            VrijemeLabel.Text = "Vrijeme: ";
            label1.Text = "Broj poziva: ";
            label2.Text = "Broj zamijena: ";
        }
        //KOD ZA VIZUALIZACIJU BUBBLE SORT ALGORITMA
        private void BS_button_Click(object sender, EventArgs e)
        {
            BrPoziva = 0;
            BrZamijena = 0;
            pocetak = DateTime.Now;
            for(int i=0;i<30;i++)
            {
                for(int j=i;j<30;j++)
                {
                    if(niz[i]>niz[j])
                    {
                        Swap(i, j);
                        Nacrtaj(i,j);
                    }
                    BrPoziva++;
                }

            }
            Nacrtaj(-1, -1);
        }
        //KOD ZA VIZUALIZACIJU QUCKSORT ALGORITMA
        int podjela(int l,int h)//low,high
        {
            BrPoziva++;
            int pivot = niz[l];
            int i = l, j = h;
            do{
                do { i++; } while (niz[i] <= pivot);
                do { j--; } while (niz[j] > pivot);
                if (i < j)
                {
                    Swap(i, j);
                    Nacrtaj(i, j); 
                }  
            }while(i<j);
            Swap(l, j);
            Nacrtaj(j, l);
            return j;
        }
        void quicksort(int l,int h)
        {
            BrPoziva++;
            int j;
            if(l<h)
            {
                j = podjela(l, h);
                quicksort(l, j);
                quicksort(j + 1, h);
            }
        }
        private void QS_button_Click(object sender, EventArgs e)
        {
            niz[30] = Int32.MaxValue;
            BrPoziva = 0;
            BrZamijena = 0;
            pocetak = DateTime.Now;
            quicksort(0, 30);
            Nacrtaj(-1, -1);
        }

    }
}
