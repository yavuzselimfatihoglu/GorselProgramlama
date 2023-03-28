namespace Hafta5TimerFormlarArasiVeriDragDropMDIForm
{
    public partial class Form1 : Form
    {
        int indis;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;

            //form1'i gizle
            // this.Hide();
            //form2'yi g�ster
            Form2 frm2 = new Form2();
            //frm2.Show();
            frm2.ShowDialog();

            this.Text = "Uygulama";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //zaman� ba�l��a bas
            this.Text = "Uygulama -" + DateTime.Now.ToLongDateString() + "-" + DateTime.Now.ToLongTimeString();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //mouse ile t�klanan item s�r�kle-b�rak i�in belirlendi/se�ildi
            Point p = new Point(e.X, e.Y);
            indis = listBox1.IndexFromPoint(p);
            //DoDragDrop metot ile se�ili eleman s�r�klenmeye ba�layacak
            listBox1.DoDragDrop(listBox1.Items[indis], DragDropEffects.All);
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.All;
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.Text.ToString()));
            listBox1.Items.RemoveAt(indis);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3=new Form3();
            frm3.ShowDialog();
        }
    }
}