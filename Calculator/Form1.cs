using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (richTextBox1.Text != String.Empty)
                this.richTextBox2.Text = this.richTextBox1.Text;
            else
                MessageBox.Show("TextBox1 is empty!");
        }
    }
}
