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
    public partial class Exercitiu1: Form
    {
        public string readUsername;
        public string readPassword;
        public Exercitiu1()
        {
            InitializeComponent();
        }

        private void openForm_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("login_creditals.txt", true);
            streamWriter.WriteLine("DanOvidiu 1234");
            streamWriter.Close();

            StreamReader streamReader = new StreamReader(path: "login_creditals.txt");
            {
                string line = string.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] tempArray = line.Split(' ');
                    this.readUsername = tempArray[0];
                    this.readPassword = tempArray[1];
                }
            }
            Exercitiu1NewForm newForm = new Exercitiu1NewForm(readUsername);
            newForm.Show();
            label1.Text = readUsername;
        }
    }
}
