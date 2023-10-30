﻿namespace TheCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            Output = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            btnClear = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Output
            // 
            Output.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Output.Location = new Point(12, 12);
            Output.Name = "Output";
            Output.Size = new Size(318, 43);
            Output.TabIndex = 0;
            Output.TextAlign = HorizontalAlignment.Right;
            Output.TextChanged += Output_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 357);
            button1.Name = "button1";
            button1.Size = new Size(75, 62);
            button1.TabIndex = 1;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 289);
            button2.Name = "button2";
            button2.Size = new Size(75, 62);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(93, 289);
            button3.Name = "button3";
            button3.Size = new Size(75, 62);
            button3.TabIndex = 3;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(174, 289);
            button4.Name = "button4";
            button4.Size = new Size(75, 62);
            button4.TabIndex = 4;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 221);
            button5.Name = "button5";
            button5.Size = new Size(75, 62);
            button5.TabIndex = 5;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(93, 221);
            button6.Name = "button6";
            button6.Size = new Size(75, 62);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(174, 221);
            button7.Name = "button7";
            button7.Size = new Size(75, 62);
            button7.TabIndex = 7;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 153);
            button8.Name = "button8";
            button8.Size = new Size(75, 62);
            button8.TabIndex = 8;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(93, 153);
            button9.Name = "button9";
            button9.Size = new Size(75, 62);
            button9.TabIndex = 9;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(174, 153);
            button10.Name = "button10";
            button10.Size = new Size(75, 62);
            button10.TabIndex = 10;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.YellowGreen;
            button11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.Black;
            button11.Location = new Point(172, 357);
            button11.Name = "button11";
            button11.Size = new Size(156, 62);
            button11.TabIndex = 11;
            button11.Text = "=";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Location = new Point(12, 85);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(156, 62);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ControlDarkDark;
            button13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(255, 85);
            button13.Name = "button13";
            button13.Size = new Size(75, 62);
            button13.TabIndex = 13;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ControlDarkDark;
            button14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(255, 153);
            button14.Name = "button14";
            button14.Size = new Size(75, 62);
            button14.TabIndex = 14;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.ControlDarkDark;
            button15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(255, 221);
            button15.Name = "button15";
            button15.Size = new Size(75, 62);
            button15.TabIndex = 15;
            button15.Text = "x";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.ControlDarkDark;
            button16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(255, 289);
            button16.Name = "button16";
            button16.Size = new Size(75, 62);
            button16.TabIndex = 16;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Location = new Point(93, 357);
            button17.Name = "button17";
            button17.Size = new Size(75, 62);
            button17.TabIndex = 17;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.BackColor = SystemColors.ControlDarkDark;
            button18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(174, 85);
            button18.Name = "button18";
            button18.Size = new Size(75, 62);
            button18.TabIndex = 18;
            button18.Text = "-/+";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 19;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(340, 442);
            Controls.Add(label1);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(btnClear);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Output);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator by Zee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Output;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button btnClear;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Label label1;
    }
}