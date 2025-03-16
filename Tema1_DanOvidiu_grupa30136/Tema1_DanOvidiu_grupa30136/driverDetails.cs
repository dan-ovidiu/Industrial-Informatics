using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tema1_DanOvidiu_grupa30136
{
    
    public partial class driverDetails: Form
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int driversNumber { get; set; }
        public string team { get; set; }
        public driverDetails()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void driverDetails_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                !int.TryParse(textBox3.Text, out int driverNumber))
            {
                MessageBox.Show("Please enter valid details for the driver.");
                return;
            }
            this.name = textBox1.Text;
            this.surname = textBox2.Text;
            this.driversNumber = Convert.ToInt32(textBox3.Text);
            this.team = textBox4.Text;
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
