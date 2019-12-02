using System;

namespace Cas27.Ivana
{
    class Knjiga
    {
        private string _autor = "";
        private string _naslov = "";
        private string _zanr = "";
        private int _godinaIzdanja = 0;

        public string Autor
        {
            get
            {
                return _autor;
            }
            set
            {
                _autor = value;
            }
        }

        public string Naslov
        {
            get
            {
                return _naslov;
            }
            set
            {
                _naslov = value;
            }
        }

        public string Zanr
        {
            get
            {
                return _zanr;
            }
            set
            {
                _zanr = value;
            }
        }

        public int GodinaIzdanja
        {
            get
            {
                return _godinaIzdanja;
            }
            set
            {
                _godinaIzdanja = value;
            }
        }

        public void StampajNaslov()
        {
            Console.WriteLine("Naslov: {0}", _naslov);
        }
    }
}
