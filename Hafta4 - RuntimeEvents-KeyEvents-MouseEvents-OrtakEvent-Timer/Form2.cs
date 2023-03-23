using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta4___RuntimeEvents_KeyEvents_MouseEvents_OrtakEvent_Timer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            //mouse konumunu label'a ata
            label1.Text = e.X.ToString() + "-" + e.Y.ToString();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("sağ buton tıklandı");
            }

            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("sol buton tıklandı");
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                MessageBox.Show("tab basıldı");
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //Ctrl+Mouse Sağ buton ise icraatı yap
            Random r = new Random();
            if (e.Button == MouseButtons.Right && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.BackColor = Color.FromArgb(r.Next(1, 255), r.Next(1, 255), r.Next(1, 255));
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "1";
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "2";
        //}

        //ortak metot tanımı
        void tiklaBeni(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            switch ((sender as Button).Name)
            {
                case "btn1": textBox1.Text += "1"; break;
                case "btn2": textBox1.Text += "2"; break;
                case "btn3": textBox1.Text += "3"; break;

            }

            //if(sender.Equals(this.btn1))
            //textBox1.Text += "1";
        }
    }
}
