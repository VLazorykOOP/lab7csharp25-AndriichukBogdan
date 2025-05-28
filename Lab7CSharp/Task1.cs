using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        static bool divide = false;
        static bool multiply = false;
        static bool minus = false;
        static bool plus = false;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            divide = false;
            multiply = false;
            plus = false;
            minus = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            divide = false;
            multiply = true;
            plus = false;
            minus = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            divide = true;
            multiply = false;
            plus = false;
            minus = false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

            try
            {
                if (plus) ResultText.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
                if (minus) ResultText.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text));
                if (multiply) ResultText.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));
                if (divide) { 
                    if(Convert.ToDouble(textBox2.Text) == 0)
                    {
                        ResultText.Text = "Divide by 0";
                    }
                    else ResultText.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
                    
                }
            }
            catch (FormatException)
            {
                ResultText.Text = "Try numbers(use , )";
            }
            catch (DivideByZeroException)
            {
                ResultText.Text = "Divide by 0";
            }

        }

        private void Plus_CheckedChanged(object sender, EventArgs e)
        {
            divide = false;
            multiply = false;
            plus = true;
            minus = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
