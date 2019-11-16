using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI.Zajecia1
{
    class PlanLekcji
    {
        static void Main(string[] args)
        {
            List<Zajecia> kolekcjaZajec = new List<Zajecia>();

            Zajecia wprowadzenieDoVS = new Zajecia();
            wprowadzenieDoVS.CzyEgzamin = true;
            wprowadzenieDoVS.Prowadzacy = "Lukasz Chomatek";
            wprowadzenieDoVS.Sala = "2";
            wprowadzenieDoVS.Dlugosc = new TimeSpan(3, 15, 0);
            wprowadzenieDoVS.GodzinaRozpoczecia =
                new DateTime(2019, 11, 16, 9, 30, 0);
            wprowadzenieDoVS.Nazwa =
                "Wprowadzenie do VS i języka C#";

            Zajecia wprowadzenieDoVSCz2 =
                new Zajecia()
                {
                    Nazwa = "Wyprowadzenie z VS i języka C#",
                    CzyEgzamin = true,
                    Prowadzacy = "Lukasz Chomatek",
                    Sala = "2",
                    Dlugosc = new TimeSpan(3, 15, 0),
                    GodzinaRozpoczecia =
                        new DateTime(2019, 11, 16, 13, 15, 0)
                };

            Zajecia wprowadzenieDoLINQ =
                new Zajecia()
                {
                    Nazwa = "Metodyka LINQ",
                    CzyEgzamin = true,
                    Prowadzacy = "Lukasz Chomatek",
                    Sala = "2",
                    Dlugosc = new TimeSpan(3, 15, 0),
                    GodzinaRozpoczecia =
                        new DateTime(2019, 11, 16, 13, 15, 0)
                };

            Zajecia wprowadzenieDoLINQKopia =
                new Zajecia()
                {
                    Nazwa = "Metodyka LINQ",
                    CzyEgzamin = true,
                    Prowadzacy = "Lukasz Chomatek",
                    Sala = "2",
                    Dlugosc = new TimeSpan(3, 15, 0),
                    GodzinaRozpoczecia =
                        new DateTime(2019, 11, 16, 13, 15, 0)
                };
            kolekcjaZajec.Add(wprowadzenieDoVS);
            kolekcjaZajec.Add(wprowadzenieDoVSCz2);
            kolekcjaZajec.Add(wprowadzenieDoLINQ);

            for (int i = 3; i < 100; i++)
            {
                Zajecia noweZajecia =
                new Zajecia()
                {
                    Nazwa = "Metodyka LINQ",
                    CzyEgzamin = true,
                    Prowadzacy = "Lukasz Chomatek",
                    Sala = i.ToString(),
                    Dlugosc = new TimeSpan(3, 15, 0),
                    GodzinaRozpoczecia =
                        new DateTime(2019, 11, 16, 13, 15, 0)
                };
                //kolekcjaZajec.Add(noweZajecia);
            }
            kolekcjaZajec.Sort();

            bool czyZawieraLINQ = kolekcjaZajec.Contains(wprowadzenieDoLINQ);
            bool czyZawieraKopie = kolekcjaZajec.Contains(wprowadzenieDoLINQKopia);
            WyswietlWszystkieZajeciaZKolekcji(kolekcjaZajec);
            Console.WriteLine(czyZawieraLINQ);
            Console.WriteLine(czyZawieraKopie);


            Console.ReadKey();
            //WyswietlWszystkieZajeciaZKolekcji(kolekcjaZajec);

            /*ConsoleKey userInput = ConsoleKey.Enter;
            while(userInput != ConsoleKey.Escape)
            {
                // kod do wprowadzenia zajęć
                Zajecia noweZajecia = Zajecia.WczytajDaneZajec();
                kolekcjaZajec.Add(noweZajecia);
                // kod do wyświetlenia zajęć
                WyswietlWszystkieZajeciaZKolekcji(kolekcjaZajec);
                Console.WriteLine("Czy chcesz dodać kolejne zajęcia? (Esc - wyjście)");
                userInput = Console.ReadKey().Key;
            }*/
        }

        private static void WyswietlWszystkieZajeciaZKolekcji(List<Zajecia> kolekcjaZajec)
        {
            foreach (Zajecia pojedynczeZajecia in kolekcjaZajec)
            {
                pojedynczeZajecia.WypiszZajecia();
            }
        }
    }
}
