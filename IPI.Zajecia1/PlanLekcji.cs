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
                    Nazwa = "Wprowadzenie do VS i języka C#",
                    CzyEgzamin = true,
                    Prowadzacy = "Lukasz Chomatek",
                    Sala = "2",
                    Dlugosc = new TimeSpan(3, 15, 0),
                    GodzinaRozpoczecia =
                        new DateTime(2019, 11, 16, 13, 15, 0)
                };

            wprowadzenieDoVS.WypiszZajecia();
            wprowadzenieDoVSCz2.WypiszZajecia();
            Console.ReadKey();
        }
    }
}
