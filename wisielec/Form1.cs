using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wisielec
{
    public partial class Form1 : Form
    {
        string slowo;
        int ile_pudel = 0;

        public Form1()

        {
            InitializeComponent();
            losuj_slowo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string litera = textBox1.Text;
            bool czy_trafiony = false;
            int gdzie_trafiony = 0;
            for (int i = 1; i < 6; i++)
                
            {
                if (Convert.ToString(slowo[i]) == litera) 
                {
                    czy_trafiony = true;
                    gdzie_trafiony = i;
                    if (gdzie_trafiony == 1) {label2.Text = litera;}
                    if (gdzie_trafiony == 2) {label3.Text = litera;}
                    if (gdzie_trafiony == 3) {label4.Text = litera;}
                    if (gdzie_trafiony == 4) {label5.Text = litera;}
                    if (gdzie_trafiony == 5) {label6.Text = litera;}
                }
            }
            if (czy_trafiony == false)

            {
                ile_pudel = ile_pudel + 1;
                if (ile_pudel == 1) { pictureBox1.Image = wisielec.Properties.Resources.w1; }
                if (ile_pudel == 2) { pictureBox1.Image = wisielec.Properties.Resources.w2; }
                if (ile_pudel == 3) { pictureBox1.Image = wisielec.Properties.Resources.w3; }
                if (ile_pudel == 4) { pictureBox1.Image = wisielec.Properties.Resources.w4; }
                if (ile_pudel == 5) { pictureBox1.Image = wisielec.Properties.Resources.w5; }

            }
        }

        private void losuj_slowo()

        {
            
            string[] slowa = {"krokusy", "liliput", "marchew", "selerek", "klakier", "krakers" };
            int ile_slow = slowa.Length;
            Random gen = new Random();
            int index_slowa = gen.Next(0, ile_slow);
            slowo = slowa[index_slowa];
            label1.Text = Convert.ToString(slowo[0]);
            label7.Text = Convert.ToString(slowo[6]);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
