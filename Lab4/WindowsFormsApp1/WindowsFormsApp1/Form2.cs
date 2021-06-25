using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void form2_button_Click(object sender, EventArgs e)
        {
            string s = textBoxF2_1.Text + " " + textBoxF2_2.Text + " " + textBoxF2_3.Text;
            Form1 form1 = this.Owner as Form1;
            if (form1 != null)
            {
                form1.SolData = s;
            }

            this.Close();
        }
    }
}
