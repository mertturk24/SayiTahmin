using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hafta3
{
    public partial class Form1 : Form
    {

        int degisken2;
        int degisken1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random salla = new Random();
            degisken1 = salla.Next(1,100);
           // label1.Text=degisken1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            degisken2=Convert.ToInt32( textBox1.Text);

            if (degisken1 == degisken2)
            {
                MessageBox.Show("Bildin");

            }
            else
            {
               
                if (degisken1 > degisken2)
                {

                    MessageBox.Show("Yanlış Arttır");
                }
                else
                {
                    MessageBox.Show("Yanlış Azalt");
                }
            }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
