using IncapsulareInitiere2;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

internal class program
{
    private static void Main(string[] args)
    {
        Exemple();
    }

    public static void Exemple()
    {
        Pisica pisica1 = new Pisica();
        pisica1.varstaAni = 5;
        pisica1.inaltimeCm = 30;
        pisica1.rasaPisica = "Sfinx";

        Pisica pisica2 = new Pisica();
        pisica2.varstaAni = 3;
        pisica2.inaltimeCm = 25;
        pisica2.rasaPisica = "Persana";

        Pisica pisica3 = new Pisica();
        pisica3.varstaAni = 7;
        pisica3.inaltimeCm = 20;
        pisica3.rasaPisica = "Maine Coon";

        Pisica pisica4 = new Pisica();
        pisica4.varstaAni = 2;
        pisica4.inaltimeCm = 22;
        pisica4.rasaPisica = "Siameza";

        Pisica pisica5 = new Pisica();
        pisica5.varstaAni = 4;
        pisica5.inaltimeCm = 18;
        pisica5.rasaPisica = "Birmaneza";


        List<Pisica> pisiciLista = new List<Pisica>();
        pisiciLista.Add(pisica1);
        pisiciLista.Add(pisica2);
        pisiciLista.Add(pisica3);
        pisiciLista.Add(pisica4);
        pisiciLista.Add(pisica5);

        foreach (Pisica pisica in pisiciLista)
        {
            Console.WriteLine(pisica.PisicaInfo());
        }
        //=========
        Caine caine1 = new Caine();
        caine1.varsta = 5;
        caine1.inaltime = 30;
        caine1.rasa = "Labrador";

        Caine caine2 = new Caine();
        caine2.varsta = 3;
        caine2.inaltime = 25;
        caine2.rasa = "Bulldog";

        Caine caine3 = new Caine();
        caine3.varsta = 7;
        caine3.inaltime = 20;
        caine3.rasa = "Ciobanesc German";

        Caine caine4 = new Caine();
        caine4.varsta = 8;
        caine4.inaltime = 30;
        caine4.rasa = "Canis";

        Caine caine5 = new Caine();
        caine5.varsta = 9;
        caine5.inaltime = 24;
        caine5.rasa = "Amstaf";

        List<Caine> cainiLista = new List<Caine>();
        cainiLista.Add(caine1);
        cainiLista.Add(caine2);
        cainiLista.Add(caine3);
        cainiLista.Add(caine4);
        cainiLista.Add(caine5);

        foreach (Caine caine in cainiLista)
        {
            Console.WriteLine(caine.CaineInfo());
        }
        //=======
        Copaci copac1 = new Copaci();
        copac1.varsta = 20;
        copac1.inaltime = 15;
        copac1.tipCopac = "Stejar";

        Copaci copac2 = new Copaci();
        copac2.varsta = 10;
        copac2.inaltime = 8;
        copac2.tipCopac = "Brad";

        Copaci copac3 = new Copaci();
        copac3.varsta = 30;
        copac3.inaltime = 25;
        copac3.tipCopac = "Fag";

        Copaci copac4 = new Copaci();
        copac4.varsta = 15;
        copac4.inaltime = 12;
        copac4.tipCopac = "Plop";

        Copaci copac5 = new Copaci();
        copac5.varsta = 25;
        copac5.inaltime = 20;
        copac5.tipCopac = "Salcam";

        List<Copaci> copaciLista = new List<Copaci>();
        copaciLista.Add(copac1);
        copaciLista.Add(copac2);
        copaciLista.Add(copac3);
        copaciLista.Add(copac4);
        copaciLista.Add(copac5);

        foreach (Copaci copac in copaciLista)
        {
            Console.WriteLine(copac.CopaciInfo());
        }
        //=========
        BucheteFlori buchet1 = new BucheteFlori();
        buchet1.pret = 150;
        buchet1.fire = 30;
        buchet1.flori = "Lalele";

        BucheteFlori buchet2 = new BucheteFlori();
        buchet2.pret = 90;
        buchet2.fire = 12;
        buchet2.flori = "Zambile";

        BucheteFlori buchet3 = new BucheteFlori();
        buchet3.pret = 300;
        buchet3.fire = 30;
        buchet3.flori = "Trandafiri";

        BucheteFlori buchet4 = new BucheteFlori();
        buchet4.pret = 130;
        buchet4.fire = 15;
        buchet4.flori = "Crizanteme";

        BucheteFlori buchet5 = new BucheteFlori();
        buchet5.pret = 400;
        buchet5.fire = 25;
        buchet5.flori = "Trandafiri";
        List<BucheteFlori> bucheteFlorisLista = new List<BucheteFlori>();
        bucheteFlorisLista.Add(buchet1);
        bucheteFlorisLista.Add(buchet2);
        bucheteFlorisLista.Add(buchet3);
        bucheteFlorisLista.Add(buchet4);
        bucheteFlorisLista.Add(buchet5);
        foreach (BucheteFlori x in bucheteFlorisLista)
        {
            Console.WriteLine(x.buchetDeFlori());
        }
        //===========
        Mancare ciorba = new Mancare();
        ciorba.costTotal = 100;
        ciorba.cantitate = 2;
        ciorba.timpAcordat = 120;

        Mancare sarmale = new Mancare();
        sarmale.costTotal = 150;
        sarmale.cantitate = 15;
        sarmale.timpAcordat = 120;

        Mancare pilaf = new Mancare();
        pilaf.costTotal = 100;
        pilaf.cantitate = 80;
        pilaf.timpAcordat = 170;

        Mancare salata = new Mancare();
        salata.costTotal = 20;
        salata.cantitate = 50;
        salata.timpAcordat = 15;

        Mancare orez = new Mancare();
        orez.costTotal = 100;
        orez.timpAcordat = 90;
        orez.cantitate = 90;
        List<Mancare> mancarelist = new List<Mancare>();
        mancarelist.Add(orez);
        mancarelist.Add(salata);
        mancarelist.Add(pilaf);
        mancarelist.Add(salata);
        mancarelist.Add(ciorba);
        foreach (Mancare x in mancarelist)
        {
            Console.WriteLine(x.MancareInfo());
        }
        //========
        Dulciuri haribo = new Dulciuri();
        haribo.gramaj = 250;
        haribo.pret = 10;
        haribo.tipDulce = "Jeleuri";

        Dulciuri milka = new Dulciuri();
        milka.gramaj = 200;
        milka.pret = 12;
        milka.tipDulce = "Ciocolata";

        Dulciuri oreo = new Dulciuri();
        oreo.gramaj = 300;
        oreo.pret = 5;
        oreo.tipDulce = "Biscuiti cu ciocolata";

        Dulciuri sugus = new Dulciuri();
        sugus.gramaj = 600;
        sugus.pret = 7;
        sugus.tipDulce = "Caramele";

        Dulciuri sevenDays = new Dulciuri();
        sevenDays.tipDulce = "Corn cu ciocolata";
        sevenDays.gramaj = 300;
        sevenDays.pret = 6;
        List<Dulciuri> dulciuriLista = new List<Dulciuri>();
        dulciuriLista.Add(milka);
        dulciuriLista.Add(oreo);
        dulciuriLista.Add(sugus);
        dulciuriLista.Add(sevenDays);
        dulciuriLista.Add(haribo);
        foreach (Dulciuri x in dulciuriLista)
        {
            Console.WriteLine(x.DulciuriInfo());
        }
        //=========
        Electrocasnice cuptor = new Electrocasnice();
        cuptor.pret = 100;
        cuptor.garantie = 2;
        cuptor.greutate = 2;

        Electrocasnice frigider = new Electrocasnice();
        frigider.pret = 1000;
        frigider.garantie = 5;
        frigider.greutate = 70;

        Electrocasnice microunde = new Electrocasnice();
        microunde.pret = 900;
        microunde.garantie = 7;
        microunde.greutate = 10;

        Electrocasnice aspirator = new Electrocasnice();
        aspirator.pret = 350;
        microunde.garantie = 3;
        aspirator.greutate = 8;

        Electrocasnice bec = new Electrocasnice();
        bec.pret = 3;
        bec.garantie = 3;
        bec.greutate = 1;

        List<Electrocasnice> ElectrocasniceLista = new List<Electrocasnice>();
        ElectrocasniceLista.Add(bec);
        ElectrocasniceLista.Add(microunde);
        ElectrocasniceLista.Add(cuptor);
        ElectrocasniceLista.Add(frigider);
        ElectrocasniceLista.Add(aspirator);
        foreach (Electrocasnice x in ElectrocasniceLista)
        {
            Console.WriteLine(x.ElectrocasniceInfo());
        }
        //==============
        Alimente3 zahar = new Alimente3();
        zahar.brand = "Zahar alb";
        zahar.pret = 6;
        zahar.cantitate = 1;

        Alimente3 ovaz = new Alimente3();
        ovaz.brand = "Ovaz Romania";
        ovaz.pret = 7;
        ovaz.cantitate = 2;

        Alimente3 sare = new Alimente3();
        sare.brand = "Sare alb";
        sare.pret = 8;
        sare.cantitate = 1;

        Alimente3 salam = new Alimente3();
        salam.pret = 14;
        salam.cantitate = 1;
        salam.brand = "Sibiu salam";

        Alimente3 malai = new Alimente3();
        malai.pret = 15;
        malai.cantitate = 2;
        malai.brand = "Malai Romanesc";

        List<Alimente3> Alimente3Lista = new List<Alimente3>();
        Alimente3Lista.Add(salam);
        Alimente3Lista.Add(sare);
        Alimente3Lista.Add(ovaz);
        Alimente3Lista.Add(zahar);
        Alimente3Lista.Add(malai);
        foreach (Alimente3 x in Alimente3Lista)
        {
            Console.WriteLine(x.InfoAlimente3());
        }
        //==============
        Alimente2 unt = new Alimente2();
        unt.pret = 12;
        unt.brand = "Unt";
        unt.cantitate = 200;

        Alimente2 sunca = new Alimente2();
        sunca.pret = 20;
        sunca.cantitate = 300;
        sunca.brand = "Cristin";

        Alimente2 kefir = new Alimente2();
        kefir.pret = 9;
        kefir.cantitate = 100;
        kefir.brand = "Kefir";

        Alimente2 lipii = new Alimente2();
        lipii.pret = 10;
        lipii.cantitate = 1;
        lipii.brand = "Brasoveana";

        Alimente2 pere = new Alimente2();
        pere.pret = 8;
        pere.cantitate = 3;
        pere.brand = "Pere Romanesti";
        List<Alimente2> Alimente2Liste = new List<Alimente2>();
        Alimente2Liste.Add(unt);
        Alimente2Liste.Add(sunca);
        Alimente2Liste.Add(lipii);
        Alimente2Liste.Add(kefir);
        Alimente2Liste.Add(pere);
        foreach (Alimente2 x in Alimente2Liste)
        {
            Console.WriteLine(x.InfoAlimente2());
        }
        //===========
        Sucuri cola = new Sucuri();
        cola.brand = "Coca Cola";
        cola.cantitate = 2;
        cola.pret = 12;
        Console.Write(cola.InfoSucuri());

        Sucuri fanta = new Sucuri();
        fanta.brand = "Fanta Lamaie";
        fanta.cantitate = 1;
        fanta.pret = 6;
        Console.Write(fanta.InfoSucuri());

        Sucuri pepsi = new Sucuri();
        pepsi.brand = "Pepsi Zero";
        pepsi.cantitate = 2;
        pepsi.pret = 11;
        Console.Write(pepsi.InfoSucuri());

        Sucuri tymbark = new Sucuri();
        tymbark.brand = "Tymbark Visine";
        tymbark.cantitate = 1;
        tymbark.pret = 4;
        Console.Write(tymbark.InfoSucuri());

        Sucuri fuzetea = new Sucuri();
        fuzetea.brand = "Fuzetea lamaie";
        fuzetea.cantitate = 05;
        fuzetea.pret = 10;
        Console.Write(fuzetea.InfoSucuri());
        Console.WriteLine("==========");

        List<Sucuri> SucuriLista = new List<Sucuri>();
        SucuriLista.Add(fuzetea);
        SucuriLista.Add(tymbark);
        SucuriLista.Add(pepsi);
        SucuriLista.Add(fanta);
        SucuriLista.Add(cola);
        foreach (Sucuri x in SucuriLista)
        {
            Console.WriteLine(x.InfoSucuri());
        }

        //============
        Alimente lapte = new Alimente();
        lapte.produs = "ZUZU";
        lapte.pret = 12;
        lapte.cantitate = 1;
        Console.WriteLine(lapte.InfoAlimente());

        Alimente branza = new Alimente();
        branza.pret = 22;
        branza.produs = "Branza de vaca";
        branza.cantitate = 4;
        Console.WriteLine(branza.InfoAlimente());

        Alimente paine = new Alimente();
        paine.pret = 2;
        paine.cantitate = 1;
        paine.produs = "Paine Boiereasca";
        Console.WriteLine(paine.InfoAlimente());

        Alimente rosi = new Alimente();
        rosi.pret = 13;
        rosi.cantitate = 2;
        rosi.produs = "Rosii Romanesti";
        Console.WriteLine(rosi.InfoAlimente());

        Alimente mere = new Alimente();
        mere.pret = 10;
        mere.cantitate = 2;
        mere.produs = "Mere Romanesti";
        Console.WriteLine(mere.InfoAlimente());
        Console.WriteLine("================");

        List<Alimente> ListaAlimente = new List<Alimente>();
        ListaAlimente.Add(lapte);
        ListaAlimente.Add(rosi);
        ListaAlimente.Add(mere);
        ListaAlimente.Add(paine);
        ListaAlimente.Add(branza);
        foreach (Alimente x in ListaAlimente)
        {
            Console.WriteLine(x.InfoAlimente());
        }
    }
}