using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Parduotuve
{
    public class Siunta
    {
        int Id { get; set; }
        public char Siuntos_dydis { get; set; }
        public int Suma { get; set; }
        public string Pristatymo_budas { get; set; }


        public Siunta()
        {
            Id = new Random().Next();
        }

    }
}
