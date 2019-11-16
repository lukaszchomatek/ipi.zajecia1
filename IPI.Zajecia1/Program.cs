using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPI.Zajecia1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            //DateTime today = new DateTime(2019, 11, 16);
            DateTime now = DateTime.Now;
            KalkulatorDni.ObliczIWypiszLiczbeDniPomiedzyDatami(now, new DateTime(2019, 12, 24));
            Thread.Sleep(5000);
            now = DateTime.Now;
            KalkulatorDni.ObliczIWypiszLiczbeDniPomiedzyDatami(now, new DateTime(2019, 12, 24));
            
            Console.ReadKey();

        }
    }
}
