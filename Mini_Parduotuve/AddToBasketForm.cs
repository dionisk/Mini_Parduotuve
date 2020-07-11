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
    public partial class AddToBasketForm : Form
    {
        public AddToBasketForm()
        {
            InitializeComponent();          
            comboBox_PrekiuSarasas.DataSource = DuomenuBaze.Prekes;
            comboBox_PrekiuSarasas.DisplayMember = "Pavadinimas";
            comboBox_PrekiuSarasas.ValueMember = "Id";
        }

        private void button_AtsauktiPrekesPridejimaIKrepseli_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void comboBox_PrekiuSarasas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preke preke = comboBox_PrekiuSarasas.SelectedItem as Preke;
            textBox_PasirinktosPrekesKaina.Text = preke.Kaina_vnt.ToString();
        }

        private void button_PridetiIKrepseli_Click(object sender, EventArgs e)
        {
            Preke preke = comboBox_PrekiuSarasas.SelectedItem as Preke;
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke(preke.Pavadinimas,preke.Kaina_vnt, Decimal.ToInt32(numericUpDown_PasirinktosPrekesVienetuSk.Value),preke.Turis));
            this.Close();
            this.Dispose();
        }

        private void AddToBasketForm_Load(object sender, EventArgs e)
        {

        }
    }
}
