using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta2WindowsFormUygulama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void ButonTikla(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "1": textBox1.Text += "1"; break;
                case "2": textBox1.Text += "2"; break;
                case "3": textBox1.Text += "3"; break;
                default:
                break;
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left  && (ModifierKeys & Keys.Control)==Keys.Control)
                    {
                this.BackColor = Color.FromArgb(new Random().Next(1, 255), new Random().Next(1, 255), new Random().Next(1, 255));

            }
        }
    }
}
