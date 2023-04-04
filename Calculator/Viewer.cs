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
    public enum TextBoxName {
        postfix,
        solution,
        infix,
        calcLog
    }
    public partial class Viewer : Form, IViewer
    {
        private Presenter presenter;
        public Viewer()
        {
            InitializeComponent();
            InterfaceRule();
        }

        

        private void symbolBtnClick(object sender, EventArgs e) { presenter.addSymbolToInfixFormula(((Button)sender).Text[0]);  }
        private void solutionBtn_Click(object sender, EventArgs e) {}
        private void clearBtn_Click(object sender, EventArgs e) { presenter.clear(); }
        private void deleteBtn_Click(object sender, EventArgs e) { presenter.popSymbolFromInfixFromula(); }
        private void exitBtn_Click(object sender, EventArgs e) { this.Close(); }

        private void ViewerKeyPress(object sender, KeyPressEventArgs e) {
            if(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', '+', '-', '*', '/', '%', ')', '(', '^' }.Contains(e.KeyChar)) {
                presenter.addSymbolToInfixFormula(e.KeyChar);
            }
        }
        private void ViewerKeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode.Equals(Keys.Enter)) { } 
            else if (e.KeyCode.Equals(Keys.Back) || e.KeyCode.Equals(Keys.Delete)) { }
        }

        private void InterfaceRule() {
            presenter = new Presenter(this);
            foreach (RichTextBox textBox in new RichTextBox[] { infixFormula, postfixFormula, solution, calcLog }) { textBox.ReadOnly = true; }
            tabs.KeyPress += new KeyPressEventHandler(ViewerKeyPress);
            tabs.KeyUp += new KeyEventHandler(ViewerKeyUp);

            foreach (Button btn in new List<Button>() {
                solutionBtn, dotBtn, zeroBtn, powBtn, threeBtn, twoBtn, oneBtn,
                minusBtn, sixBtn, fiveBtn, fourBtn, plusBtn, nineBtn, eightBtn, sevenBtn, multiBtn,
                divisionBtn, closeBracketBtn, openBracketBtn, percentBtn,sqrtBtn,
            }) {
                btn.Click += new EventHandler(symbolBtnClick);
            }
        }

        #region Реализация интерфейса IViewer
        public void setTextInToTextBox(TextBoxName textBox, string value, bool add = false) {
            switch (textBox) {
            case TextBoxName.postfix:
                if (add) postfixFormula.Text += value; else postfixFormula.Text = value;
                break;
            case TextBoxName.infix:
                if (add) infixFormula.Text += value; else infixFormula.Text = value;
                break;
            case TextBoxName.calcLog:
                if (add) calcLog.Text += value; else calcLog.Text = value;
                break;
            case TextBoxName.solution:
                if (add) solution.Text += value; else solution.Text = value;
                break;
            default:
                break;
            }
        }
        public string getTextFromTextBox(TextBoxName textBox) {
            switch (textBox) {
            case TextBoxName.postfix:
                return postfixFormula.Text;
            case TextBoxName.infix:
                return postfixFormula.Text;
            case TextBoxName.calcLog:
                return postfixFormula.Text;
            case TextBoxName.solution:
                return postfixFormula.Text;
            default:
                return String.Empty;
            }
        }
        #endregion

    }

    public interface IViewer {
        void setTextInToTextBox(TextBoxName textBox, string value, bool add = false);
        string getTextFromTextBox(TextBoxName textBox);
    }

    
}
