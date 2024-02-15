using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapsulareInitiere2
{
    public class Copaci
    {
        public int varsta;
        public int inaltime;
        public string tipCopac;

        public string CopaciInfo()
        {
            string text = " ";
            text += "Varsta" + varsta + "\n";
            text += "Inaltime" + inaltime + "\n";
            text += "Tip Copac" + tipCopac + "\n";
            return text;
        }
    }
}
