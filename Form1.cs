using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HesapMakinesi_Tekrar1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            textBox3.Text = "0";
        }
        
        private int topla(int s1,int s2)
        {
            return s1 + s2;
        }
        private int cikra(int s1, int s2)
        {
            return s1 - s2;
        }
        private int carp(int s1, int s2)
        {
            return s1 * s2;
        }
        private int böl(int s1, int s2)
        {
            return s1 / s2;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            int s1, s2;
            label2.Text = button2.Text;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = topla(s1, s2).ToString() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2;
            label2.Text = button1.Text;
            s1 = Convert.ToInt32(textBox1.Text);
            s2=Convert.ToInt32(textBox2.Text);
            textBox3.Text = cikra(s1, s2).ToString();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
                
            }
            
            else if (label2.Text==button2.Text)
            {   int s1, s2;
                 s1=Convert.ToInt16(textBox1.Text);
                 s2=Convert.ToInt16(textBox2.Text);
                
                textBox3.Text = topla(s1, s2).ToString();
            }
            else if (label2.Text == button1.Text)
            {
                int s1, s2;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);

                textBox3.Text = cikra(s1, s2).ToString();
            }
            else if (label2.Text == button3.Text)
            {
                if (textBox1.Text=="0")
                {
                    textBox3.Text = "0";
                }
                else if(textBox1.Text!="")
                {
                int s1, s2;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);

                textBox3.Text = böl(s1, s2).ToString();
                }
                
            }
            else if (label2.Text == button4.Text)
            {
                if (textBox1.Text == "0")
                {
                    textBox3.Text = "0";
                }
                else
                {
                    int s1, s2;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);

                textBox3.Text = carp(s1, s2).ToString();
                }
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";

            }
            
            else if (label2.Text == button2.Text)
            {
                int s1, s2;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);

                textBox3.Text = topla(s1, s2).ToString();
            }
            else if (label2.Text == button1.Text)
            {
                int s1, s2;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);

                textBox3.Text = cikra(s1, s2).ToString();
            }
            else if (label2.Text == button3.Text)
            {
                if (textBox2.Text == "0")
                {
                    textBox3.Text = "0";
                }
                else
                {
                int s1, s2;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);

                textBox3.Text = böl(s1, s2).ToString();
                }
                
            }
            else if (label2.Text == button4.Text)
            {
                if (textBox2.Text == "0")
                {
                    textBox3.Text = "0";
                }
                else
                {
                int s1, s2;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);

                textBox3.Text = carp(s1, s2).ToString();
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int s1, s2;
            label2.Text = button3.Text;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = böl(s1, s2).ToString();
            }
            catch (Exception)
            {
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1, s2;
            label2.Text = button4.Text;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = carp(s1, s2).ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
