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
    public partial class Form3 : Form
    {
       public static  Ogrenci ogr; //deklere edildi
        Akademikcs aka;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //frm4 = new Form4(); //Form3'ün child'ı olacak
            //frm4.MdiParent = this;
            //frm4.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Ogrenci formu açık mı?
            //Kapalı ise yeni form aç değilse uyarı mesajı
            if(ogr!=null)
            {
                MessageBox.Show("Ogrenci formu zaten açık");
            }
            else
            {
                ogr = new Ogrenci();
                //parent this(Form3) olacak
                ogr.MdiParent = this;
                ogr.Show();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            aka = new Akademikcs();
            aka.MdiParent = this;
            aka.Show();
        }
    }
}
