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
    public partial class Exercitiu4 : Form
    {
        public Exercitiu4()
        {
            InitializeComponent();

            StreamWriter streamWriter = new StreamWriter("exercitiu4.txt");
            streamWriter.WriteLine("RedBull\nFerrari\nAston Martin\nMercedes\nWilliams");
            streamWriter.Close();

            StreamReader streamReader = new StreamReader(path: "exercitiu4.txt");
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                string teamName = item.ToString();
                ShowTeamImage(teamName);
            }
        }
        private void ShowTeamImage(string teamName)
        {
            string imagePath = "";

            switch (teamName)
            {
                case "RedBull":
                    imagePath = "redbull.jpg";
                    break;
                case "Ferrari":
                    imagePath = "ferrari.jpg";
                    break;
                case "Aston Martin":
                    imagePath = "astonmartin.jpg";
                    break;
                case "Mercedes":
                    imagePath = "mercedes.jpg";
                    break;
                case "Williams":
                    imagePath = "williams.jpg";
                    break;
                default:
                    pictureBox1.Image = null;
                    return;
            }

            if (System.IO.File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show($"Imaginea pentru {teamName} nu a fost găsită!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Your answer is correct! Scuderia Ferrari has 249 wins in F1.");
            }
            else
            {
                MessageBox.Show("Your answer is incorrect! Try again!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                MessageBox.Show("Your answer is correct! Max Verstappen won the Driver's Championship in 2024 with his RB20.");
            }
            else
            {
                MessageBox.Show("Your answer is incorrect! Try again!");
            }
        }
    }
}