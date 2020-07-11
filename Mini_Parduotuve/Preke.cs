using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Parduotuve
{
    public class Preke
    {    
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public int Ilgis_cm { get; set; }
        public int Plotis_cm { get; set; }
        public int Aukstis_cm { get;set; }
        public int Turis { get; set; }
        public int Kaina_vnt { get; set; }
        

        public Preke(int id, string pavadinimas, int ilgis_cm, int plotis_cm, int aukstis_cm, int kaina_vnt)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            Ilgis_cm = ilgis_cm;
            Plotis_cm = plotis_cm;
            Aukstis_cm = aukstis_cm;
            Kaina_vnt = kaina_vnt;
            Turis = Ilgis_cm * Plotis_cm * Aukstis_cm;
        }      
    }
}
