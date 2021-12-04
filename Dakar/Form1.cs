using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dakar
{
    public partial class Form1 : Form
    {
        enum TypObtiznosti
        {
            Lehka,
            Tezka

        }
        TypObtiznosti Obtížnost = TypObtiznosti.Lehka;
        public Form1()
        {
            InitializeComponent();
        }
        public int prvniHotovo;
        bool stop = false;
        int pocetBodu = 0;
        private async void button1_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int kolikrat = dice.Next(10, NastaveníRychlosti);
            int Speed;
            Speed = 0;
            stop = false;
            int kakanec = kolikrat;
            for (int i = 1; i <= kakanec; i++)
            {
                Speed = Speed + 1;
                if (prvniHotovo == 0)
                {
                    label1.Text = Speed.ToString();
                    label1.Refresh();
                    label1.ForeColor = Color.Purple;
                    label1.Font = new Font("Arial", 72, FontStyle.Bold);
                }
                if (prvniHotovo == 1)
                {
                    label2.Text = Speed.ToString();
                    label2.Refresh();
                    label2.ForeColor = Color.Purple;
                    label2.Font = new Font("Arial", 72, FontStyle.Bold);
                }
                if (prvniHotovo == 2)
                {
                    label3.Text = Speed.ToString();
                    label3.Refresh();
                    label3.ForeColor = Color.Purple;
                    label3.Font = new Font("Arial", 72, FontStyle.Bold);
                }
                if (Speed == 10)
                {
                    Speed = 0;
                }
                await Task.Delay(kolo);
                if (stop == true)
                {
                    break;
                }
            }
            prvniHotovo = prvniHotovo + 1;
            if (prvniHotovo == 3)
            {
                label11.Text = label11.Text + 1;
                if (label1.Text == label2.Text)
                {
                    pocetBodu = pocetBodu + 10;
                }
                if (label1.Text == label3.Text)
                {
                    pocetBodu = pocetBodu + 10;
                }
                if (label2.Text == label3.Text)
                {
                    pocetBodu = pocetBodu + 10;
                }
                if ((label1.Text == label2.Text) && (label3.Text == label2.Text))
                {
                    pocetBodu = pocetBodu + 70;
                }
                label4.Text = pocetBodu.ToString();
                label4.ForeColor = Color.Purple;
                label4.Font = new Font("Arial", 72, FontStyle.Bold);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop = true;
        }
        int kolo = 0;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            kolo = trackBar1.Value; 
            kolo = kolo * 100;
            label6.Text = kolo.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = kolo.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kolo = 400;
            PřevedeníNačáru1();
        }

        private void PřevedeníNačáru1()
        {
            label6.Text = kolo.ToString();
            trackBar1.Value = kolo / 100;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kolo = 200;
            PřevedeníNačáru1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kolo = 100;
            PřevedeníNačáru1();
        }
        int NastaveníRychlosti = 0;
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            NastaveníRychlosti = trackBar2.Value;
            NastaveníRychlosti = NastaveníRychlosti * 10;
            label9.Text = NastaveníRychlosti.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            NastaveníRychlosti = 100;
            Usnadnění();

        }

        private void Usnadnění()
        {
            label9.Text = NastaveníRychlosti.ToString();
            trackBar2.Value = NastaveníRychlosti / 10;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NastaveníRychlosti = 50;
            Usnadnění();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NastaveníRychlosti = 10;
            Usnadnění();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            prvniHotovo = 0;
            label1.Text = 0.ToString();
            label2.Text = 0.ToString();
            label3.Text = 0.ToString();
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
