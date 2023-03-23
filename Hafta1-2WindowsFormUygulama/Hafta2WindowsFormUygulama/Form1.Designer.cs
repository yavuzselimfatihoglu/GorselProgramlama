namespace Hafta2WindowsFormUygulama
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
            gonderBTn = new Button();
            girisTxt = new TextBox();
            sonucLbl = new Label();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // gonderBTn
            // 
            gonderBTn.Location = new Point(167, 189);
            gonderBTn.Name = "gonderBTn";
            gonderBTn.Size = new Size(75, 23);
            gonderBTn.TabIndex = 0;
            gonderBTn.Text = "Gönder";
            gonderBTn.UseVisualStyleBackColor = true;
            gonderBTn.Click += gonderBTn_Click;
            // 
            // girisTxt
            // 
            girisTxt.Location = new Point(167, 120);
            girisTxt.Name = "girisTxt";
            girisTxt.Size = new Size(75, 23);
            girisTxt.TabIndex = 1;
            girisTxt.Enter += girisTxt_Enter;
            girisTxt.MouseLeave += girisTxt_MouseLeave;
            girisTxt.MouseHover += girisTxt_MouseHover;
            // 
            // sonucLbl
            // 
            sonucLbl.AutoSize = true;
            sonucLbl.Location = new Point(162, 71);
            sonucLbl.Name = "sonucLbl";
            sonucLbl.Size = new Size(84, 15);
            sonucLbl.TabIndex = 2;
            sonucLbl.Text = "giriş yapılmadı";
            sonucLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(162, 258);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 3;
            button1.Text = "yeni form aç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(158, 312);
            button2.Name = "button2";
            button2.Size = new Size(92, 23);
            button2.TabIndex = 4;
            button2.Text = "Formu Gizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 30);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 394);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sonucLbl);
            Controls.Add(girisTxt);
            Controls.Add(gonderBTn);
            KeyPreview = true;
            Name = "Form1";
            Text = "İlk Uygulama";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResizeBegin += Form1_ResizeBegin;
            ResizeEnd += Form1_ResizeEnd;
            KeyDown += Form1_KeyDown;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button gonderBTn;
        private TextBox girisTxt;
        private Label sonucLbl;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}