using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 1, 3, 5, 6, 4, 8, 10, 11 };

            int[,] tab2d = { { 1, 3, 4 }, { 2, 5, 6 } };

            int[,] innaTablica2d = new int[5, 6];

            int[][] jaggedArray = new int[5][];
            jaggedArray[0] = new int[10];
            jaggedArray[1] = new int[11];

            policzElementyMniejszeNiz(tablica, 10);

            Console.ReadKey();
        }

        private static void policzElementyMniejszeNiz(int[] tablica, int wartosc)
        {
            int liczbaElementow = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] < wartosc)
                {
                    liczbaElementow = liczbaElementow + 1;
                    //liczbaElementow++;
                    //liczbaElementow += 1;
                }
            }
            Console.WriteLine(liczbaElementow);
        }

        private static void wypiszCoDrugiElementInnymSposobem(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(tablica[i]);
                }
            }
        }

        private static void wypiszCoDrugiElement(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i+=2)
            {
                Console.WriteLine(tablica[i]);
            }
        }
    }
}
