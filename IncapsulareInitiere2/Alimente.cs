﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapsulareInitiere2
{
    public class Alimente
    {
        public string produs;
        public int pret;
        public int cantitate;

        public string InfoAlimente()
        {
            string text = " ";
            text += "Nume produs " + produs + " \n";
            text += "Pretul " + pret + "\n";
            text += "Cantiatea " + cantitate + "\n";
            return text;
        }
    }
}
