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


    }
}
