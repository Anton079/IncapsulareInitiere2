using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapsulareInitiere2
{
    public class Alimente2
    {
        public string brand;
        public int pret;
        public int cantitate;

        public string InfoAlimente2()
        {
            string text = " ";
            text += "Brand" + brand + "\n";
            text += "Pret" + pret + "\n";
            text += "Cantitate" + cantitate + "\n";
            return text;
        }
    }
}
