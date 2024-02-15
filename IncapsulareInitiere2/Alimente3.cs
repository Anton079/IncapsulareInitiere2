using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapsulareInitiere2
{
    public class Alimente3
    {
        public string brand;
        public int pret;
        public int cantitate;

        public string InfoAlimente3()
        {
            string text = " ";
            text += "Brand" + brand + "\n";
            text += "Pret" + pret + "\n";
            text += "Cantiate" + cantitate + "\n";
            return text;
        }
    }
}
