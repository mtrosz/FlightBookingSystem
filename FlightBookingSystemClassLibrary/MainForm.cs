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
    public partial class MainForm : Form
    {
        ToolTip toolTip = new ToolTip();
        public MainForm()
        {
            InitializeComponent();
        }


        private void buttonHome_MouseLeave(object sender, EventArgs e)
        {
            this.buttonHome.BackColor = Color.Transparent;
        }

        private void buttonHome_MouseEnter(object sender, EventArgs e)
        {
            this.buttonHome.BackColor = Color.FromArgb(114, 73, 77);
        }

        private void buttonHome_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Home", this.buttonHome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Transparent;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.FromArgb(114, 73, 77);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Account", this.button3);
        }
    }
}
