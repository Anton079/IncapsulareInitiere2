using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapsulareInitiere2
{
    public class Electrocasnice
    {
        public int pret;
        public int greutate;
        public int garantie;

        public string ElectrocasniceInfo()
        {
            string text = " ";
            text += "Pret" + pret + "\n";
            text += "Greutate" + greutate + "\n";
            text += "Garantie" + garantie + "\n";
            return text;
        }
    }
}
