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

        public static Zajecia WczytajDaneZajec()
        {
            Zajecia noweZajecia = new Zajecia();
            Console.WriteLine("Podaj nazwę zajęć");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj salę");
            string sala = Console.ReadLine();
            Console.WriteLine("Podaj datę");
            string data = Console.ReadLine();
            Console.WriteLine("Podaj godzinę");
            string godzinaRozpoczecia = Console.ReadLine();
            Console.WriteLine("Ile trwają zajęcia?");
            string czasTrwania = Console.ReadLine();

            noweZajecia.Nazwa = nazwa;
            noweZajecia.Sala = sala;
            noweZajecia.GodzinaRozpoczecia = DateTime.Parse(data);

            int hour = int.Parse(godzinaRozpoczecia.Split(':')[0]);
            int minute = int.Parse(godzinaRozpoczecia.Split(':')[1]);

            noweZajecia.GodzinaRozpoczecia =
                noweZajecia.GodzinaRozpoczecia.AddHours(hour);
            noweZajecia.GodzinaRozpoczecia =
                noweZajecia.GodzinaRozpoczecia.AddMinutes(minute);

            hour = int.Parse(czasTrwania.Split(':')[0]);
            minute = int.Parse(czasTrwania.Split(':')[1]);

            noweZajecia.Dlugosc = new TimeSpan(hour, minute, 0);
            return noweZajecia;
        }
    }
}
