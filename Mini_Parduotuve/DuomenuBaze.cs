using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Parduotuve
{
    public class DuomenuBaze
    {
        public static List<Preke> Prekes;
        public static List<Krepselio_preke> Krepselio_Prekes;

        public DuomenuBaze()
        {
            Prekes = new List<Preke>();
            Prekes.Add(new Preke(1,"Veliava", 5, 6, 4, 10));
            Prekes.Add(new Preke(2,"Sachmatai", 4, 7, 2, 15));
            Prekes.Add(new Preke(3,"Begimo takelis", 28, 23, 26, 150));
            Prekes.Add(new Preke(4,"Laptopas", 10, 9, 8, 500));
            Prekes.Add(new Preke(5,"Knyga", 4, 5, 5, 11));
            Prekes.Add(new Preke(6,"Kede", 25, 25, 28, 50));
            Prekes.Add(new Preke(7,"Ausines", 4, 2, 2, 8));

            Krepselio_Prekes = new List<Krepselio_preke>();
        }
    }
}
