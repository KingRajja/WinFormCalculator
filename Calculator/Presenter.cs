using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    
    internal class Presenter {
        private List<string> log;
        private IViewer viewer;
        private Model model;

        public Presenter(IViewer viewer) {
            this.viewer = viewer;
            model = new Model();
        }

        public void popSymbolFromInfixFromula() {
            string infixFormulaText = viewer.getTextFromTextBox(TextBoxName.infix);
            if (infixFormulaText.Length > 0)
                viewer.setTextInToTextBox(TextBoxName.infix, infixFormulaText.Remove(infixFormulaText.Length - 1));
        }

        private void showLog() {
            viewer.setTextInToTextBox(TextBoxName.calcLog, String.Empty);
            foreach (string line in log) {
                viewer.setTextInToTextBox(TextBoxName.calcLog, $"{line}\n", true);
            }
            log.Clear();
        }

        public void addSymbolToInfixFormula(char symbol) { viewer.setTextInToTextBox(TextBoxName.infix, symbol.ToString(), true); }
        public void makeSolution() {
            model.infixExpr = viewer.getTextFromTextBox(TextBoxName.infix);
            model.converInfixToPostfix();

            viewer.setTextInToTextBox(TextBoxName.postfix, model.postfixExpr);
            viewer.setTextInToTextBox(TextBoxName.solution, model.Calc(out log).ToString());

            showLog();
        }
        public void clear() {
            viewer.setTextInToTextBox(TextBoxName.infix, String.Empty);
            viewer.setTextInToTextBox(TextBoxName.postfix, String.Empty);
            viewer.setTextInToTextBox(TextBoxName.solution, String.Empty);
            viewer.setTextInToTextBox(TextBoxName.calcLog, String.Empty);
        }
    }
}
