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

        

        private void symbolBtnClick(object sender, EventArgs e) { this.infixFormula.Text += ((Button)sender).Text[0];  }

        public void InterfaceRule() {
            infixFormula.ReadOnly = true;
            postfixFormula.ReadOnly = true;
            solution.ReadOnly = true;

            foreach (Button btn in new List<Button>() {
                solutionBtn, dotBtn, zeroBtn, powBtn, threeBtn, twoBtn, oneBtn,
                minusBtn, sixBtn, fiveBtn, fourBtn, plusBtn, nineBtn, eightBtn, sevenBtn, multiBtn,
                divisionBtn, closeBracketBtn, openBracketBtn, percentBtn,sqrtBtn,
            }) {
                btn.Click += new EventHandler(symbolBtnClick);
            }
        }
    }

    
}
