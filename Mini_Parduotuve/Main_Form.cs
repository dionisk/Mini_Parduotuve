using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Parduotuve
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            dataGridView_PrekiuKatalogas.DataSource = DuomenuBaze.Prekes;
            dataGridView_PrekiuKatalogas.Columns["Ilgis_cm"].Visible = false;
            dataGridView_PrekiuKatalogas.Columns["Plotis_cm"].Visible = false;
            dataGridView_PrekiuKatalogas.Columns["Aukstis_cm"].Visible = false;
            dataGridView_PrekiuKatalogas.Columns["Turis"].Visible = false; 
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void button_RinktisPrekesIKrepseli_Click(object sender, EventArgs e)
        {
            AddToBasketForm addToBasketForm = new AddToBasketForm();
            addToBasketForm.Show();          
        }

        private void button_PatikrintiPirkiniuKrepseli_Click(object sender, EventArgs e)
        {
            BasketReviewForm basketReviewForm = new BasketReviewForm();
            basketReviewForm.Show();
        }

        private void button_FormuotiSiunta_Click(object sender, EventArgs e)
        {
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.Show();
        }
    }
}
