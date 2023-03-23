namespace Hafta3__WindowsBilesenleri
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
            girisTxt = new TextBox();
            listeCmb = new ComboBox();
            gonderBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sayacLbl = new Label();
            listeLst = new ListBox();
            indikator = new Button();
            gizlegosterChk = new CheckBox();
            silBtn = new Button();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // girisTxt
            // 
            girisTxt.Location = new Point(80, 92);
            girisTxt.Name = "girisTxt";
            girisTxt.Size = new Size(100, 23);
            girisTxt.TabIndex = 0;
            girisTxt.TextChanged += girisTxt_TextChanged;
            // 
            // listeCmb
            // 
            listeCmb.FormattingEnabled = true;
            listeCmb.Location = new Point(299, 94);
            listeCmb.Name = "listeCmb";
            listeCmb.Size = new Size(121, 23);
            listeCmb.TabIndex = 1;
            // 
            // gonderBtn
            // 
            gonderBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gonderBtn.Location = new Point(92, 142);
            gonderBtn.Name = "gonderBtn";
            gonderBtn.Size = new Size(75, 23);
            gonderBtn.TabIndex = 2;
            gonderBtn.Text = "Gönder";
            gonderBtn.UseVisualStyleBackColor = true;
            gonderBtn.Click += gonderBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(80, 63);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 3;
            label1.Text = "Değer Giriniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(299, 65);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 3;
            label2.Text = "Değer Listesi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(443, 63);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 3;
            label3.Text = "Eleman S.";
            // 
            // sayacLbl
            // 
            sayacLbl.AutoSize = true;
            sayacLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sayacLbl.Location = new Point(458, 96);
            sayacLbl.Name = "sayacLbl";
            sayacLbl.Size = new Size(37, 21);
            sayacLbl.TabIndex = 3;
            sayacLbl.Text = "Boş";
            // 
            // listeLst
            // 
            listeLst.FormattingEnabled = true;
            listeLst.ItemHeight = 15;
            listeLst.Location = new Point(286, 201);
            listeLst.Name = "listeLst";
            listeLst.Size = new Size(120, 109);
            listeLst.TabIndex = 4;
            // 
            // indikator
            // 
            indikator.BackColor = Color.Green;
            indikator.FlatAppearance.BorderSize = 0;
            indikator.FlatStyle = FlatStyle.Flat;
            indikator.Location = new Point(532, 95);
            indikator.Name = "indikator";
            indikator.Size = new Size(45, 26);
            indikator.TabIndex = 5;
            indikator.UseVisualStyleBackColor = false;
            // 
            // gizlegosterChk
            // 
            gizlegosterChk.AutoSize = true;
            gizlegosterChk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gizlegosterChk.Location = new Point(87, 200);
            gizlegosterChk.Name = "gizlegosterChk";
            gizlegosterChk.Size = new Size(93, 19);
            gizlegosterChk.TabIndex = 6;
            gizlegosterChk.Text = "gizle/göster";
            gizlegosterChk.UseVisualStyleBackColor = true;
            gizlegosterChk.CheckedChanged += gizlegosterChk_CheckedChanged;
            // 
            // silBtn
            // 
            silBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            silBtn.Location = new Point(320, 142);
            silBtn.Name = "silBtn";
            silBtn.Size = new Size(75, 23);
            silBtn.TabIndex = 7;
            silBtn.Text = "Sil";
            silBtn.UseVisualStyleBackColor = true;
            silBtn.Click += silBtn_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(148, 265);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(61, 19);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "Mezun";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(148, 291);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(91, 19);
            radioButton4.TabIndex = 11;
            radioButton4.TabStop = true;
            radioButton4.Text = "Mezun Değil";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(25, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mavi Tema";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(25, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Yeşil Tema";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(9, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 87);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tema Seç";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(472, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 71);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(485, 250);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Yükle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(636, 222);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(618, 36);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 16;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 351);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(silBtn);
            Controls.Add(gizlegosterChk);
            Controls.Add(indikator);
            Controls.Add(listeLst);
            Controls.Add(sayacLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gonderBtn);
            Controls.Add(listeCmb);
            Controls.Add(girisTxt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox girisTxt;
        private ComboBox listeCmb;
        private Button gonderBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label sayacLbl;
        private ListBox listeLst;
        private Button indikator;
        private CheckBox gizlegosterChk;
        private Button silBtn;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
    }
}