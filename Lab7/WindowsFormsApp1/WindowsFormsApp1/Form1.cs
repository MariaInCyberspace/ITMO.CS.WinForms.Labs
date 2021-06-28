using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task<string> GoB()
        {
            return await Task.Run( () => {
                Thread.Sleep(5000);
                string s = GoButt();
                return s;
            });
        }
        public string GoButt()
        {
            int maxValue = 0;
            System.Text.StringBuilder resultText = new System.Text.StringBuilder();

            if (int.TryParse(textBox1.Text, out maxValue))
            {
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        resultText.AppendFormat("{0} ", trial);
                    }
                }
            }
            else
            {
                resultText.Append("Unable to parse maximum value.");
            }
            return resultText.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Numbers only");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while typecasting.");
                textBox1.Text = "";
                return;
            }
            string st = await GoB();
            richTextBox1.Text = st;
        }
    }
}
