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

        //Kontrol için gerekli metot
        //richtext içinde deðiþiklik olursa kontrol ile soru sorulacak 
        //Verilen cevaba göre iþlem yapýlacak
        void Kontrol()
        {
            DialogResult cvp;
            //richtext içinde deðiþiklik olursa: Modified =true
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

            if (dosyaKayitliMi == false)  //dosya daha önceden kayýtlý deðil ise Kaydet penceresi gelsin
            {
                cevap = saveFileDialog1.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    //dosya kayýt ediliyor..
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
                //dosya kayýtlý ise sadece richTextBox1.SaveFile(????????????) çalýþtýrýlsýn
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
                //dosya açýlýyor..
                try
                {
                    yeniDosya();
                    richTextBox1.LoadFile(openFileDialog1.FileName); //format uygun olmalý
                    dosyaAdiPathile = openFileDialog1.FileName; // dosya kayýtlý mý iþlemi için gerekli global deðiþken
                    dosyaAdi = Path.GetFileName(openFileDialog1.FileName); //bu title için kullanýlacak global deðiþken
                    dosyaKayitliMi = true;
                    richTextBox1.Modified= false;
                }
                catch (Exception e)
                {
                    MessageBox.Show("dosya formatý doðru deðil.." + e.Message);
                }

            }
        }

        //Bicimleme()
        //Kes , kopyala, yapýþtýr

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

        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            dosyaAc();
        }

        private void yazdýrToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}