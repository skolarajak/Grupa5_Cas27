using System;
/*
 * Obzirom da se dodatne klase nalaze u pripadajucim podfolderima
 * automatski pripadaju namespaceu Cas27.<podfolder>
 */
 // Ivicine klase
using Cas27.Ivica;

// Ivanine klase
using Cas27.Ivana;

namespace Cas27
{
    
    class Program
    {
        static void Main(string[] args)
        {
            IvicinKod();
            Console.WriteLine("\n\n *** *** *** *** ***\n\n");
            IvaninKod();
            Console.ReadKey();
        }

        static void IvaninKod()
        {
            /*
             * Obzirom da imamo dve klase Knjiga, za slucaj da moramo
             * da pristupimo obema, radili bismo to na sledeci nacin:
             * var K = new Ivana.Knjiga();
             * ili
             * var K = new Ivica.Knjiga();
             */
            var knjiga1 = new Avantura
            {
                Autor = "Pera Peric",
                Naslov = "Dozivljaji vesele druzine",
                GodinaIzdanja = 1985
            };

            var knjiga2 = new NaucnaFantastika
            {
                Autor = "Zika Zikic",
                Naslov = "Putovanje u nepoznato",
                GodinaIzdanja = 1968
            };

            knjiga1.StampajNaslov();
            Console.WriteLine("Autor: {0}", knjiga1.Autor);
            Console.WriteLine("Zanr: {0}", knjiga1.Zanr);
            Console.WriteLine("Godina: {0}", knjiga1.GodinaIzdanja);
            Console.WriteLine("======================================================");
            knjiga2.StampajNaslov();
            Console.WriteLine("Autor: {0}", knjiga2.Autor);
            Console.WriteLine("Zanr: {0}", knjiga2.Zanr);
            Console.WriteLine("Godina: {0}", knjiga2.GodinaIzdanja);
        }

        static void IvicinKod()
        {
            Udzbenici udzbenik = new Udzbenici();
            udzbenik.Autor = "Miloje Peic";
            udzbenik.BrojStranica = 233;
            udzbenik.Naslov = "Kako nauciti nasledjivanje";
            udzbenik.GodinaIzdavanja = 2018;
            udzbenik.Procitaj();

            PrvaGodina prva = new PrvaGodina();
            prva.Iznajmljena = false;
            prva.GodinaIzdavanja = 2018;
            prva.Naslov = "Kako nauciti nasledjivanje u tri koraka";
            prva.Procitaj();
        }

        static void Deo1(string[] args)
        {
            Student st = new Student();
            EngineeringStudent es = new EngineeringStudent();
            es.FirstName = "Jovan";
            es.LastName = "Jovanovic";
            es.Age = 21;
            Console.WriteLine("Ime: {0}\nPrezime: {1}\nStarost: {2}\n\n", st.FirstName, st.LastName, st.Age);
            Console.WriteLine("Ime: {0}\nPrezime: {1}\nStarost: {2}\n\n", es.FirstName, es.LastName, es.Age);
            Console.WriteLine(es.SayAge());
            Console.ReadKey();
        }
    }
}
