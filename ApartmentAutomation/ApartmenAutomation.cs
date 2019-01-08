using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentAutomation
{
    public partial class ApartmenAutomation : Form
    {
        public ApartmenAutomation()
        {
            InitializeComponent();
        }
        

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Gelirler f = new Gelirler();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Giderler f = new Giderler();
            f.MdiParent = this;
            f.Show();
        }
    }
}
