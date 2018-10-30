using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WisielecPH
{
    public partial class Form1 : Form
    {
        int length;
        string word;
        public Form1()
        {
            InitializeComponent();
            
        }
        // validacja tylko litery bez spacji 
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) { e.Handled = true; }
           
        }
                
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                label1.Visible = false;
                textBox1.Visible = false;
                label29.Visible = true;
                
                
                length = textBox1.Text.Length;
                word = textBox1.Text;
                for (int i = 2; i < length+2; i++)
                {
                    var labels = Controls.Find("label" + i, true);
                    var label = (Label)labels[0];

                    label.Visible = true;
                }
              

            }
            label29.Text = e.KeyCode.ToString();
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label29.Text = e.KeyCode.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
