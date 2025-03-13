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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myStr;
            myStr = inputText.Text;
            resultedText.Text = myStr;
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void showForm1_Click(object sender, EventArgs e)
        {
            startButton firstForm = new startButton();
            firstForm.Show();
        }
    }
}
