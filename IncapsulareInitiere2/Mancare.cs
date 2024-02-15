using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapsulareInitiere2
{
    public class Mancare
    {
        public int cantitate;
        public int costTotal;
        public int timpAcordat;

        public string MancareInfo()
        {
            string text = " ";
            text += "Cantitatea" + cantitate + "\n";
            text += "Cost total" + costTotal + "\n";
            text += "Timp acordat" + timpAcordat + "\n";
            return text;
        }
    }
}
