namespace Hafta7NotepadUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baslik = "Bizim Notepad-";

        //yeniDosya()
        void yeniDosya()
        {
            richTextBox1.Text = "";
            richTextBox1.Visible = true;
        }  
        //dosyaKaydet()
        //saveFileDialog nesnesini projeye ekledik.
        void dosyaKaydet()
        {
            DialogResult cevap;
            saveFileDialog1.Filter = "Richtext(*.rtf)|*.rtf";
            cevap = saveFileDialog1.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                //dosya kay�t ediliyor..
                //MessageBox.Show(saveFileDialog1.FileName);
                //MessageBox.Show(Path.GetExtension(saveFileDialog1.FileName));

                richTextBox1.SaveFile(saveFileDialog1.FileName);

            }

        }

        //dosyaAc()
        void dosyaAc()
        {
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
                }
                catch (Exception e)
                {
                    MessageBox.Show("dosya format� do�ru de�il.." + e.Message);
                }

            }
        }

        //Bicimleme()
        //Kes , kopyala, yap��t�r

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = baslik;
            richTextBox1.Visible = false;
            richTextBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = baslik + DateTime.Now.ToLongTimeString();
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
    }
}