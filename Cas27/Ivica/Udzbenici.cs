using System;

namespace Cas27.Ivica
{
    class Udzbenici : Knjiga
    {
        public int GodinaIzdavanja { get; set; }

        public new void Procitaj()
        {
            Console.WriteLine("Procitali ste {0}, izdatu {1} godine", Naslov, GodinaIzdavanja);
        }

    }
}
