using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userControlTimer1.Enabled)
            {
                userControlTimer1.Enabled = false;
                userControlTimer1.TimeEnabled = false;
                button1.Text = "Continue";
            }
            else
            {
                userControlTimer1.Enabled = true;
                userControlTimer1.TimeEnabled = true;
                button1.Text = "Stop";
            }
        }
    }
}
