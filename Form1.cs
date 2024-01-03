using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOrSomething
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void login_Click(object sender, EventArgs e)
        {
            if (Username.Text == "User" && Password.Text == "Admin1234")
            {
                MessageBox.Show("Login Success!");
                Main mainForm = new Main();
                mainForm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("No existing database found");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
