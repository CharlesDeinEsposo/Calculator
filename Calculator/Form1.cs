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
        String operation = "";
        Double num1, num2;

        public Form1()
        {
            InitializeComponent();
        }
        //number buttons
        private void numbers_Click(object sender, EventArgs e)
        {
            Button nmbrs = (Button)sender;

            if (nmbrs.Text == ".")
            {
                if (!txt_output.Text.Contains("."))
                    txt_output.Text = txt_output.Text + nmbrs.Text;
                if (txt_output.Text == "0")
                    txt_output.Text = txt_output.Text + nmbrs.Text;
            }
            else
                txt_output.Text = txt_output.Text + nmbrs.Text;
        }
        private void clear_Click(object sender, EventArgs e)
        {
            txt_output.Text = "0";
        }

        private void delete_Click(object sender, EventArgs e)
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
