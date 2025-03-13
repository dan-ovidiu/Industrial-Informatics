using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2II
{
    public partial class Exercitiu3: Form
    {
        public Exercitiu3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void adunareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);

                double result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }

        private void scadereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);

                double result = num1 - num2;
                textBox3.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }

        private void inmultireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);

                double result = num1 * num2;
                textBox3.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }

        private void impartireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                if (num2 == 0)
                {
                    MessageBox.Show("Eroare: Împărțire la zero!");
                    return;
                }
                double result = num1 / num2;
                textBox3.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers!");
            }

        }
    }
}
