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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form4 frm4=new Form4(); //Form3'ün child'ı olacak
            Form4 frm44=new Form4();
            frm44.MdiParent = this;
            frm4.MdiParent = this;
            frm4.Show();
            frm44.Show();
        }
    }
}
