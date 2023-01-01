using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        string error = "please try again missing number";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        
        private void result_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToSingle(textBox1.Text);
                double num2 = Convert.ToSingle(textBox2.Text);
                result.Text = (num1 + num2).ToString();

            }
            catch (System.FormatException)
            {

                MessageBox.Show(error);
            }
            
        }
        

        private void subtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToSingle(textBox1.Text);
                double num2 = Convert.ToSingle(textBox2.Text);
                result.Text = (num1 - num2).ToString();

            }
            catch (System.FormatException)
            {

                MessageBox.Show(error);
            }
            
        }

        private void multipleButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToSingle(textBox1.Text);
                double num2 = Convert.ToSingle(textBox2.Text);
                result.Text = (num1 * num2).ToString();

            }
            catch (System.FormatException)
            {

                MessageBox.Show(error);
            }
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToSingle(textBox1.Text);
                double num2 = Convert.ToSingle(textBox2.Text);
                result.Text = (num1 / num2).ToString();

            }
            catch (System.FormatException)
            {

                MessageBox.Show(error);
            }
            
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            try
            {
                int factorial = 1;
                int num = int.Parse(textBox1.Text);
                for (int i = num; i >= 1; i--)
                {
                    factorial = factorial * i;
                }
                result.Text = factorial.ToString();
                if (textBox2.Text.Length > 0)
                {
                    textBox2.Text = "";
                }

            }
            catch (System.FormatException)
            {

                MessageBox.Show(error);
            }
            
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = int.Parse(textBox1.Text);
                double num2 = int.Parse(textBox2.Text);
                result.Text = Math.Pow(num1, num2).ToString();

            }
            catch (System.FormatException)
            {

                MessageBox.Show(error);
            }
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToSingle(textBox1.Text);
                double num2 = Convert.ToSingle(textBox2.Text);
                result.Text = (num1 % num2).ToString();

            }
            catch (System.FormatException)
            {

                MessageBox.Show(error);
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            result.Text = "0-0-0-0";
            MessageBox.Show("the text was cleared");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("do you want to exit", "bye", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
