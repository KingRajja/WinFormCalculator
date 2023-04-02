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
            InterfaceRule();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (richTextBox1.Text != String.Empty)
                this.richTextBox2.Text = MakeSolution(this.richTextBox1.Text);
            else
                MessageBox.Show("TextBox1 is empty!");
        }

        public string MakeSolution(string line) {
            
            Stack<double> st = new Stack<double>();

            foreach(char arg in line) {
                double num;
                bool isNum = double.TryParse(arg.ToString(), out num);
                if (isNum)
                    st.Push(num);
                else {
                    double op2;
                    switch (arg) {
                    case '+':
                        st.Push(st.Pop() + st.Pop());
                        break;
                    case '*':
                        st.Push(st.Pop() * st.Pop());
                        break;
                    case '-':
                        op2 = st.Pop();
                        st.Push(st.Pop() - op2);
                        break;
                    case '/':
                        op2 = st.Pop();
                        if (op2 != 0.0)
                            st.Push(st.Pop() / op2);
                        else
                            return "Ошибка. Деление на ноль";
                        break;
                    default:
                        break;
                    }
                }
            }
            return st.Pop().ToString();
        }

        public void InterfaceRule() {
            this.richTextBox2.ReadOnly = true;
        }
    }

    
}
