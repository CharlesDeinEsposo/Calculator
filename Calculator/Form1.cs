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
        string operation = "";
        float storednumber;
        double num1 , num2;
        bool  basic_operation_clck = false;

        public Form1()
        {
            InitializeComponent();
            Memory_Textbox.SelectionAlignment = HorizontalAlignment.Right;
            History_Textbox.SelectionAlignment = HorizontalAlignment.Right;
            memory_clear.Enabled = false;
            memory_add.Enabled = false;
            memory_subtract.Enabled = false;
            memory_recall.Enabled = false;
        }
        //------------------------------------------------------------------------------------- Start of Number Buttons ----------------------------------------------------------------------------------------
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

        //------------------------------------------------------------------------------------ Start of Operation Buttons -----------------------------------------------------------------------------------------
        private void bsc_oprtr_clck(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                if (num1 != 0)
                {                
                        equals.PerformClick();
                        operation = b.Text;
                        txt_output2.Text = num1 + " " + operation;
                        txt_output.Text = "";            }
                else
                {
                    operation = b.Text;
                    num1 = Double.Parse(txt_output.Text);
                    txt_output2.Text = txt_output.Text + " " + b.Text;
                    txt_output.Text = "";
                }
            }
            catch
            {
                txt_output.Text = "Math Error!";
                delete.Enabled = false;
            }
        }
        private void adv_oprtr_clck(object sender, EventArgs e)
        {
            try
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
                        txt_output.Text = Math.Pow(num1, 2).ToString();
                        txt_output2.Text = ("sqr(" + num1 + ")");
                        break;

                    case "√x":
                        txt_output.Text = Math.Sqrt(num1).ToString();
                        txt_output2.Text = ("√" + "(" + num1 + ")");
                        break;

                    case "1 / x":
                        txt_output.Text = (1 / num1).ToString();
                        txt_output2.Text = ("1/(" + num1 + ")");
                        break;

                    case "%":
                        txt_output.Text = (num1 / 100).ToString(); 
                        break;


                    default:
                        break;
                }
                History_Textbox.AppendText(num1 + operation + "\n" + "=" + txt_output.Text + "\n\n");

            }
            catch
            {
                txt_output.Text = "Math Error!";
                delete.Enabled = false;
            }
   
        }

        private void equals_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(txt_output.Text);
            try
            {
                txt_output2.Text = "";
                switch (operation)
                {
                    //bsc_oprtr
                    case "+":
                           txt_output.Text = (num1 + Double.Parse(txt_output.Text)).ToString();
                           History_Textbox.AppendText((num1 + operation) + num2 + ("\n" + "=") + txt_output.Text + "\n\n");

                        break;

                    case "-":
                        txt_output.Text = (num1 - Double.Parse(txt_output.Text)).ToString();
                        History_Textbox.AppendText((num1 + operation) + num2 + ("\n" + "=") + txt_output.Text + "\n\n");
                        break;

                    case "÷":
                        txt_output.Text = (num1 / Double.Parse(txt_output.Text)).ToString();
                        History_Textbox.AppendText((num1 + operation) + num2 + ("\n" + "=") + txt_output.Text + "\n\n");
                        break;

                    case "x":
                        txt_output.Text = (num1 * Double.Parse(txt_output.Text)).ToString();
                        History_Textbox.AppendText((num1 + operation) + num2 + ("\n" + "=") + txt_output.Text + "\n\n");
                        break;

                    default:
                        break;
                }
                num1 = Double.Parse(txt_output.Text);
                operation = " ";
            }
            catch
            {
                txt_output.Text = "Math Error!";
            }
            
        }

        //------------------------------------------------------------------------------ Start of Delete and Clear buttons -------------------------------------------------------------------------------
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

        //------------------------------------------------------------------------------Start of Memory and History buttons ----------------------------------------------------------------------------------

        private void History_Button_Click(object sender, EventArgs e)
        {
            Memory_Color.Visible = false;
            Memory_Label.Visible = false;
            Memory_Textbox.Visible = false;

            History_Color.Visible = true;
            History_Label.Visible = true;
            History_Textbox.Visible = true;

            if (History_Textbox.Text.Length > 0)
            {
                History_Label.Visible = false;
            }
            else
            {
                History_Label.Visible = true;

            }
        }

        private void Memory_Button_Click(object sender, EventArgs e)
        {
            Memory_Color.Visible = true;
            Memory_Label.Visible = true;
            Memory_Textbox.Visible = true;

            History_Color.Visible = false;
            History_Label.Visible = false;
            History_Textbox.Visible = false;

                if (Memory_Textbox.Text.Length > 0)
                {
                    Memory_Label.Visible = false;
                }
                else
                {
                    Memory_Label.Visible = true;
                }

            }

        private void memory_save_Click(object sender, EventArgs e)
        {
            storednumber = float.Parse(txt_output.Text);
            memory_add.Enabled = true;
            memory_subtract.Enabled = true;
            memory_clear.Enabled = true;
            memory_recall.Enabled = true;

            Memory_Textbox.AppendText(txt_output.Text + "\n\n");

            if (Memory_Textbox.Text.Length > 0)
            {
                Memory_Label.Visible = false;
            }
            else
            {
                Memory_Label.Visible = true;
            }
        }
        private void memory_clear_Click(object sender, EventArgs e)
        {
            Memory_Textbox.Clear();
        }

        private void memory_recall_Click(object sender, EventArgs e)
        {
            txt_output.Text = string.Format("{0:N0}", storednumber);
        }

        private void memory_add_Click(object sender, EventArgs e)
        {
            storednumber += float.Parse(txt_output.Text);
            Memory_Textbox.Text = string.Format("{0:N0}", storednumber);
        }

        private void memory_subtract_Click(object sender, EventArgs e)
        {
            storednumber -= float.Parse(txt_output.Text);
            Memory_Textbox.Text = string.Format("{0:N0}", storednumber);
        }

        private void History_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (History_Textbox.Text.Length > 0)
            {
                History_Label.Visible = false;
            }
            else
            {
                History_Label.Visible = true;
            }
        }
    }
}
