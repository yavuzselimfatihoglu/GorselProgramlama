namespace Hafta2WindowsFormUygulama
{
    public partial class Form1 : Form
    {
        //global üye deðiþken
        int eskiGen;
        int eskiYuk;
        public Form1()
        {
            InitializeComponent();
        }

        private void gonderBTn_Click(object sender, EventArgs e)
        {
            sonucLbl.Text = girisTxt.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoþgeldiniz");
            eskiGen = this.Size.Width;
            eskiYuk = this.Size.Height;
            label1.Text = this.Size.Width.ToString();
            label2.Text = this.Size.Height.ToString();

        }

        private void girisTxt_MouseHover(object sender, EventArgs e)
        {
            //giristxt renk+font biçimle
            girisTxt.BackColor = Color.Turquoise;
            girisTxt.ForeColor = Color.Red;
            //girisTxt.Font.Bold= true;

        }

        private void girisTxt_MouseLeave(object sender, EventArgs e)
        {
            girisTxt.BackColor = Color.Yellow;
            girisTxt.ForeColor = Color.Blue;

        }

        private void girisTxt_Enter(object sender, EventArgs e)
        {
            girisTxt.BackColor = Color.Green;
            girisTxt.ForeColor = Color.Orange;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            DialogResult cvp;
            //F10 basýldýðýnda çýkýþ!!
            if (e.KeyCode == Keys.F10)
            {
                cvp = MessageBox.Show("Çýkýþ?", "Uyarý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cvp == DialogResult.Yes)
                {
                    // Form1.Close(); //form1 sýnýfýnýn kendisi 
                    this.Close();//this -> formun kendisini refere ediyor
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("form kapandý!!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Çýkmak istiyor musun?", "Uyarý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cvp == DialogResult.No)
            {
                e.Cancel = true;

            }


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label1.Text = this.Size.Width.ToString();
            label2.Text = this.Size.Height.ToString();
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            label1.Text = this.Size.Width.ToString();
            label2.Text = this.Size.Height.ToString();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //eski deðerlere dön
            this.Size = new System.Drawing.Size(eskiGen, eskiYuk);

        }
    }
}