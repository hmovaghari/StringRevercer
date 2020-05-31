using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Revercer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string[] str = textBox1.Text.Split(' ');
                textBox1.Text = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    textBox1.Text = (textBox1.Text + str[i] + " ");
                }
                textBox1.Text = textBox1.Text.Trim();
            }
        }
    }
}
