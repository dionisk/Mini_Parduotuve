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
    public partial class ShipmentForm : Form
    {
        public Siunta _Siunta;
        public ShipmentForm()
        {
            InitializeComponent();
            _Siunta = new Siunta();
        }

        private void button_Atsaukti_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();           
        }

        private void button_Formuoti_Click(object sender, EventArgs e)
        {
            FormuotiSiunta();
        }

        void FormuotiSiunta()
        {
            ApskaiciuotiSiuntosDydi();
            if (radioButton_IPastomata.Checked && _Siunta.Siuntos_dydis == 'L')
            {
                MessageBox.Show("Siunta per didelė, kad tilptu į paštomatą. Pasirinkite kitą pristatymo būdą.");
            }
            else
            {
                ApskaiciuotiSuma();
                SetPristatymoBudas();
                this.Close();
                this.Dispose();
            }
        }

        public void ApskaiciuotiSuma()
        {
            int suma = 0;
            int MokestisUzSdydzioSiunta = 10;
            int MokestisUzMdydzioSiunta = 20;
            int MokestisUzLdydzioSiunta = 40;
            foreach (Krepselio_preke preke in DuomenuBaze.Krepselio_Prekes)
            {
                suma += preke.Bendra_suma;
            }
            if (_Siunta.Siuntos_dydis == 'L')
            {
                suma += MokestisUzLdydzioSiunta;
            }
            if (_Siunta.Siuntos_dydis == 'M')
            {
                suma += MokestisUzMdydzioSiunta;
            }
            if (_Siunta.Siuntos_dydis == 'S')
            {
                suma += MokestisUzSdydzioSiunta;                
            }
            _Siunta.Suma = suma;
        }

        public void ApskaiciuotiSiuntosDydi()
        {
            int turis = 0;
            foreach (Krepselio_preke preke in DuomenuBaze.Krepselio_Prekes)
            {
                turis += preke.Bendras_turis;
            }
            int LdydzioMINTuris = 94848;
            int MdydzioMINTuris = 46208;
            if (turis >= LdydzioMINTuris)
            {
                _Siunta.Siuntos_dydis = 'L';
            }
            else if (turis < LdydzioMINTuris && turis >= MdydzioMINTuris)
            {
                _Siunta.Siuntos_dydis = 'M';
            }
            else
            {
                _Siunta.Siuntos_dydis = 'S';
            }

        }

        void SetPristatymoBudas()
        {
            if (radioButton_IPastomata.Checked)
            {
                _Siunta.Pristatymo_budas = radioButton_IPastomata.Text;
            }
            if (radioButton_PerKurjerius.Checked)
            {
                _Siunta.Pristatymo_budas = radioButton_PerKurjerius.Text;
            }
            if (radioButton_PerPasta.Checked)
            {
                _Siunta.Pristatymo_budas = radioButton_PerPasta.Text;
            }
            if (radioButton_TarptautinisSiuntimas.Checked)
            {
                _Siunta.Pristatymo_budas = radioButton_TarptautinisSiuntimas.Text;
            }
        }

        private void ShipmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
