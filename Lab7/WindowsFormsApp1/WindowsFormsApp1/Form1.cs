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
        private delegate void TimeConsumingMethodDelegate(int sec);
        public delegate void SetProgressDelegate(int val);
        bool Cancel;
        public Form1()
        {
            InitializeComponent();
        }

        private void TimeConsumingMethod(int sec)
        {
            for (int i = 1; i <= sec; i++)
            {
                if (Cancel) break;
                System.Threading.Thread.Sleep(1000);
                SetProgress((int)(i * 100) / sec);
            }
            if (Cancel)
            {
                MessageBox.Show("Operation cancelled.");
            }
            else MessageBox.Show("Completed.");
        }

        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
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
            TimeConsumingMethodDelegate tdel = new TimeConsumingMethodDelegate(TimeConsumingMethod);
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
            tdel.BeginInvoke(int.Parse(textBox1.Text), null, null);

            string st = await GoB();
            richTextBox1.Text = st;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }
    }
}
