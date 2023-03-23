namespace Hafta4___RuntimeEvents_KeyEvents_MouseEvents_OrtakEvent_Timer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.MouseDown += button1_MouseDown;
            // 
            // btn1
            // 
            btn1.Location = new Point(261, 167);
            btn1.Name = "btn1";
            btn1.Size = new Size(42, 32);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += tiklaBeni;
            // 
            // btn2
            // 
            btn2.Location = new Point(309, 167);
            btn2.Name = "btn2";
            btn2.Size = new Size(42, 32);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += tiklaBeni;
            // 
            // btn3
            // 
            btn3.Location = new Point(357, 167);
            btn3.Name = "btn3";
            btn3.Size = new Size(42, 32);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += tiklaBeni;
            // 
            // button5
            // 
            button5.Location = new Point(405, 167);
            button5.Name = "button5";
            button5.Size = new Size(42, 32);
            button5.TabIndex = 2;
            button5.Text = "0";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(261, 205);
            button6.Name = "button6";
            button6.Size = new Size(42, 32);
            button6.TabIndex = 2;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(309, 205);
            button7.Name = "button7";
            button7.Size = new Size(42, 32);
            button7.TabIndex = 2;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(357, 205);
            button8.Name = "button8";
            button8.Size = new Size(42, 32);
            button8.TabIndex = 2;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(405, 205);
            button9.Name = "button9";
            button9.Size = new Size(42, 32);
            button9.TabIndex = 2;
            button9.Text = "*";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(261, 243);
            button10.Name = "button10";
            button10.Size = new Size(42, 32);
            button10.TabIndex = 2;
            button10.Text = "7";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(309, 243);
            button11.Name = "button11";
            button11.Size = new Size(42, 32);
            button11.TabIndex = 2;
            button11.Text = "8";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(357, 243);
            button12.Name = "button12";
            button12.Size = new Size(42, 32);
            button12.TabIndex = 2;
            button12.Text = "9";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(405, 243);
            button13.Name = "button13";
            button13.Size = new Size(42, 32);
            button13.TabIndex = 2;
            button13.Text = "=";
            button13.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button11);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button10);
            Controls.Add(btn3);
            Controls.Add(button6);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            KeyDown += Form2_KeyDown;
            MouseDown += Form2_MouseDown;
            MouseMove += Form2_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private TextBox textBox1;
    }
}