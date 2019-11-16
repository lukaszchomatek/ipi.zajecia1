using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI.Zajecia1
{
  
    class Zajecia
    {
        public string Nazwa { get; set; }
        public string Prowadzacy { get; set; }
        public string Sala { get; set; }
        public bool CzyEgzamin { get; set; }
        public TimeSpan Dlugosc { get; set; }
        public DateTime GodzinaRozpoczecia { get; set; }

        public DateTime GodzinaZakonczenia
        {
            get {
                return GodzinaRozpoczecia.
                    AddTicks(Dlugosc.Ticks);
            }
        }
        public void WypiszZajecia()
        {
            Console.WriteLine("Nazwa: " + Nazwa);
            Console.WriteLine("Sala: " + Sala);
            Console.WriteLine("Godzina rozpoczęcia: " + GodzinaRozpoczecia);
            Console.WriteLine("Godzina zakończenia: " + GodzinaZakonczenia);
        }
    }
}
