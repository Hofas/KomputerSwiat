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
        public int length;
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
            if (e.KeyCode == Keys.Enter && length == 0)
            {
                label1.Visible = false;
                textBox1.Visible = false;
                label29.Visible = true;


                length = textBox1.Text.Length;
                word = textBox1.Text;
                for (int i = 2; i < length + 2; i++)
                {
                    var labels = Controls.Find("label" + i, true);
                    var label = (Label)labels[0];

                    label.Visible = true;
                }
               

            }


            if (length > 0)
            {
                label29.Text = e.KeyCode.ToString();
                


            }
            

            

            
        }

        private void trafienie()
        {
            //if (label29.Visible == true)
            //{
            
                for (int i = 0; i < length; i++)
                {

                    if (Convert.ToString(word[i]) == Convert.ToString(label29.Text))
                    {
                        var labels = Controls.Find("label" + i, true);
                        var label = (Label)labels[0];
                        label.Text = label29.Text;

                    }


                }
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          label29.Text = e.KeyCode.ToString();

            for (int i = 0; i < 2; i++)
            {
                MessageBox.Show(Convert.ToString(i));

            }

        }

    }
}
