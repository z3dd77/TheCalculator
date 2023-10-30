using System.Data;

namespace TheCalculator
{
    public partial class Calculator : Form
    {
        // Declare private fields to store numbers, results, and operators
        private decimal firstNumber = 0.0m;
        private decimal secondNumber = 0.0m;
        private decimal Result = 0.0m;
        private string operators;

        // Constructor for the Calculator class
        public Calculator() 
        {
            InitializeComponent();
        }

        // Button Click Event Handlers for digits and decimal point
        // - Append digits to the Output text box
        // - Ensure 0 is not duplicated if it's the initial value
        private void button1_Click(object sender, EventArgs e)
        {
            // Similar logic applies to button2 to button10

            if (Output.Text == "0")
            {
                Output.Text = "0";
            }
            else
            {
                Output.Text += "0";
            }
        }

        // Event handler for the decimal point
        private void button17_Click(object sender, EventArgs e)
        {
            // Add a decimal point to the Output if not already present

            if (!Output.Text.Contains("."))
            {
                Output.Text += ".";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
            {
                Output.Text = "1";
            }
            else
            {
                Output.Text += "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
            {
                Output.Text = "2";
            }
            else
            {
                Output.Text += "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
            {
                Output.Text = "3";
            }
            else
            {
                Output.Text += "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
            {
                Output.Text = "4";
            }
            else
            {
                Output.Text += "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
            {
                Output.Text = "5";
            }
            else
            {
                Output.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
            {
                Output.Text = "6";
            }
            else
            {
                Output.Text += "6";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
            {
                Output.Text = "7";
            }
            else
            {
                Output.Text += "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
            {
                Output.Text = "8";
            }
            else
            {
                Output.Text += "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Output.Text == "0")
            {
                Output.Text = "9";
            }
            else
            {
                Output.Text += "9";
            }
        }

        // Equals Button Click Event Handler
        // - Perform the selected mathematical operation and display the result
        private void button11_Click(object sender, EventArgs e)
        {
            // Evaluate the selected operator and perform the calculation

            label1.Text = "=";
            switch (operators)
            {
                case "-":
                    secondNumber = decimal.Parse(Output.Text);
                    Result = firstNumber - secondNumber;
                    Output.Text = Result.ToString();
                    break;

                case "+":
                    secondNumber = decimal.Parse(Output.Text);
                    Result = firstNumber + secondNumber;
                    Output.Text = Result.ToString();
                    break;

                case "x":
                    secondNumber = decimal.Parse(Output.Text);
                    Result = firstNumber * secondNumber;
                    Output.Text = Result.ToString();
                    break;

                case "/":
                    secondNumber = decimal.Parse(Output.Text);
                    Result = firstNumber / secondNumber;
                    Output.Text = Result.ToString();
                    break;
            }
        }

        // Clear Button Click Event Handler
        // - Clear the Output and remove the operator label
        private void button12_Click(object sender, EventArgs e)
        {
            // Clear the Output and operator label

            Output.Clear();
            label1.Text = "";
        }

        // Event handlers for mathematical operations
        // - Store the first number, clear the Output, and set the operator label
        private void button13_Click(object sender, EventArgs e)
        {
            // Similar logic applies to button14, button15, and button16

            firstNumber = decimal.Parse(Output.Text);
            Output.Clear();
            label1.Text = "+";
            operators = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(Output.Text);
            Output.Clear();
            label1.Text = "-";
            operators = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(Output.Text);
            Output.Clear();
            label1.Text = "x";
            operators = "x";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(Output.Text);
            Output.Clear();
            label1.Text = "/";
            operators = "/";
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }

        // Event handler for changing the sign (negation) of the number
        private void button18_Click(object sender, EventArgs e)
        {
            // Toggle the sign of the number in the Output

            if (Output.Text.Contains("-"))
            {
                Output.Text = Output.Text.Trim('-');
            }
            else
            {
                Output.Text = "-" + Output.Text;
            }
        }
    }
}