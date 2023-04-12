using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InputBox.TextAlign = HorizontalAlignment.Right;
            OutputBox.TextAlign = HorizontalAlignment.Right;    
            this.BackColor = Color.Aqua;
            OutputBox.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "0";
            InputBox.Text = null;
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void OutputBox_TextChanged(object sender, EventArgs e)
        {
        //set to read only, cant change
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var outvalue = OutputBox.Text;
            double output = Convert.ToDouble(outvalue);
            double input;
            var sourcevalue = InputBox.Text;
            try
            {
                 input = Convert.ToDouble(sourcevalue);
                output += input;
                string outdisplay = Convert.ToString(output);
                InputBox.Text = " ";
                OutputBox.Text = outdisplay;
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Number");
            }
        }
        private void Sub_Click(object sender, EventArgs e)
        {
            var outvalue = OutputBox.Text;
            double output = Convert.ToDouble(outvalue);
            double input;
            var sourcevalue = InputBox.Text;
            try
            {
                input = Convert.ToDouble(sourcevalue);
                output -= input;
                string outdisplay = Convert.ToString(output);
                InputBox.Text = " ";
                OutputBox.Text = outdisplay;
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Number");
            }
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            var outvalue = OutputBox.Text;
            double output = Convert.ToDouble(outvalue);
            double input;
            var sourcevalue = InputBox.Text;
            try
            {
                input = Convert.ToDouble(sourcevalue);
                output *= input;
                string outdisplay = Convert.ToString(output);
                InputBox.Text = " ";
                OutputBox.Text = outdisplay;
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Number");
            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            var outvalue = OutputBox.Text;
            double output = Convert.ToDouble(outvalue);
            double input;
            var sourcevalue = InputBox.Text;
            try
            {
                input = Convert.ToDouble(sourcevalue);
                output /= input;
                string outdisplay = Convert.ToString(output);
                InputBox.Text = " ";
                OutputBox.Text = outdisplay;
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Number");
            }
        }

        private void Calculator_label_Click(object sender, EventArgs e)
        {

        }
    }
}
