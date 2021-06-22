using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.UserElement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string FirstName
        {
            get { return userControlValidating1.ReturnText(); }
        }
        private string LastName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private string FullName
        {
           get { return FirstName + " " + LastName; }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Text = FullName;
            }
            else 
            {
                textBox2.Text = "";
            }
        }

        private void userControlValidating1_Load(object sender, EventArgs e)
        {

        }
    }
}
