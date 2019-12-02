using System;

namespace Cas27.Ivica
{
    class Knjiga
    {
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public int BrojStranica { get; set; }

        public void Procitaj()
        {
            Console.WriteLine("Procitali ste {0}", Naslov);
        }
    }
}
