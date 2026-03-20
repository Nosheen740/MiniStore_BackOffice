using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refresh Button Clicked");

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(txt1.Text);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
