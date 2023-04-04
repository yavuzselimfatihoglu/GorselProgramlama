using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta5TimerFormlarArasiVeriDragDropMDIForm
{
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }

        private void Ogrenci_FormClosed(object sender, FormClosedEventArgs e)
        {

            Form3.ogr = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //akademik label1'e ogrenci formundaki textbox
            // akademik.label1=ogrenci.textbox
            Akademikcs a1 = new Akademikcs();
            a1.label1.Text = textBox1.Text;      
            a1.Show();
        }
    }
}
