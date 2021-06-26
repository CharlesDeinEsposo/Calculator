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
        Double num1 = 0;
        bool  basic_operation_clck = false;

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
            else if (txt_output.Text == "0")
            {
                txt_output.Clear();
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
            if (txt_output.Text.Length > 0)
            {
                txt_output.Text = txt_output.Text.Remove(txt_output.Text.Length - 1, 1);
            }
            if (txt_output.Text.Length == 0)
                txt_output.Text = "0";
        }

        private void bsc_oprtr_clck(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            num1 = Double.Parse(txt_output.Text);
            basic_operation_clck = true;
            txt_output.Text = "";
        }
        private void adv_oprtr_clck(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            num1 = Double.Parse(txt_output.Text);
            basic_operation_clck = true;

            switch (operation)
            {
                case "±":
                    txt_output.Text = (num1 * -1).ToString();
                    break;

                case "x^2":
                    txt_output.Text = (num1 * num1).ToString();
                    break;

                case "√x":
                    txt_output.Text = Math.Sqrt(num1).ToString();
                    break;

                case "%":
                    txt_output.Text = (num1 * num1 * 0.01).ToString();
                    break;

                default:
                    break;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
            //bsc_oprtr
                case "+":
                    txt_output.Text = (num1 + Double.Parse(txt_output.Text)).ToString();
                    break;

                case "-":
                    txt_output.Text = (num1 - Double.Parse(txt_output.Text)).ToString();
                    break;

                case "÷":
                    txt_output.Text = (num1 / Double.Parse(txt_output.Text)).ToString();
                    break;

                case "x":
                    txt_output.Text = (num1 * Double.Parse(txt_output.Text)).ToString();
                    break;

                default:
                    break;

            }
        }

    }
}
