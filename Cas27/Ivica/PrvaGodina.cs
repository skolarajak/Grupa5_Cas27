using System;

namespace Cas27.Ivica
{
    class PrvaGodina : Udzbenici
    {
        public bool Iznajmljena { get; set; } = true;
        /*
         * Method overloading:
         * public void Procitaj(bool DaLiJeIznajmljena)
         */
        new public void Procitaj()
        {
            if (Iznajmljena)
            {
                Console.WriteLine("Iznajmili ste {0}, izdatu {1} godine", Naslov, GodinaIzdavanja);
            }
            else
            {
                Console.WriteLine("Niste Iznajmili knjigu {0}, izdatu {1} godine", Naslov, GodinaIzdavanja);
            }
        }
    }
}
