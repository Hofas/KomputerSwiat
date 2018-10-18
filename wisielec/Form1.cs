﻿using System;
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
        

        private void Wygrana()
        {
            if (label2.Text != "_" && label3.Text != "_" && label4.Text != "_" && label5.Text != "_" && label6.Text != "_")
            { pictureBox1.Image = wisielec.Properties.Resources.w_win;
                button2.Visible = true;
            }
        }

        public Form1()

        {
            InitializeComponent();
            losuj_slowo();
            this.ActiveControl = textBox1;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ile_pudel < 5)
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
                        if (gdzie_trafiony == 1) { label2.Text = litera; }
                        if (gdzie_trafiony == 2) { label3.Text = litera; }
                        if (gdzie_trafiony == 3) { label4.Text = litera; }
                        if (gdzie_trafiony == 4) { label5.Text = litera; }
                        if (gdzie_trafiony == 5) { label6.Text = litera; }
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
                Wygrana();
            }
            else { pictureBox1.Image = wisielec.Properties.Resources.w_loose;
                button2.Visible = true;
            }
            textBox1.Text = null;
            textBox1.Focus();


            


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

        private void button2_Click(object sender, EventArgs e)
        {
            losuj_slowo();
            ile_pudel = 0;
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            button2.Visible = false;
            pictureBox1.Image = null;

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { button1_Click(this, new EventArgs());   }
        }

        
    }
}
