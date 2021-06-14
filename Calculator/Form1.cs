using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            txt_output.Text = "0";
            txt_output.Clear();
            txt_output.Text = txt_output.Text + number_0.Text;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txt_output.Text = "0";
            txt_output.Clear();
            txt_output.Text = txt_output.Text + number_1.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_output.Text = "0";
            txt_output.Clear();
            txt_output.Text = txt_output.Text + number_2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_output.Text = "0";
            txt_output.Clear();
            txt_output.Text = txt_output.Text + number_3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_output.Text = "0";
            txt_output.Clear();
            txt_output.Text = txt_output.Text + number_4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_output.Clear();
            txt_output.Text = txt_output.Text + number_5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            txt_output.Text = txt_output.Text + number_6.Text;
            txt_output.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_output.Text = txt_output.Text + number_7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_output.Text = txt_output.Text + number_8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt_output.Text = txt_output.Text + number_9.Text;
        }




        private void txt_output_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_output.Text = "0";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            txt_output.Text = "0";
        }

        private void dec_point_Click(object sender, EventArgs e)
        {

        }
        double value1 = 0;
        double value2 = 0;

        bool add = false;
        bool subtract = false;
        bool divide = false;
        bool multiply = false;


        private void equals_Click(object sender, EventArgs e)
        {
            if (add == true) ;
            {
                value2 = 1 + double.Parse(txt_output.Text);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            bool add = true;
            bool subtract = false;
            bool divide = false;
            bool multiply = false;

            value1 = 1 + double.Parse(txt_output.Text);

        }


    }
}
