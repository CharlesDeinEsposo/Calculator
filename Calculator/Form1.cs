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

        private void button_Click(object sender, EventArgs e)
        {
            if (txt_output.Text == "0")
                txt_output.Clear();

            Button button = (Button)sender;
            txt_output.Text = txt_output.Text + button.Text;
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

        }

        private void dec_point_Click(object sender, EventArgs e)
        {

        }
    }
}
