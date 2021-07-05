﻿using System;
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
            txt_output2.Text = "";
        }
        private void clear_entry_Click(object sender, EventArgs e)
        {
            txt_output2.Text = "";
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
            txt_output2.Text = txt_output.Text + " " + b.Text;

            //pending
            if (num1 != 0)
            {

            }
            //


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
                    txt_output2.Text = ("sqr(" + num1 + ")");
                    break;

                case "√x":
                    txt_output.Text = Math.Sqrt(num1).ToString();
                    txt_output2.Text = ("√" + "(" + num1 + ")");
                    break;

                case "%":
                    txt_output.Text = (num1 * 0.01).ToString();
                    txt_output2.Text = ("1/(" + num1 + ")");
                    break;

                case "1 / x":
                    txt_output.Text = (1 / num1).ToString();
                    txt_output2.Text = ("1/(" + num1 + ")");
                    break;

                default:
                    break;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {

            txt_output2.Text = "";
            

            switch (operation)
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

        private void Hisory_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Memory_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void History_Button_Click(object sender, EventArgs e)
        {
            Memory_Color.Visible = false;
            Memory_Label.Visible = false;
            Memory_TextBox.Visible = false;

            History_Color.Visible = true;
            History_Label.Visible = true;
            Hisory_TextBox.Visible = true;
        }

        private void Memory_Button_Click(object sender, EventArgs e)
        {
            Memory_Color.Visible = true;
            Memory_Label.Visible = true;
            Memory_TextBox.Visible = true;

            History_Color.Visible = false;
            History_Label.Visible = false;
            Hisory_TextBox.Visible = false;
        }
    }
}
