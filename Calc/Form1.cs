using System;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        private string currentNumber = "0";
        private double firstNumber = 0;
        private double secondNumber = 0;
        private char operation = ' ';

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            button1.Click += OnButtonClick;
            button2.Click += OnButtonClick;
            button3.Click += OnButtonClick;
            button4.Click += OnButtonClick;
            button5.Click += OnButtonClick;
            button6.Click += OnButtonClick;
            button7.Click += OnButtonClick;
            button8.Click += OnButtonClick;
            button9.Click += OnButtonClick;
            button10.Click += OnButtonClick;
            buttonComa.Click += OnButtonClick;
            buttonC.Click += OnButtonClick;
            buttonDodaj.Click += OnButtonClick;
            buttonMinus.Click += OnButtonClick;
            buttonRazy.Click += OnButtonClick;
            buttonPodziel.Click += OnButtonClick;
            buttonSuma.Click += OnButtonClick;
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = button.Text;

            if (text == "C")
            {
                currentNumber = string.Empty;
                firstNumber = 0;
                secondNumber = 0;
                operation = ' ';
                textBox1.Text = "0"; 
            }
            else if (text == "=")
            {
                if (!string.IsNullOrEmpty(currentNumber))
                {
                    secondNumber = Convert.ToDouble(currentNumber);
                }
                double result = PerformOperation();
                textBox1.Text = result.ToString();
                currentNumber = string.Empty;
                firstNumber = result;
                operation = ' ';
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                if (!string.IsNullOrEmpty(currentNumber))
                {
                    firstNumber = Convert.ToDouble(currentNumber);
                    currentNumber = string.Empty; 
                }

                operation = text[0];

                textBox1.Text = firstNumber.ToString();
            }
            else if (text == "," || text == ".")
            {
                if (!currentNumber.Contains("."))
                {
                    currentNumber += ".";
                    textBox1.Text = currentNumber;
                }
            }
            else
            {
                if (currentNumber == "0" && text != ".")
                {
                    currentNumber = text;
                }
                else
                {
                    currentNumber += text;
                }
                textBox1.Text = currentNumber;
            }
        }


        private double PerformOperation()
        {
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        textBox1.Text = "Error";
                        currentNumber = string.Empty;
                        return 0;
                    }
                    break;
            }

            return result;
        }
    }
}