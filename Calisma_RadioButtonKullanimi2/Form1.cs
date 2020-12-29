using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma_RadioButtonKullanimi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (radioBtnİlk.Checked == true)    
            {
                label2.Text = "İLKÖĞRETİM";
            }
            else if (radioBtnOrta.Checked == true)
            {
                label2.Text = "ORTAÖĞRETİM";
            }
            else if (radioBtnLisans.Checked == true)
            {
                label2.Text = "LİSANS";
            }
            else if (radioBtnYukLis.Checked == true)
            {
                label2.Text = "YÜKSEKLİSANS";
            }

        }
    }
}
