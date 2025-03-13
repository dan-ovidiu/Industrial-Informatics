using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2II
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Click_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("fisier.txt", true);
            streamWriter.WriteLine("Limbaj de programare");
            streamWriter.Close();

            StreamReader streamReader = new StreamReader(path:"fisier.txt");
            {
                string line = string.Empty;
                while((line = streamReader.ReadLine()) != null)
                {
                    string[] tempArray = line.Split(' ');
                    textBox1.Text = tempArray[0];
                    textBox2.Text = tempArray[1];
                    textBox3.Text = tempArray[2];
                }
            }
        }
    }
}
