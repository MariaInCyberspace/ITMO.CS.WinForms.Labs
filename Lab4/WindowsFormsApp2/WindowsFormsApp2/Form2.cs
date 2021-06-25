using System;
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
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Interval interval = new Interval();
        public double FirstNumber
        {
            get { return Convert.ToDouble(textBox1.Text); }
            set { value = double.Parse(textBox1.Text); }
        }

        public double SecondNumber
        {
            get { return Convert.ToDouble(textBox2.Text); }
            set { value = double.Parse(textBox2.Text); }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1 = this.Owner as Form1;
            interval.FirstNumber = FirstNumber;
            interval.SecondNumber = SecondNumber;
            List<double> list = new List<double>();
            list = Range.DoubleRange(FirstNumber, SecondNumber).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (double d in list)
            {
                double ds = System.Math.Sin(d);
                sb.Append(d.ToString() + ": " + Math.Round(ds, 2) + "\n");
            }
            if (form1 != null)
            {
                form1.Data = sb.ToString();
                form1.Label = interval.ToString();
            }
            this.Close();
        }
    }
}
