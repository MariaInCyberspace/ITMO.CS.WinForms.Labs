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
    public partial class Form1 : Form
    {
        public string SolData
        {
            get { return textBox1.Text;}
            set { textBox1.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void form1_button_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.Show(this);
        }
    }
}
