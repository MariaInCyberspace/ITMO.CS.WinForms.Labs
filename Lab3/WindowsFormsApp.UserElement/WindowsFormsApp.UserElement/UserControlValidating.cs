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
    public partial class UserControlValidating : UserControl
    {
        public UserControlValidating()
        {
            InitializeComponent();
        }
        private string FirstName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string ReturnText()
        {
            return FirstName;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                char[] c = textBox1.Text.ToCharArray();
                foreach (char ch in c)
                {
                    if (char.IsDigit(ch))
                    {
                        e.Cancel = false;
                        MessageBox.Show("Can't have any numbers in here.");
                        textBox1.Text = textBox1.Text.Trim(ch);
                    }
                }
            }
        }
    }
}
