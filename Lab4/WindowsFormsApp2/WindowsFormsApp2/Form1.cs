﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show(this);
           
        }

        public string Data
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }

        public string Label
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
    }
}
