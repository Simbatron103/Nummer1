using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nummer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sum = 0;
        int number = 1;
        int bigman = 1;
        private void button1_Click(object sender, EventArgs e)
        {

            int sum = int.Parse(textBox1.Text);
            int bigman = int.Parse(textBox2.Text);
            while (sum < bigman)
            {
                sum = sum + number;
             
                textBox3.Text = textBox3.Text + sum.ToString() +" ";

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(textBox1.Text);
            int bigman = int.Parse(textBox2.Text);
            while (sum < bigman)
            {
               bigman = bigman - number;

                textBox3.Text = textBox3.Text + bigman.ToString() + " ";

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(textBox1.Text);
            int bigman = int.Parse(textBox2.Text);
            while (sum < bigman)
            {
                sum = sum + number;
                if (sum % 2 == 1)
                {
                    
                    textBox3.Text = textBox3.Text + sum.ToString() + " ";
                }
                

                
                  
                

               

            }
            
        }
    }
}
