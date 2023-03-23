using System.Runtime.Intrinsics.X86;

namespace Hafta4___RuntimeEvents_KeyEvents_MouseEvents_OrtakEvent_Timer
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
            pnl = new Panel();
            btn = new Button();
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // pnl
            // 
            pnl.BackColor = Color.LightGreen;
            pnl.Controls.Add(btn);
            pnl.Dock = DockStyle.Fill;
            pnl.Location = new Point(0, 0);
            pnl.Name = "pnl";
            pnl.Size = new Size(718, 413);
            pnl.TabIndex = 0;
            // 
            // btn
            // 
            btn.Location = new Point(47, 38);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 0;
            btn.Text = "Gönder";
            btn.Click += tikla;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 413);
            Controls.Add(pnl);
            Name = "Form1";
            Text = "Event Uygulama";
            pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        //butonun Click görevi
        private void tikla(object sender, EventArgs e)
        {


            MessageBox.Show("Buton tıklandı");
        }

        #endregion
        Panel pnl; //deklerasyon...nesne tanımlanmamış..yer tahsisi yok
        Button btn;
    }
}