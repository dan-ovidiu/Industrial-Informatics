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
using System.Xml.Linq;

namespace Tema1_DanOvidiu_grupa30136
{
    public partial class Form2: Form
    {
        BindingList<Drivers> driversList = new BindingList<Drivers>();
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;

            teamOrder.BeginUpdate();
            teamOrder.Items.Add("Mclaren");
            teamOrder.Items.Add("Mercedes");
            teamOrder.Items.Add("Red Bull Racing");
            teamOrder.Items.Add("Williams");
            teamOrder.Items.Add("Aston Martin");
            teamOrder.EndUpdate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            driversList.Add(new Drivers { name = "Verstappen", surname = "Max", driversNumber = 1, team = "RedBull" });
            driversList.Add(new Drivers { name = "Alonso", surname = "Fernando", driversNumber = 14, team = "Aston Martin" });
            driversList.Add(new Drivers { name = "Hamilton", surname = "Lewis", driversNumber = 44, team = "Ferrari" });
            driversList.Add(new Drivers { name = "Leclerc", surname = "Charles", driversNumber = 14, team = "Ferrari" });
            driversList.Add(new Drivers { name = "Sainz", surname = "Carlos", driversNumber = 55, team = "Williams" });

            dataGridView1.DataSource = driversList;
        }

        private void addDriverButton_Click(object sender, EventArgs e)
        {
            using (driverDetails detailsForm = new driverDetails())
            {
                if (detailsForm.ShowDialog() == DialogResult.OK) 
                {
                    Drivers newDriver = new Drivers
                    {
                        name = detailsForm.name,
                        surname = detailsForm.surname,
                        driversNumber = detailsForm.driversNumber,
                        team = detailsForm.team
                    };

                    driversList.Add(newDriver);

                    dataGridView1.DataSource = null; 
                    dataGridView1.DataSource = driversList; 
                }
            }
        }

        private void removeDriverButton_Click(object sender, EventArgs e)
        {
            using(Form3 removeForm = new Form3())
            {
                if (removeForm.ShowDialog() == DialogResult.OK)
                {
                    Drivers driverToRemove = driversList.FirstOrDefault(driver => driver.name == removeForm.name);
                    if (driverToRemove != null)
                    {
                        driversList.Remove(driverToRemove);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = driversList;
                    }
                    else
                    { 
                        MessageBox.Show("Driver not found."); 
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void teamOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in teamOrder.SelectedItems)
            {
                string teamName = item.ToString();
                showTeamImage(teamName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void showTeamImage(string teamName)
        {
            string imagePath = "";

            switch (teamName)
            {
                case "Mclaren":
                    imagePath = "mclaren.png";
                    break;
                case "Mercedes":
                    imagePath = "mercedes.png";
                    break;
                case "Red Bull Racing":
                    imagePath = "redbullracing.png"; 
                    break;
                case "Williams":
                    imagePath = "williams.png";
                    break;
                case "Aston Martin":
                    imagePath = "astonmartin.png"; 
                    break;
            }

            imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);

            if (System.IO.File.Exists(imagePath))
            {
                pictureBox1.Image = new Bitmap(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Image not found: " + imagePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
