using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI.Zajecia1
{
    /// <summary>
    /// Klasa do obliczeń na dniach
    /// </summary>
    class KalkulatorDni
    {
        /// <summary>
        /// Metoda wyświetla liczbę dni pomiędzy wskazanymi datami
        /// </summary>
        /// <param name="dateStart">Data początkowa</param>
        /// <param name="dateFinish">Data końcowa</param>
        public static void ObliczIWypiszLiczbeDniPomiedzyDatami(DateTime dateStart, DateTime dateFinish)
        {
            TimeSpan timespan = new TimeSpan(dateFinish.Ticks - dateStart.Ticks);
            if (timespan.Days != 1)
            {
                Console.Write(timespan.Days + " dni, ");
            }
            else
            {
                Console.Write(timespan.Days + " dzień");
            }
            Console.Write(timespan.Hours + " godzin, ");
            Console.Write(timespan.Minutes + " minut, ");
            Console.WriteLine(timespan.Seconds);
        }
    }
}
