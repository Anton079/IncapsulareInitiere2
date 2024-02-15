using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapsulareInitiere2
{
    public class BucheteFlori
    {
        public int fire;
        public int pret;
        public string flori;

        public string buchetDeFlori()
        {
            string text = " ";
            text += "Cate fire " + fire + "\n";
            text += "Pretul" + pret + "\n";
            text += "FLori " + flori + "\n";
            return text;
        }
    }
}
