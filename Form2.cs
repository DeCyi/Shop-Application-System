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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void picture1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Item1_Buy(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you wanna buy this item1?");
        }

        private void Item2_Buy(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you wanna buy this item2?");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Testing(object sender, EventArgs e)
        {
           
        }

        private void Itemlist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Success!");
            Form3 mainForm = new Form3();
            mainForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
