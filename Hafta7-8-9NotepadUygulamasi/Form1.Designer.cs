namespace Hafta7NotepadUygulamasi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStripContainer1 = new ToolStripContainer();
            toolStrip2 = new ToolStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            yeniDosyaToolStripMenuItem = new ToolStripMenuItem();
            dosyaAçToolStripMenuItem = new ToolStripMenuItem();
            kaydetToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            yazdırToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            düzenToolStripMenuItem = new ToolStripMenuItem();
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            biçimToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            cutToolStripButton = new ToolStripButton();
            copyToolStripButton = new ToolStripButton();
            pasteToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            printDialog1 = new PrintDialog();
            fontDialog1 = new FontDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            kesToolStripMenuItem1 = new ToolStripMenuItem();
            kopyalaToolStripMenuItem1 = new ToolStripMenuItem();
            yapıştırToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            biçimleToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(toolStrip2);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(richTextBox1);
            toolStripContainer1.ContentPanel.Size = new Size(800, 376);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1 });
            toolStrip2.Location = new Point(3, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(114, 25);
            toolStrip2.TabIndex = 0;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 22);
            toolStripProgressBar1.Value = 50;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 376);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.MouseDown += richTextBox1_MouseDown;
            richTextBox1.MouseMove += richTextBox1_MouseMove;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, düzenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniDosyaToolStripMenuItem, dosyaAçToolStripMenuItem, kaydetToolStripMenuItem, toolStripMenuItem1, yazdırToolStripMenuItem, toolStripMenuItem2, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(51, 20);
            dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // yeniDosyaToolStripMenuItem
            // 
            yeniDosyaToolStripMenuItem.Name = "yeniDosyaToolStripMenuItem";
            yeniDosyaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            yeniDosyaToolStripMenuItem.Size = new Size(172, 22);
            yeniDosyaToolStripMenuItem.Text = "Yeni Dosya";
            yeniDosyaToolStripMenuItem.Click += yeniDosyaToolStripMenuItem_Click;
            // 
            // dosyaAçToolStripMenuItem
            // 
            dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            dosyaAçToolStripMenuItem.Size = new Size(172, 22);
            dosyaAçToolStripMenuItem.Text = "Dosya Aç ";
            dosyaAçToolStripMenuItem.Click += dosyaAçToolStripMenuItem_Click;
            // 
            // kaydetToolStripMenuItem
            // 
            kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            kaydetToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            kaydetToolStripMenuItem.Size = new Size(172, 22);
            kaydetToolStripMenuItem.Text = "Kaydet";
            kaydetToolStripMenuItem.Click += kaydetToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(169, 6);
            // 
            // yazdırToolStripMenuItem
            // 
            yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            yazdırToolStripMenuItem.Size = new Size(172, 22);
            yazdırToolStripMenuItem.Text = "Yazdır";
            yazdırToolStripMenuItem.Click += yazdırToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(169, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            çıkışToolStripMenuItem.Size = new Size(172, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // düzenToolStripMenuItem
            // 
            düzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kesToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem, toolStripMenuItem3, biçimToolStripMenuItem });
            düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            düzenToolStripMenuItem.Size = new Size(52, 20);
            düzenToolStripMenuItem.Text = "Dü&zen";
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            kesToolStripMenuItem.Size = new Size(154, 22);
            kesToolStripMenuItem.Text = "&Kes";
            kesToolStripMenuItem.Click += kesToolStripMenuItem_Click;
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(154, 22);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            kopyalaToolStripMenuItem.Click += kopyalaToolStripMenuItem_Click;
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.Size = new Size(154, 22);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            yapıştırToolStripMenuItem.Click += yapıştırToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(151, 6);
            // 
            // biçimToolStripMenuItem
            // 
            biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            biçimToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            biçimToolStripMenuItem.Size = new Size(154, 22);
            biçimToolStripMenuItem.Text = "Biçimle";
            biçimToolStripMenuItem.Click += biçimToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, printToolStripButton, toolStripSeparator, cutToolStripButton, copyToolStripButton, pasteToolStripButton, toolStripSeparator1, helpToolStripButton, toolStripSeparator2, toolStripTextBox1 });
            toolStrip1.Location = new Point(3, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(316, 25);
            toolStrip1.TabIndex = 1;
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(23, 22);
            newToolStripButton.Text = "&New";
            newToolStripButton.ToolTipText = "Yeni Dosya";
            newToolStripButton.Click += newToolStripButton_Click;
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(23, 22);
            openToolStripButton.Text = "&Open";
            openToolStripButton.ToolTipText = "Dosya Aç";
            openToolStripButton.Click += openToolStripButton_Click;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 22);
            saveToolStripButton.Text = "&Save";
            saveToolStripButton.Click += saveToolStripButton_Click;
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Magenta;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(23, 22);
            printToolStripButton.Text = "&Print";
            printToolStripButton.Click += printToolStripButton_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = (Image)resources.GetObject("cutToolStripButton.Image");
            cutToolStripButton.ImageTransparentColor = Color.Magenta;
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Size = new Size(23, 22);
            cutToolStripButton.Text = "C&ut";
            cutToolStripButton.ToolTipText = "Kes";
            cutToolStripButton.Click += cutToolStripButton_Click;
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = (Image)resources.GetObject("copyToolStripButton.Image");
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(23, 22);
            copyToolStripButton.Text = "&Copy";
            copyToolStripButton.ToolTipText = "Kopyala";
            copyToolStripButton.Click += copyToolStripButton_Click;
            // 
            // pasteToolStripButton
            // 
            pasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton.Image = (Image)resources.GetObject("pasteToolStripButton.Image");
            pasteToolStripButton.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton.Name = "pasteToolStripButton";
            pasteToolStripButton.Size = new Size(23, 22);
            pasteToolStripButton.Text = "&Paste";
            pasteToolStripButton.ToolTipText = "Yapıştır";
            pasteToolStripButton.Click += pasteToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(23, 22);
            helpToolStripButton.Text = "Biçimle";
            helpToolStripButton.Click += helpToolStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { kesToolStripMenuItem1, kopyalaToolStripMenuItem1, yapıştırToolStripMenuItem1, toolStripMenuItem4, biçimleToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(117, 98);
            // 
            // kesToolStripMenuItem1
            // 
            kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            kesToolStripMenuItem1.Size = new Size(116, 22);
            kesToolStripMenuItem1.Text = "Kes";
            kesToolStripMenuItem1.Click += kesToolStripMenuItem1_Click;
            // 
            // kopyalaToolStripMenuItem1
            // 
            kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            kopyalaToolStripMenuItem1.Size = new Size(116, 22);
            kopyalaToolStripMenuItem1.Text = "Kopyala";
            kopyalaToolStripMenuItem1.Click += kopyalaToolStripMenuItem1_Click;
            // 
            // yapıştırToolStripMenuItem1
            // 
            yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            yapıştırToolStripMenuItem1.Size = new Size(116, 22);
            yapıştırToolStripMenuItem1.Text = "Yapıştır";
            yapıştırToolStripMenuItem1.Click += yapıştırToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(113, 6);
            // 
            // biçimleToolStripMenuItem
            // 
            biçimleToolStripMenuItem.Name = "biçimleToolStripMenuItem";
            biçimleToolStripMenuItem.Size = new Size(116, 22);
            biçimleToolStripMenuItem.Text = "Biçimle";
            biçimleToolStripMenuItem.Click += biçimleToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem yeniDosyaToolStripMenuItem;
        private ToolStripMenuItem dosyaAçToolStripMenuItem;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem yazdırToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem düzenToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem biçimToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton helpToolStripButton;
        private ToolStrip toolStrip2;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Timer timer1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private PrintDialog printDialog1;
        private FontDialog fontDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem kesToolStripMenuItem1;
        private ToolStripMenuItem kopyalaToolStripMenuItem1;
        private ToolStripMenuItem yapıştırToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem biçimleToolStripMenuItem;
    }
}