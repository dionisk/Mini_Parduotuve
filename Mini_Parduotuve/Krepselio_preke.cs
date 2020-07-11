using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Parduotuve
{
    public class Krepselio_preke
    {
        public string Pavadinimas { get; set; }
        public int Bendras_turis { get; set; }
        public int Bendra_suma { get; set; }

        public Krepselio_preke(string pavadinimas, int vnt_kaina, int kiekis, int turis)
        {
            Pavadinimas = pavadinimas;
            Bendras_turis = turis * kiekis;
            Bendra_suma = vnt_kaina * kiekis;
        }
    }
}
