using System.Windows.Forms;

namespace Hafta3__WindowsBilesenleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gönder butonu pasif olacak
            gonderBtn.Enabled = false;
            //form baþlýðýný ayarla
            this.Text = "Windows bileþenleri..." + DateTime.Now.ToLongDateString();

        }

        private void girisTxt_TextChanged(object sender, EventArgs e)
        {
            if (girisTxt.Text != "")
            {
                gonderBtn.Enabled = true;
            }
            else
            {
                gonderBtn.Enabled = false;
            }
        }

        private void gonderBtn_Click(object sender, EventArgs e)
        {
            //giriþText bilgi -> combobox'a
            listeCmb.Items.Add(girisTxt.Text);
            listeLst.Items.Add(girisTxt.Text);
            sayacLbl.Text = listeCmb.Items.Count.ToString();
            if (listeCmb.Items.Count > 5)
            {
                indikator.BackColor = Color.Red;
            }
            //txt temizle
            girisTxt.Text = "";

        }

        private void gizlegosterChk_CheckedChanged(object sender, EventArgs e)
        {
            if (gizlegosterChk.Checked == true)
            {
                gonderBtn.Visible = true;
            }
            else
            {
                gonderBtn.Visible = false;
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            int silinecek = -1;
            //combobox'ta seçili item'ý siler
            if (listeCmb.SelectedIndex < 0)
            {
                MessageBox.Show("listeden deðer seçiniz..");
            }
            else
            {
                silinecek = listeCmb.SelectedIndex;
                listeCmb.Items.Remove(listeCmb.SelectedItem);
                listeLst.Items.RemoveAt(silinecek);
                if (listeCmb.Items.Count <= 5)
                {
                    indikator.BackColor = Color.Green;
                }

                if (listeCmb.Items.Count == 0)
                    sayacLbl.Text = "Boþ";
                else
                    sayacLbl.Text = listeCmb.Items.Count.ToString();
                listeCmb.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                this.BackColor = Color.LightBlue;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.BackColor = Color.LightGreen;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\Windows\\resim.png");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(monthCalendar1.TodayDate.ToString());
        }
    }
}