using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Calculator
{
    public enum NumberFormat
    {
        Decimal,
        Binary,
        LocationalNumeral
    };

    public enum Operation
    {
        None,
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    public partial class Form1 : Form
    {
        public double? FirstSavedValue { get; set; }
        public double? SecondSavedValue { get; set; }
        public bool WasOperationJustConfirmed { get; set; }
        public bool ErrorMessageRevealed { get; set; }
        public NumberFormat NumberFormat { get; set; }
        public Operation Operation { get; set; }

        public Form1()
        {
            InitializeComponent();
            NumberFormat = NumberFormat.Decimal;

            WasOperationJustConfirmed = false;
            ErrorMessageRevealed = false;

            inputConvertToDecimal.BackColor = Color.LightGray;
            inputConvertToBinary.BackColor = Color.White;
            inputConvertToLocationalNumeral.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
        }

        // Disables certain keyboard inputs based on the number format of the calculator
        private void viewField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NumberFormat == NumberFormat.Decimal)
            {
                if (e.KeyChar == '+')
                {
                    Add();
                }
                else if (e.KeyChar == '-')
                {
                    Subtract();
                }
                else if (e.KeyChar == '*')
                {
                    Multiply();
                }
                else if (e.KeyChar == '/')
                {
                    Divide();
                }

                if (e.KeyChar == '\r' || e.KeyChar == '=')
                {
                    Equals();
                }

                if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d\.\+\-\*/]") && e.KeyChar != '\b' && e.KeyChar != '\r')
                {
                    e.Handled = true;
                }
            }
            else if (NumberFormat == NumberFormat.Binary)
            {
                if (!char.IsControl(e.KeyChar) && e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
        }

        private void input0_Click(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
            if (NumberFormat == NumberFormat.Decimal || NumberFormat == NumberFormat.Binary)
            {
                viewField.Text += "0";
            }
        }

        private void input1_Click(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
            if (NumberFormat == NumberFormat.Decimal || NumberFormat == NumberFormat.Binary)
            {
                viewField.Text += "1";
            }
        }

        private void input2_Click(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
            if (NumberFormat == NumberFormat.Decimal)
            {
                viewField.Text += "2";
            }
        }

        private void input3_Click(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
            if (NumberFormat == NumberFormat.Decimal)
            {
                viewField.Text += "3";
            }
        }

        private void input4_Click(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
            if (NumberFormat == NumberFormat.Decimal)
            {
                viewField.Text += "4";
            }
        }

        private void input5_Click(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
            if (NumberFormat == NumberFormat.Decimal)
            {
                viewField.Text += "5";
            }
        }

        private void input6_Click(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
            if (NumberFormat == NumberFormat.Decimal)
            {
                viewField.Text += "6";
            }
        }

        private void input7_Click(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
            if (NumberFormat == NumberFormat.Decimal)
            {
                viewField.Text += "7";
            }
        }

        private void input8_Click(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
            if (NumberFormat == NumberFormat.Decimal)
            {
                viewField.Text += "8";
            }
        }

        private void input9_Click(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
            if (NumberFormat == NumberFormat.Decimal)
            {
                viewField.Text += "9";
            }
        }

        private void inputDot_Click(object sender, EventArgs e)
        {
            ClearFieldIfNeeded();
            viewField.Text += ".";
        }

        private void inputClear_Click(object sender, EventArgs e)
        {
            FirstSavedValue = null;
            SecondSavedValue = null;
            Operation = Operation.None;

            viewField.Text = "";
        }

        private void inputEquals_Click(object sender, EventArgs e)
        {
            Equals();
        }

        private void inputAddition_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void inputSubtraction_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void inputMultiplication_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void inputDivision_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void inputConvertToBinary_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(viewField.Text) && viewField.Text != "ERROR" && NumberFormat == NumberFormat.Decimal && int.TryParse(viewField.Text, out int userInput))
            {
                viewField.Text = DecToBin(userInput);

                NumberFormat = NumberFormat.Binary;
                inputConvertToDecimal.BackColor = Color.White;
                inputConvertToBinary.BackColor = Color.LightGray;
                inputConvertToLocationalNumeral.BackColor = Color.White;
            }
            else if (!string.IsNullOrEmpty(viewField.Text) && viewField.Text != "ERROR" && NumberFormat == NumberFormat.LocationalNumeral)
            {
                viewField.Text = LocToBin(viewField.Text);

                NumberFormat = NumberFormat.Binary;
                inputConvertToDecimal.BackColor = Color.White;
                inputConvertToBinary.BackColor = Color.LightGray;
                inputConvertToLocationalNumeral.BackColor = Color.White;
            }
            else
            {
                ThrowError();
            }
        }

        private void inputConvertToDecimal_Click(object sender, EventArgs e)
        {
            if (NumberFormat == NumberFormat.Binary && !string.IsNullOrEmpty(viewField.Text) && viewField.Text != "ERROR")
            {
                FirstSavedValue = BinToDec(viewField.Text);
                viewField.Text = FirstSavedValue.ToString();

                NumberFormat = NumberFormat.Decimal;
                inputConvertToDecimal.BackColor = Color.LightGray;
                inputConvertToBinary.BackColor = Color.White;
                inputConvertToLocationalNumeral.BackColor = Color.White;
            }
            else if (NumberFormat == NumberFormat.LocationalNumeral && !string.IsNullOrEmpty(viewField.Text) && viewField.Text != "ERROR")
            {
                FirstSavedValue = LocToDec(viewField.Text);
                viewField.Text = FirstSavedValue.ToString();

                NumberFormat = NumberFormat.Decimal;
                inputConvertToDecimal.BackColor = Color.LightGray;
                inputConvertToBinary.BackColor = Color.White;
                inputConvertToLocationalNumeral.BackColor = Color.White;
            }
            else
            {
                ThrowError();
            }
        }

        private void inputConvertToLocationalNumeral_Click(object sender, EventArgs e)
        {
            if (NumberFormat == NumberFormat.Decimal && !string.IsNullOrEmpty(viewField.Text) && viewField.Text != "ERROR" && int.TryParse(viewField.Text, out int decimalNumber))
            {
                viewField.Text = DecToLoc(decimalNumber);

                NumberFormat = NumberFormat.LocationalNumeral;
                inputConvertToDecimal.BackColor = Color.White;
                inputConvertToBinary.BackColor = Color.White;
                inputConvertToLocationalNumeral.BackColor = Color.LightGray;
            }
            else if (NumberFormat == NumberFormat.Binary && !string.IsNullOrEmpty(viewField.Text) && viewField.Text != "ERROR")
            {
                viewField.Text = BinToLoc(viewField.Text);

                NumberFormat = NumberFormat.LocationalNumeral;
                inputConvertToDecimal.BackColor = Color.White;
                inputConvertToBinary.BackColor = Color.White;
                inputConvertToLocationalNumeral.BackColor = Color.LightGray;
            }
            else
            {
                ThrowError();
            }
        }

        private string DecToBin(int decNumber)
        {
            string binNumber = "";
            while (decNumber > 0)
            {
                int remainder = decNumber % 2;
                binNumber = remainder + binNumber;
                decNumber /= 2;
            }
            return binNumber;
        }

        private string DecToLoc(int decNumber)
        {
            string locNumber = "";
            while (decNumber > 0)
            {
                int remainder = (decNumber - 1) % 26;
                char digit = (char)(remainder + 'A');
                locNumber = digit + locNumber;
                decNumber = (decNumber - 1) / 26;
            }
            return locNumber;
        }

        private string BinToLoc(string binNumber)
        {
            int decNumber = BinToDec(binNumber);
            string locNumber = DecToLoc(decNumber);
            return locNumber;
        }

        private int BinToDec(string binNumber)
        {
            int decNumber = 0;
            int power = 1;
            for (int i = binNumber.Length - 1; i >= 0; i--)
            {
                if (binNumber[i] == '1')
                {
                    decNumber += power;
                }
                power *= 2;
            }
            return decNumber;
        }

        private int LocToDec(string locNumber)
        {
            int decNumber = 0;
            int power = 1;
            for (int i = locNumber.Length - 1; i >= 0; i--)
            {
                int digitValue = locNumber[i] - 'A' + 1;
                decNumber += digitValue * power;
                power *= 26;
            }
            return decNumber;
        }

        private string LocToBin(string locNumber)
        {
            int decNumber = LocToDec(locNumber);
            string binNumber = DecToBin(decNumber);
            return binNumber;
        }

        private void ClearFieldIfNeeded()
        {
            if (WasOperationJustConfirmed)
            {
                WasOperationJustConfirmed = false;
                viewField.Text = "";
            }

            if (ErrorMessageRevealed)
            {
                ErrorMessageRevealed = false;
                viewField.Text = "";
            }
        }

        private void Add()
        {
            if (viewField.Text != "" && Operation == Operation.None && viewField.Text != "ERROR")
            {
                FirstSavedValue = double.Parse(viewField.Text);
                Operation = Operation.Addition;
                viewField.Text = "+";
                WasOperationJustConfirmed = true;
            }
            // Accounts for an override of the stored operation
            else if (viewField.Text != "" && Operation != Operation.None && viewField.Text != "ERROR")
            {
                Operation = Operation.Addition;
                viewField.Text = "+";
                WasOperationJustConfirmed = true;
            }
            else
            {
                ThrowError();
            }
        }

        private void Subtract()
        {
            if (viewField.Text != "" && Operation == Operation.None && viewField.Text != "ERROR")
            {
                FirstSavedValue = double.Parse(viewField.Text);
                Operation = Operation.Subtraction;
                viewField.Text = "-";
                WasOperationJustConfirmed = true;
            }
            else if (viewField.Text != "" && Operation != Operation.None && viewField.Text != "ERROR")
            {
                Operation = Operation.Subtraction;
                viewField.Text = "-";
                WasOperationJustConfirmed = true;
            }
            else
            {
                ThrowError();
            }
        }

        private void Multiply()
        {
            if (viewField.Text != "" && Operation == Operation.None && viewField.Text != "ERROR")
            {
                FirstSavedValue = double.Parse(viewField.Text);
                Operation = Operation.Multiplication;
                viewField.Text = "*";
                WasOperationJustConfirmed = true;
            }
            else if (viewField.Text != "" && Operation != Operation.None && viewField.Text != "ERROR")
            {
                Operation = Operation.Multiplication;
                viewField.Text = "*";
                WasOperationJustConfirmed = true;
            }
            else
            {
                ThrowError();
            }
        }

        private void Divide()
        {
            if (viewField.Text != "" && Operation == Operation.None && viewField.Text != "ERROR")
            {
                FirstSavedValue = double.Parse(viewField.Text);
                Operation = Operation.Division;
                viewField.Text = "/";
                WasOperationJustConfirmed = true;
            }
            else if (viewField.Text != "" && Operation != Operation.None && viewField.Text != "ERROR")
            {
                Operation = Operation.Division;
                viewField.Text = "/";
                WasOperationJustConfirmed = true;
            }
            else
            {
                ThrowError();
            }
        }

        private void ThrowError()
        {
            viewField.Text = "ERROR";
            ErrorMessageRevealed = true;
        }

        private void Equals()
        {
            if (viewField.Text != "" && viewField.Text != "ERROR")
            {
                SecondSavedValue = double.Parse(viewField.Text);
            }

            // Performs selected operation using stored user input
            if (FirstSavedValue != null && SecondSavedValue != null && Operation != Operation.None)
            {
                if (Operation == Operation.Addition)
                {
                    FirstSavedValue = FirstSavedValue + SecondSavedValue;
                    viewField.Text = FirstSavedValue.ToString();
                }
                else if (Operation == Operation.Subtraction)
                {
                    FirstSavedValue = FirstSavedValue - SecondSavedValue;
                    viewField.Text = FirstSavedValue.ToString();
                }
                else if (Operation == Operation.Multiplication)
                {
                    FirstSavedValue = FirstSavedValue * SecondSavedValue;
                    viewField.Text = FirstSavedValue.ToString();
                }
                else
                {
                    FirstSavedValue = FirstSavedValue / SecondSavedValue;
                    viewField.Text = FirstSavedValue.ToString();
                }

                Operation = Operation.None;
                SecondSavedValue = null;
            }
            else
            {
                ThrowError();
            }
        }
    }
}