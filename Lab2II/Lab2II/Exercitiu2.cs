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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2II
{
    public partial class Exercitiu2: Form
    {
        public Exercitiu2()
        {
            InitializeComponent();
            StreamWriter streamWriter = new StreamWriter("exercitiu2.txt");
            streamWriter.WriteLine("Exercitiul al doilea e usor\nNe place la facultate");
            streamWriter.Close();

            StreamReader streamReader = new StreamReader(path: "exercitiu2.txt");
            {
                string line = string.Empty;
                listBox1.Items.Clear();

                listBox1.BeginUpdate();
                while ((line = streamReader.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                listBox1.EndUpdate();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (listBox1.SelectedItems.Count > 0)
            {
                listBox2.BeginUpdate();
                foreach (var item in listBox1.SelectedItems)
                {
                    listBox2.Items.Add(item);
                }
                listBox2.EndUpdate();
            }
            else
            {
                MessageBox.Show("No items found in list box number 1.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
