using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    public static class PolishSolution {
        private static Stack<double> st = new Stack<double>();

        public static string make(string line) {
            string returnValue = "";
            foreach (char arg in line) {
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
                        else {
                            st.Clear();
                            return "Ошибка. Деление на ноль";
                        }
                        break;
                    default:
                        break;
                    }
                }
            }
            returnValue = st.Pop().ToString();
            st.Clear();
            return returnValue;
        }
    }

    
}
