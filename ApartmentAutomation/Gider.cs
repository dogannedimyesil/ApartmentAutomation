using ApartmentAutomation.BusinessLogic;
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
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }

        private void btn_GiderEkle_Click(object sender, EventArgs e)
        {
            
            string gidertur = "";
            foreach (Control item in this.groupBox1.Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox chk = item as CheckBox;
                    if(chk.Checked == true)
                    {
                        gidertur += item.Text.ToString() + ",";
                    }
                }
            }
            Gider yeniGider = new Gider();
            yeniGider.Tarih = dateTimePicker1.Value;
            yeniGider.Tutar = Convert.ToDecimal(textBox1.Text);
            yeniGider.GiderTurleri = gidertur.ToString();
            GiderRepo.GiderEkle(yeniGider);
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GiderRepo.GiderListesiniGetir();
        }
    }
}
