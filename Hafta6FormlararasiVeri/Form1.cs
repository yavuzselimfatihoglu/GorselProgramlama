namespace Hafta6FormlararasiVeri
{
    public partial class Form1 : Form
    {
        public static string deger; //ortak deðiþken olacak
        Form2 frm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deger = textBox1.Text;
            frm2= new Form2();
            frm2.ShowDialog();
        }
    }
}