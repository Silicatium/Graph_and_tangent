using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab_PL_02
{
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private bool Drawed = false;

        private List<string> ToPolskiNotation(string exspression)
        {
            if (exspression.Count(c => c == '(') != exspression.Count(c => c == ')')) return null;
            exspression = exspression.Replace(" ", "");
            exspression = exspression.Replace("sin", "s");
            exspression = exspression.Replace("cos", "c");
            var priority = new Dictionary<char, int>()
            {
                {'(',  0},
                {'+', 1},
                {'-', 1},
                {'*', 2},
                {'/', 2},
                {'u', 3},
                {'c', 5},
                {'s', 5},
                {'^', 4}
            };
            var polskiExspression = new List<string>();
            var operatorsStack = new Stack<char>();
            string lastElem = " ";
            foreach (char elem in exspression)
            {
                if ("0123456789x".Contains(elem))
                {
                    if (",0123456789".Contains(lastElem) && elem != 'x') polskiExspression[polskiExspression.Count - 1] += elem;
                    else polskiExspression.Add(elem.ToString());
                }
                else if (elem == ',')
                {
                    if (lastElem == " " || polskiExspression[polskiExspression.Count - 1].Contains(elem)) return null;
                    else polskiExspression[polskiExspression.Count - 1] += elem;
                }
                else if ("+-*/^cs()u".Contains(elem))
                {
                    if (elem == '-' && (lastElem == "(" || lastElem == " ")) operatorsStack.Push('u');
                    else if (!operatorsStack.Any() && elem != '(') operatorsStack.Push(elem);
                    else if (elem == '(') operatorsStack.Push(elem);
                    else if (elem == ')' && operatorsStack.Contains('('))
                    {
                        while (operatorsStack.Peek() != '(')
                        {
                            polskiExspression.Add(Convert.ToString(operatorsStack.Pop()));
                        }
                        operatorsStack.Pop();
                    }
                    else if (priority[operatorsStack.Peek()] >= priority[elem])
                    {
                        int stackCount = operatorsStack.Count;
                        while (priority[operatorsStack.Peek()] >= priority[elem])
                        {
                            if (elem != '^')
                            {
                                if (priority[operatorsStack.Peek()] >= priority[elem])
                                    polskiExspression.Add(Convert.ToString(operatorsStack.Pop()));
                                else break;
                            }
                            else if (priority[operatorsStack.Peek()] > priority[elem])
                                polskiExspression.Add(Convert.ToString(operatorsStack.Pop()));
                            stackCount--;
                            if (stackCount == 0) break;
                        }
                        operatorsStack.Push(elem);
                    }
                    else if (priority[operatorsStack.Peek()] < priority[elem]) operatorsStack.Push(elem);
                    else return null;
                }
                else return null;
                lastElem = elem.ToString();
            }
            while (operatorsStack.Count != 0)
            {
                polskiExspression.Add(Convert.ToString(operatorsStack.Pop()));
            }
            if (polskiExspression.Count == 0) return null;
            else return polskiExspression;
        }

        private float ResPolskiNotation(List<string> expression)
        {
            var stack = new Stack<string>();
            foreach (string elem in expression)
            {
                if (float.TryParse(elem, out float res)) stack.Push(elem);
                else if ("+-*/^csul".Contains(elem))
                {
                    if (stack.Any() && "uscl".Contains(elem))
                    {
                        switch (elem)
                        {
                            case "u":
                                stack.Push(Convert.ToString(-1 * float.Parse(stack.Pop())));
                                break;
                            case "s":
                                stack.Push(Convert.ToString(Math.Sin(float.Parse(stack.Pop()))));
                                break;
                            case "c":
                                stack.Push(Convert.ToString(Math.Cos(float.Parse(stack.Pop()))));
                                break;
                            case "l":
                                stack.Push(Convert.ToString(Math.Log(float.Parse(stack.Pop()))));
                                break;
                        }
                    }
                    else if (stack.Count >= 2)
                    {
                        switch (elem)
                        {
                            case "+":
                                stack.Push(Convert.ToString(float.Parse(stack.Pop()) + float.Parse(stack.Pop())));
                                break;
                            case "-":
                                stack.Push(Convert.ToString(-1 * float.Parse(stack.Pop()) + float.Parse(stack.Pop())));
                                break;
                            case "*":
                                stack.Push(Convert.ToString(float.Parse(stack.Pop()) * float.Parse(stack.Pop())));
                                break;
                            case "/":
                                if (stack.Peek() != "0") stack.Push(Convert.ToString(1 / float.Parse(stack.Pop()) * float.Parse(stack.Pop())));
                                else
                                {
                                    stack.Pop();
                                    stack.Pop();
                                    stack.Push(Convert.ToString(double.NaN));
                                }
                                break;
                            case "^":
                                var degree = float.Parse(stack.Pop());
                                var basis = float.Parse(stack.Pop());
                                stack.Push(Convert.ToString(Math.Pow(basis, degree)));
                                break;
                        }
                    }
                    else throw new Exception($"Error! Operator '{elem}' is not applicable in current situation");
                }
                else throw new Exception($"Error! Operand '{elem}' is unknown");
            }
            if (stack.Count > 1) throw new Exception("Error! Count of operators is law");
            else if (stack.Any()) return float.Parse(stack.Pop());
            else return 0;
        }

        private List<string> HelpDerivate(List<string> list)
        {
            Stack<string> stack = new Stack<string>();
            foreach (var elem in list)
            {
                if (!"+-*/^csu".Contains(elem)) stack.Push(elem);
                else if ("+-*/^".Contains(elem))
                {
                    var second = stack.Pop();
                    var first = stack.Pop();
                    stack.Push($"{first} {second} {elem}");
                }
                else if ("csu".Contains(elem))
                {
                    var first = stack.Pop();
                    stack.Push($"{first} {elem}");
                }
            }
            return stack.ToList();
        }

        private string Derivate(string expression)
        {
            expression = expression.Replace("sin", "s");
            expression = expression.Replace("cos", "c");
            var derivate_operators_bin = new Dictionary<string, Func<string, string, string>>()
            {
                ["+"] = (first, second) => $"{Derivate(first)} {Derivate(second)} +",
                ["-"] = (first, second) => $"{Derivate(first)} {Derivate(second)} -",
                ["*"] = (first, second) => $"{Derivate(first)} {second} * {first} {Derivate(second)} * +",
                ["/"] = (first, second) => $"{Derivate(first)} {second} * {first} {Derivate(second)} * - {second} 2 ^ /",
                ["^"] = (first, second) => second.Contains('x') ? first.Contains('x') ?
                $"{first} {second} ^ {Derivate(second)} {first} l * {Derivate(first)} {second} {first} ^ * * +" :
                $"{first} {second} ^ {Derivate(second)} {first} l * {Derivate(first)} {second} {first} ^ * + *" :
                $"{second} {first} {second} 1 - ^ * {Derivate(first)} *",
            };
            var derivate_operators_un = new Dictionary<string, Func<string, string>>()
            {
                ["u"] = first => $"{Derivate(first)} u",
                ["s"] = first => $"{first} c {Derivate(first)} *",
                ["c"] = first => $"{first} s u {Derivate(first)} *"
            };
            List<string> expr = expression.Split(' ').ToList();
            var elem = expr.Last();
            if (float.TryParse(elem, out float res)) return "0";
            else if (elem == "x") return "1";
            else if ("+-*/^".Contains(elem))
            {
                var temp = expr;
                if (temp.Count > 0) temp.RemoveAt(temp.Count - 1);
                var elements = HelpDerivate(temp);
                var first = elements[1];
                var second = elements[0];
                return derivate_operators_bin[elem](first, second);
            }
            else /*("csu".Contains(elem))*/
            {
                var temp = expr;
                temp.RemoveAt(temp.Count - 1);
                var elements = HelpDerivate(temp);
                var first = elements[0];
                return derivate_operators_un[elem](first);
            }
        }

        private string ToReversePN(string str)
        {
            var exspression = str.Split(' ').ToList();
            var stack = new Stack<string>();
            foreach (var elem in exspression)
            {
                if (elem == "x" || float.TryParse(elem, out float res)) stack.Push(elem);
                else if ("+-*/^".Contains(elem))
                {
                    var second = stack.Pop();
                    var first = stack.Pop();
                    stack.Push($"({first} {elem} {second})");
                }
                else if ("csul".Contains(elem))
                {
                    var first = stack.Pop();
                    stack.Push($"{elem}({first})");
                }
                else throw new Exception("Error!");
            }
            return stack.Peek();
        }

        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            textBoxK.Clear();
            chartFunction.Series[0].Points.Clear();
            chartFunction.Series[1].Points.Clear();
            Drawed = false;

            List<string> polskiExspression = ToPolskiNotation(textBoxExspression.Text);
            if (polskiExspression is null)
            {
                textBoxRPN.Text = "Ошибка выражения!";
                textBoxDerivate.Text = "Ошибка выражения!";
            }
            else
            {
                string rpn = "";
                foreach (string elem in polskiExspression)
                {
                    rpn += elem + " ";
                }
                rpn = rpn.Trim();
                rpn = rpn.Replace("s", "sin");
                rpn = rpn.Replace("c", "cos");
                rpn = rpn.Replace("(", "");
                rpn = rpn.Replace(")", "");
                textBoxRPN.Text = rpn;
                try
                {
                    var temp = ToReversePN(Derivate(textBoxRPN.Text));
                    temp = temp.Replace("l", "ln");
                    temp = temp.Replace("s", "sin");
                    temp = temp.Replace("c", "cos");
                    temp = temp.Replace("u", "-");
                    textBoxDerivate.Text = temp;
                }
                catch
                {
                    textBoxDerivate.Text = "Ошибка!";
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRPN.Clear();
            textBoxExspression.Clear();
            textBoxDerivate.Clear();
            chartFunction.Series[0].Points.Clear();
            chartFunction.Series[1].Points.Clear();
            textBoxK.Clear();
            textBoxLeft.Clear();
            textBoxRight.Clear();
            Drawed = false;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (textBoxRPN.Text != "" && textBoxRPN.Text != "Ошибка выражения!" && float.TryParse(textBoxLeft.Text, out float A)
                && float.TryParse(textBoxRight.Text, out float B) && A < B)
            {
                chartFunction.Series[0].Points.Clear();
                chartFunction.Series[1].Points.Clear();
                var temp = textBoxRPN.Text;
                temp = temp.Replace("sin", "s");
                temp = temp.Replace("cos", "c");
                temp = temp.Replace("ln", "l");
                var RPN = temp.Split(' ').ToList();
                var RPNTemp = new List<string>(RPN);
                double h = (B - A)/400, x, y = int.MinValue, yprev = int.MinValue;
                chartFunction.Series[0].Points.Clear();
                x = A;
                while (x <= B)
                {
                    for (int i = 0; i < RPN.Count; i++)
                    {
                        if (RPN[i] == "x") RPNTemp[i] = x.ToString();
                    }
                    if (y != int.MinValue && !(y is double.NaN)) yprev = y;
                    try { y = ResPolskiNotation(RPNTemp); }
                    catch { break; }
                    if (!(y is double.NaN))
                    {
                        if ((Math.Sign(y) != Math.Sign(yprev)) && Math.Abs(Math.Abs(y) - Math.Abs(yprev)) > 100)
                            chartFunction.Series[0].Points.AddXY(x, double.NaN);
                        else chartFunction.Series[0].Points.AddXY(x, y);
                    }
                    else chartFunction.Series[0].Points.AddXY(x, y);
                    x += h;
                }
                Drawed = true;
            }
        }

        private void chartFunction_MouseDown(object sender, MouseEventArgs e)
        {
            if (Drawed)
            {
                chartFunction.Series[1].Points.Clear();
                float a = (float)Math.Round(chartFunction.ChartAreas[0].AxisX.PixelPositionToValue(e.X), 2);
                var temp = textBoxRPN.Text;
                temp = temp.Replace("sin", "s");
                temp = temp.Replace("cos", "c");
                temp = temp.Replace("x", a.ToString());
                var RPN = temp.Split(' ').ToList();
                float fa = ResPolskiNotation(RPN);

                if (!(fa is float.NaN))
                {
                    var Dtemp = Derivate(textBoxRPN.Text);
                    Dtemp = Dtemp.Replace("sin", "s");
                    Dtemp = Dtemp.Replace("cos", "c");
                    Dtemp = Dtemp.Replace("x", a.ToString());
                    var DRPN = Dtemp.Split(' ').ToList();
                    float fda = (float)Math.Round(ResPolskiNotation(DRPN), 2);

                    string zn;
                    if (fa > 0) zn = "";
                    else zn = "- ";
                    string zn1;
                    if (fda > 0) zn1 = " + ";
                    else zn1 = " - ";
                    string zn2;
                    if (a > 0) zn2 = "- ";
                    else zn2 = "+ ";
                    textBoxK.Text = zn + Convert.ToString(Math.Round(Math.Abs(fa), 2)) + zn1 + Convert.ToString(Math.Round(Math.Abs(fda), 2))
                        + " * (x " + zn2 + Convert.ToString(Math.Abs(a)) + ")";

                    var Ktemp = textBoxK.Text;
                    var KRPN = ToPolskiNotation(Ktemp);
                    var KRPNTemp = new List<string>(KRPN);
                    float h = 0.1f, x, y;
                    x = (float)chartFunction.ChartAreas[0].AxisX.Minimum;
                    while (x <= (float)chartFunction.ChartAreas[0].AxisX.Maximum)
                    {
                        for (int i = 0; i < KRPN.Count; i++)
                        {
                            if (KRPN[i] == "x") KRPNTemp[i] = x.ToString();
                        }
                        y = ResPolskiNotation(KRPNTemp);
                        if (y < chartFunction.ChartAreas[0].AxisY.Maximum && y > chartFunction.ChartAreas[0].AxisY.Minimum)
                            chartFunction.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
        }
    }
}
