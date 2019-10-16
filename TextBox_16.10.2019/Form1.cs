using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_16._10._2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Enter M";
            label2.Text = "Km";
            button1.Text = "Convert";
            textBox2.Enabled = false;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float m = Convert.ToSingle(textBox1.Text);
            float km = m / 1000;
            textBox2.Text = km + "km";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (textBox1.Text.Length != 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (Char)Keys.Back)
            {
                return;
            }
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (!textBox1.Text.Contains(',') && textBox1.Text.Length != 0)
                {
                    e.KeyChar = '.';
                    return;
                }
            }
            e.Handled = true;

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == (char)Keys.Up)
                textBox1.SelectAll();
        }
    }
}
