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
    public partial class BasketReviewForm : Form
    {
        public BasketReviewForm()
        {
            InitializeComponent();
            dataGridView_PasirinktosPrekes.DataSource = DuomenuBaze.Krepselio_Prekes;
            dataGridView_PasirinktosPrekes.Columns["Bendras_turis"].Visible = false;
            ApsipirkimoSuma.Text = ApskaiciuotiBendraSuma().ToString();
        }

        public int ApskaiciuotiBendraSuma()
        {
            int suma = 0;
            foreach (Krepselio_preke preke in DuomenuBaze.Krepselio_Prekes)
            {
                suma += preke.Bendra_suma;
            }
            return suma;
        }

        private void BasketReviewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
