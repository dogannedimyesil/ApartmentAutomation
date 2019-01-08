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
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //GELİR EKLEME
            Gelir yeniGelir = new Gelir();
            yeniGelir.DaireNo = (int)numericUpDown1.Value;
            yeniGelir.Tarih = dateTimePicker1.Value;
            yeniGelir.Tutar = Convert.ToDecimal(textBox1.Text);

            GelirRepo.GelirEkle(yeniGelir);
            FillGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
        }
        private void FillGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GelirRepo.GelirListesiniGetir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
