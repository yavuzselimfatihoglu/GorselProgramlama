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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
        int sayac = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label2.Text = sayac.ToString();
            if (sayac == 0)
            { timer1.Enabled = false;
                this.Close();
            }
            
        }
    }
}
