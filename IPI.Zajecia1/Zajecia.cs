using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI.Zajecia1
{
    class ZajeciaInne
    {
        public string Nazwa { get; set; }
        public string Prowadzacy { get; set; }
        public string Sala { get; set; }

        public ZajeciaInne(string nazwa, string sala)
        {
            Nazwa = nazwa;
            Sala = sala;
        }
    }
    class Zajecia
    {
        public string Nazwa { get; set; }
        public string Prowadzacy { get; set; }
        public string Sala { get; set; }
        public bool CzyEgzamin { get; set; }
        public TimeSpan Dlugosc { get; set; }
        public DateTime GodzinaRozpoczecia { get; set; }

        public void WypiszZajecia()
        {
            Console.WriteLine("Nazwa: " + Nazwa);
            Console.WriteLine("Sala: " + Sala);
            Console.WriteLine("Godzina rozpoczęcia: " + GodzinaRozpoczecia);
        }
    }
}
