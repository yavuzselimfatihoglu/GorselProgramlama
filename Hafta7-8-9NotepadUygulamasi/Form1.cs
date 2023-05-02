namespace Hafta7NotepadUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baslik = "Bizim Notepad";
        string dosyaAdi;
        string dosyaAdiPathile;
        bool dosyaKayitliMi = false;

        //Kontrol i�in gerekli metot
        //richtext i�inde de�i�iklik olursa kontrol ile soru sorulacak 
        //Verilen cevaba g�re i�lem yap�lacak
        void Kontrol()
        {
            DialogResult cvp;
            //richtext i�inde de�i�iklik olursa: Modified =true
            if (richTextBox1.Modified == true)
            {

                //Kaydetmek istiyor musun?
                cvp = MessageBox.Show("Kaydetmek istiyor musun?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (cvp == DialogResult.Yes)
                {
                    dosyaKaydet();
                }
            }
        }

        //yeniDosya()
        void yeniDosya()
        {
            //Kontrol();
            richTextBox1.Text = "";
            richTextBox1.Visible = true;
            dosyaAdi = "Yeni Dosya";
            dosyaKayitliMi = false;
        }
        //dosyaKaydet()
        //saveFileDialog nesnesini projeye ekledik.
        void dosyaKaydet()
        {
            DialogResult cevap;
            saveFileDialog1.Filter = "Richtext(*.rtf)|*.rtf";

            if (dosyaKayitliMi == false)  //dosya daha �nceden kay�tl� de�il ise Kaydet penceresi gelsin
            {
                cevap = saveFileDialog1.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    //dosya kay�t ediliyor..
                    //MessageBox.Show(saveFileDialog1.FileName);
                    //MessageBox.Show(Path.GetExtension(saveFileDialog1.FileName));
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    dosyaAdi = Path.GetFileName(saveFileDialog1.FileName);
                    dosyaAdiPathile = saveFileDialog1.FileName;
                    richTextBox1.Modified = false;
                    dosyaKayitliMi = true;
                }
            }
            else
            {
                //dosya kay�tl� ise sadece richTextBox1.SaveFile(????????????) �al��t�r�ls�n
                richTextBox1.SaveFile(dosyaAdiPathile);
                richTextBox1.Modified = false;
                dosyaAdi = Path.GetFileName(dosyaAdiPathile);
            }

        }

        //dosyaAc()
        void dosyaAc()
        {
            Kontrol();
            DialogResult cevap;
            openFileDialog1.Filter = "Richtext(*.rtf)|*.rtf";
            openFileDialog1.FileName = "";
            cevap = openFileDialog1.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                //dosya a��l�yor..
                try
                {
                    yeniDosya();
                    richTextBox1.LoadFile(openFileDialog1.FileName); //format uygun olmal�
                    dosyaAdiPathile = openFileDialog1.FileName; // dosya kay�tl� m� i�lemi i�in gerekli global de�i�ken
                    dosyaAdi = Path.GetFileName(openFileDialog1.FileName); //bu title i�in kullan�lacak global de�i�ken
                    dosyaKayitliMi = true;
                    richTextBox1.Modified = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show("dosya format� do�ru de�il.." + e.Message);
                }

            }
        }

        //Bicimleme()
        void Bicimle()
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = fontDialog1.Color;
        }

        //Kes , kopyala, yap��t�r
        void Kes()
        {

            richTextBox1.Cut();
        }

        void Kopyala()
        {
            // if (richTextBox1.SelectionLength > 0)
            // {
            richTextBox1.Copy();
            // }
            // else
            //     MessageBox.Show("kopyalamak i�in se�im yap�n�z!!!");
        }

        void Yapistir()
        {
            richTextBox1.Paste();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = baslik;
            richTextBox1.Visible = false;
            richTextBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = baslik + "-" + dosyaAdi + "-" + DateTime.Now.ToLongTimeString();
        }

        private void yeniDosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniDosya();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            yeniDosya();
        }

        private void ��k��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaKaydet();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            dosyaKaydet();
        }

        private void dosyaA�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            dosyaAc();
        }

        private void yazd�rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            printDialog1.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Kontrol();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Kontrol();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kes();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            Kes();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kopyala();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            Kopyala();
        }

        private void yap��t�rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yapistir();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            Yapistir();
        }

        private void bi�imToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bicimle();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Bicimle();
        }

        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kes();
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kopyala();
        }

        private void yap��t�rToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Yapistir();
        }

        private void bi�imleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bicimle();
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTextBox1.Text = "X:" + e.X.ToString() + "-Y:" + e.Y.ToString();
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(richTextBox1, new Point(e.X, e.Y));
            }
        }
    }
}