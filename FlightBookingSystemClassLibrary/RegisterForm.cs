using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingSystemClassLibrary
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented","Error");
        }

        private void ShowPassChecBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassChecBox.Checked)
            {
                PassBox1.UseSystemPasswordChar = false;
                PassBox2.UseSystemPasswordChar = false;
            }
            else
            {
                PassBox1.UseSystemPasswordChar = true;
                PassBox2.UseSystemPasswordChar = true;
            }
        }

        private void PassBox2_TextChanged(object sender, EventArgs e)
        {
            if (PassBox1.ToString() != PassBox2.ToString())
            {
                PassMatchLabel.Show();
            }
            else
            {
                PassMatchLabel.Hide();
            }

        }

        private void PassBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
