using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_CalculadoraSimple
{
    public partial class CalculadoraSimple16 : Form

    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool OperationPending = false;

        public CalculadoraSimple16()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox_Result.Text = currentInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox_Result.Text = currentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox_Result.Text = currentInput;
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            TxtBox_Result.Clear();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox_Result.Text = currentInput;
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox_Result.Text = currentInput;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox_Result.Text = currentInput;
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox_Result.Text = currentInput;
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox_Result.Text = currentInput;
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox_Result.Text = currentInput;
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox_Result.Text = currentInput;
        }

        private void Btn_div_Click(object sender, EventArgs e)
        {
            if (OperationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            OperationPending = true;
        }

        private void Btn_mult_Click(object sender, EventArgs e)
        {
            if (OperationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            OperationPending = true;
        }

        private void Btn_rest_Click(object sender, EventArgs e)
        {
            if (OperationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            OperationPending = true;
        }

        private void Btn_sum_Click(object sender, EventArgs e)
        {
            if (OperationPending)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            OperationPending = true;
        }

        private void Evaluate()
        {
            if (OperationPending)
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;

                    case "-":
                        result -= secondNumber;
                        break;

                    case "*":
                        result *= secondNumber;
                        break;

                    case "/":
                        if (secondNumber != 0)
                        {
                            result /= secondNumber;
                        }
                        else
                        {
                            TxtBox_Result.Text = "Error";
                            return;
                        }
                        break;
                }
                TxtBox_Result.Text = result.ToString();
                currentInput = "";
                OperationPending = false;
            }
        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            Evaluate();
        }
    }
}
