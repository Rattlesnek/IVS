using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MathLib;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string operand1Txt = "0";
        private double operand1 = 0;
        private string operand2Txt = "";
        private double operand2 = 0;
        private string operation = "";
        private double result = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add one digit to string.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNum_Click(object sender, RoutedEventArgs e)
        {
            string num = "";
            num += sender.ToString().Last();

            if (operation == "")
            {
                if (operand1Txt == "0") operand1Txt = num;
                else operand1Txt += num;
                Display.Text = operand1Txt;
            }
            else
            {
                if (operand2Txt == "0") operand2Txt = num;
                else operand2Txt += num;
                Display.Text = operand2Txt;
            }

        }

        /// <summary>
        /// Add Pí value to operand.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPi_Click(object sender, RoutedEventArgs e)
        {
            string num = "";
            num += sender.ToString().Substring(sender.ToString().IndexOf(":") + 2);

            if (operation == "")
            {
                if (operand1Txt == "0") operand1Txt = num;
                else operand1Txt += num;
                Display.Text = operand1Txt;
            }
            else
            {
                if (operand2Txt == "0") operand2Txt = num;
                else operand2Txt += num;
                Display.Text = operand2Txt;
            }
        }

        /// <summary>
        /// Add dot to create double.
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDot_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                operand1Txt += ".";
                Display.Text = operand1Txt;
            }
            else
            {
                operand2Txt += ".";
                Display.Text = operand2Txt;
            }

        }

        /// <summary>
        /// Save selected operation (+,-,/,*,^,^/).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOperation_Click(object sender, RoutedEventArgs e)
        {
            if (operand1Txt != "" && operand2Txt != "")
            {
                Compute();
                Clean();
                Display.Text = "";
                operand1Txt = result.ToString();
            }
            string num = "";
            num += sender.ToString().Substring(sender.ToString().IndexOf(":") + 2);
            
            operation = num;
            DisplayOp1Ope.Text = operand1Txt + operation;
        }


        /// <summary>
        /// Remove last character from actual operand.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                operand1Txt = (operand1Txt.Length < 1) ? "" : operand1Txt.Remove(operand1Txt.Length - 1);
                Display.Text = operand1Txt;
            }
            else
            {
                operand2Txt = (operand2Txt.Length < 1) ? "" : operand2Txt.Remove(operand2Txt.Length - 1);
                Display.Text = operand2Txt;
            }
        }

        /// <summary>
        /// Compute factorial of operand1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFact_Click(object sender, RoutedEventArgs e)
        {
            if (operand1Txt == "")
            {
                Clean();
                return;
            }
            if (operand1Txt != "" && operand2Txt != "")
            {
                Compute();
                Clean();
                Display.Text = "";
                operand1Txt = result.ToString();
            }
            bool isint = uint.TryParse(operand1Txt, out uint n);
            //Convert.ToUInt32(operand1Txt);
            if (!isint)
            {
                DisplayOp1Ope.Text = "Only whole possitive numbers can be used for Factorial";
                Clean();
                return;
            }
            else
            {
                result = MathOp.Factorial(n);
                Display.Text = result.ToString();
                string tmp = n + "!";
                Clean();
                DisplayOp1Ope.Text = tmp;
                operand1Txt = result.ToString();
            }
        }

        /// <summary>
        /// Compute sinus of operand1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSin_Click(object sender, RoutedEventArgs e)
        {
            if (operand1Txt != "" && operand2Txt != "")
            {
                Compute();
                Clean();
                Display.Text = "";
                operand1Txt = result.ToString();
            }
            if (operand1Txt == "")
            {
                Clean();
                return;
            }
            operand1 = Convert.ToDouble(operand1Txt);
            result = MathOp.Sinus(operand1);
            Display.Text = result.ToString();
            string tmp = "sin(" + operand1Txt + ")";
            Clean();
            DisplayOp1Ope.Text = tmp;
            operand1Txt = result.ToString();
        }


        /// <summary>
        /// Compute tangens of operand1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTan_Click(object sender, RoutedEventArgs e)
        {
            if (operand1Txt != "" && operand2Txt != "")
            {
                Compute();
                Clean();
                Display.Text = "";
                operand1Txt = result.ToString();
            }
            if (operand1Txt == "")
            {
                Clean();
                return;
            }
            operand1 = Convert.ToDouble(operand1Txt);
            result = MathOp.Tangens(operand1);
            Display.Text = result.ToString();
            string tmp = "tan(" + operand1Txt + ")";
            Clean();
            DisplayOp1Ope.Text = tmp;
            operand1Txt = result.ToString();
        }

        /// <summary>
        /// Compute result of selected operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            Compute();

            Clean();

            operand1Txt = result.ToString();
        }

        /// <summary>
        /// Function for compution of basic functions.
        /// </summary>
        private void Compute()
        {
            if (operand1Txt == "" || operand2Txt == "") return;
            //bool op1 = double.TryParse(operand1Txt, out double operand1);
            operand1 = Convert.ToDouble(operand1Txt);
            operand2 = Convert.ToDouble(operand2Txt);
            uint exp = Convert.ToUInt32(operand2Txt); //TODO upravit pro exp and root aby nepadalo p5i double

            switch (operation)
            {
                case "+":
                    result = MathOp.Add(operand1, operand2);
                    break;
                case "-":
                    result = MathOp.Subtract(operand1, operand2);
                    break;
                case "*":
                    result = MathOp.Multiply(operand1, operand2);
                    break;
                case "/":
                    result = MathOp.Divide(operand1, operand2);
                    break;
                case "^x":
                    result = MathOp.Exponentiate(operand1, exp);
                    break;
                case "^1/x":
                    result = MathOp.NthRoot(operand1, exp);
                    break;
                default:
                    Clean();
                    break;

            }
            Display.Text = result.ToString();

        }

        /// <summary>
        /// Function clears operands and operation.
        /// </summary>
        private void Clean()
        {
            operand1 = 0;
            operand2 = 0;
            operand1Txt = "";
            operand2Txt = "";
            operation = "";
            DisplayOp1Ope.Text = "";
        }

        /// <summary>
        /// Function clears whole calculator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCe_Click(object sender, RoutedEventArgs e)
        {
            Clean();
            Display.Text = "";
            operand1Txt = "0";
        }

       
    }
}
