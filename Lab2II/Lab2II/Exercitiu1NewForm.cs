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
    public partial class Exercitiu1NewForm: Form
    {
        public string username;
        public Exercitiu1NewForm(string username)
        {
            InitializeComponent();
            label1.Text = "Hello " + username;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
