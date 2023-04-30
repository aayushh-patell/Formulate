namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            viewField = new TextBox();
            input7 = new Button();
            input8 = new Button();
            input9 = new Button();
            input4 = new Button();
            input5 = new Button();
            input6 = new Button();
            input1 = new Button();
            input2 = new Button();
            input3 = new Button();
            input0 = new Button();
            inputDot = new Button();
            inputDivision = new Button();
            inputMultiplication = new Button();
            inputSubtraction = new Button();
            inputAddition = new Button();
            inputEquals = new Button();
            inputConvertToDecimal = new Button();
            inputConvertToBinary = new Button();
            inputConvertToLocationalNumeral = new Button();
            inputClear = new Button();
            SuspendLayout();
            // 
            // viewField
            // 
            viewField.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            viewField.Location = new Point(27, 23);
            viewField.Margin = new Padding(2, 1, 2, 1);
            viewField.MinimumSize = new Size(4, 26);
            viewField.Multiline = true;
            viewField.Name = "viewField";
            viewField.ScrollBars = ScrollBars.Vertical;
            viewField.Size = new Size(158, 44);
            viewField.TabIndex = 0;
            viewField.TextChanged += textBox1_TextChanged;
            viewField.KeyPress += viewField_KeyPress;
            // 
            // input7
            // 
            input7.Location = new Point(27, 70);
            input7.Margin = new Padding(2, 1, 2, 1);
            input7.Name = "input7";
            input7.Size = new Size(48, 42);
            input7.TabIndex = 1;
            input7.Text = "7";
            input7.UseVisualStyleBackColor = true;
            input7.Click += input7_Click;
            // 
            // input8
            // 
            input8.Location = new Point(81, 70);
            input8.Margin = new Padding(2, 1, 2, 1);
            input8.Name = "input8";
            input8.Size = new Size(48, 42);
            input8.TabIndex = 2;
            input8.Text = "8";
            input8.UseVisualStyleBackColor = true;
            input8.Click += input8_Click;
            // 
            // input9
            // 
            input9.Location = new Point(135, 70);
            input9.Margin = new Padding(2, 1, 2, 1);
            input9.Name = "input9";
            input9.Size = new Size(48, 42);
            input9.TabIndex = 3;
            input9.Text = "9";
            input9.UseVisualStyleBackColor = true;
            input9.Click += input9_Click;
            // 
            // input4
            // 
            input4.Location = new Point(27, 117);
            input4.Margin = new Padding(2, 1, 2, 1);
            input4.Name = "input4";
            input4.Size = new Size(48, 42);
            input4.TabIndex = 4;
            input4.Text = "4";
            input4.UseVisualStyleBackColor = true;
            input4.Click += input4_Click;
            // 
            // input5
            // 
            input5.Location = new Point(81, 117);
            input5.Margin = new Padding(2, 1, 2, 1);
            input5.Name = "input5";
            input5.Size = new Size(48, 42);
            input5.TabIndex = 5;
            input5.Text = "5";
            input5.UseVisualStyleBackColor = true;
            input5.Click += input5_Click;
            // 
            // input6
            // 
            input6.Location = new Point(135, 117);
            input6.Margin = new Padding(2, 1, 2, 1);
            input6.Name = "input6";
            input6.Size = new Size(48, 42);
            input6.TabIndex = 6;
            input6.Text = "6";
            input6.UseVisualStyleBackColor = true;
            input6.Click += input6_Click;
            // 
            // input1
            // 
            input1.Location = new Point(27, 164);
            input1.Margin = new Padding(2, 1, 2, 1);
            input1.Name = "input1";
            input1.Size = new Size(48, 42);
            input1.TabIndex = 7;
            input1.Text = "1";
            input1.UseVisualStyleBackColor = true;
            input1.Click += input1_Click;
            // 
            // input2
            // 
            input2.Location = new Point(81, 164);
            input2.Margin = new Padding(2, 1, 2, 1);
            input2.Name = "input2";
            input2.Size = new Size(48, 42);
            input2.TabIndex = 8;
            input2.Text = "2";
            input2.UseVisualStyleBackColor = true;
            input2.Click += input2_Click;
            // 
            // input3
            // 
            input3.Location = new Point(135, 164);
            input3.Margin = new Padding(2, 1, 2, 1);
            input3.Name = "input3";
            input3.Size = new Size(48, 42);
            input3.TabIndex = 9;
            input3.Text = "3";
            input3.UseVisualStyleBackColor = true;
            input3.Click += input3_Click;
            // 
            // input0
            // 
            input0.Location = new Point(27, 211);
            input0.Margin = new Padding(2, 1, 2, 1);
            input0.Name = "input0";
            input0.Size = new Size(102, 42);
            input0.TabIndex = 10;
            input0.Text = "0";
            input0.UseVisualStyleBackColor = true;
            input0.Click += input0_Click;
            // 
            // inputDot
            // 
            inputDot.Location = new Point(135, 211);
            inputDot.Margin = new Padding(2, 1, 2, 1);
            inputDot.Name = "inputDot";
            inputDot.Size = new Size(48, 42);
            inputDot.TabIndex = 12;
            inputDot.Text = ".";
            inputDot.UseVisualStyleBackColor = true;
            inputDot.Click += inputDot_Click;
            // 
            // inputDivision
            // 
            inputDivision.Location = new Point(188, 23);
            inputDivision.Margin = new Padding(2, 1, 2, 1);
            inputDivision.Name = "inputDivision";
            inputDivision.Size = new Size(48, 42);
            inputDivision.TabIndex = 13;
            inputDivision.Text = "/";
            inputDivision.UseVisualStyleBackColor = true;
            inputDivision.Click += inputDivision_Click;
            // 
            // inputMultiplication
            // 
            inputMultiplication.Location = new Point(188, 70);
            inputMultiplication.Margin = new Padding(2, 1, 2, 1);
            inputMultiplication.Name = "inputMultiplication";
            inputMultiplication.Size = new Size(48, 42);
            inputMultiplication.TabIndex = 14;
            inputMultiplication.Text = "*";
            inputMultiplication.UseVisualStyleBackColor = true;
            inputMultiplication.Click += inputMultiplication_Click;
            // 
            // inputSubtraction
            // 
            inputSubtraction.Location = new Point(188, 117);
            inputSubtraction.Margin = new Padding(2, 1, 2, 1);
            inputSubtraction.Name = "inputSubtraction";
            inputSubtraction.Size = new Size(48, 42);
            inputSubtraction.TabIndex = 15;
            inputSubtraction.Text = "-";
            inputSubtraction.UseVisualStyleBackColor = true;
            inputSubtraction.Click += inputSubtraction_Click;
            // 
            // inputAddition
            // 
            inputAddition.Location = new Point(188, 164);
            inputAddition.Margin = new Padding(2, 1, 2, 1);
            inputAddition.Name = "inputAddition";
            inputAddition.Size = new Size(48, 42);
            inputAddition.TabIndex = 16;
            inputAddition.Text = "+";
            inputAddition.UseVisualStyleBackColor = true;
            inputAddition.Click += inputAddition_Click;
            // 
            // inputEquals
            // 
            inputEquals.Location = new Point(188, 211);
            inputEquals.Margin = new Padding(2, 1, 2, 1);
            inputEquals.Name = "inputEquals";
            inputEquals.Size = new Size(48, 42);
            inputEquals.TabIndex = 17;
            inputEquals.Text = "=";
            inputEquals.UseVisualStyleBackColor = true;
            inputEquals.Click += inputEquals_Click;
            // 
            // inputConvertToDecimal
            // 
            inputConvertToDecimal.Location = new Point(27, 258);
            inputConvertToDecimal.Margin = new Padding(2, 1, 2, 1);
            inputConvertToDecimal.Name = "inputConvertToDecimal";
            inputConvertToDecimal.Size = new Size(48, 42);
            inputConvertToDecimal.TabIndex = 18;
            inputConvertToDecimal.Text = "Dec";
            inputConvertToDecimal.UseVisualStyleBackColor = true;
            inputConvertToDecimal.Click += inputConvertToDecimal_Click;
            // 
            // inputConvertToBinary
            // 
            inputConvertToBinary.Location = new Point(81, 258);
            inputConvertToBinary.Margin = new Padding(2, 1, 2, 1);
            inputConvertToBinary.Name = "inputConvertToBinary";
            inputConvertToBinary.Size = new Size(48, 42);
            inputConvertToBinary.TabIndex = 19;
            inputConvertToBinary.Text = "Bin";
            inputConvertToBinary.UseVisualStyleBackColor = true;
            inputConvertToBinary.Click += inputConvertToBinary_Click;
            // 
            // inputConvertToLocationalNumeral
            // 
            inputConvertToLocationalNumeral.Location = new Point(135, 258);
            inputConvertToLocationalNumeral.Margin = new Padding(2, 1, 2, 1);
            inputConvertToLocationalNumeral.Name = "inputConvertToLocationalNumeral";
            inputConvertToLocationalNumeral.Size = new Size(48, 42);
            inputConvertToLocationalNumeral.TabIndex = 20;
            inputConvertToLocationalNumeral.Text = "Loc";
            inputConvertToLocationalNumeral.UseVisualStyleBackColor = true;
            inputConvertToLocationalNumeral.Click += inputConvertToLocationalNumeral_Click;
            // 
            // inputClear
            // 
            inputClear.Location = new Point(188, 258);
            inputClear.Margin = new Padding(2, 1, 2, 1);
            inputClear.Name = "inputClear";
            inputClear.Size = new Size(48, 42);
            inputClear.TabIndex = 21;
            inputClear.Text = "C";
            inputClear.UseVisualStyleBackColor = true;
            inputClear.Click += inputClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 323);
            Controls.Add(inputClear);
            Controls.Add(inputConvertToLocationalNumeral);
            Controls.Add(inputConvertToBinary);
            Controls.Add(inputConvertToDecimal);
            Controls.Add(inputEquals);
            Controls.Add(inputAddition);
            Controls.Add(inputSubtraction);
            Controls.Add(inputMultiplication);
            Controls.Add(inputDivision);
            Controls.Add(inputDot);
            Controls.Add(input0);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(input6);
            Controls.Add(input5);
            Controls.Add(input4);
            Controls.Add(input9);
            Controls.Add(input8);
            Controls.Add(input7);
            Controls.Add(viewField);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox viewField;
        private Button input7;
        private Button input8;
        private Button input9;
        private Button input4;
        private Button input5;
        private Button input6;
        private Button input1;
        private Button input2;
        private Button input3;
        private Button input0;
        private Button inputDot;
        private Button inputDivision;
        private Button inputMultiplication;
        private Button inputSubtraction;
        private Button inputAddition;
        private Button inputEquals;
        private Button inputConvertToDecimal;
        private Button inputConvertToBinary;
        private Button inputConvertToLocationalNumeral;
        private Button inputClear;
    }
}