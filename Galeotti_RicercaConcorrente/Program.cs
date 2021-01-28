using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Galeotti_RicercaConcorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[100];
            RiempiArray(ref numeri);
            Console.WriteLine("Inserisci un numero da cercare:");
            int n1 = int.Parse(Console.ReadLine());
            Thread thread = new Thread(() => RicercaNumero(n1,numeri));
            thread.Start();
            Console.WriteLine("Inserisci un numero da cercare:");
            int n2 = int.Parse(Console.ReadLine());
            RicercaNumero(n2, numeri);
            Console.ReadLine();
        }

        private static void RicercaNumero(int n, int[]array)
        {
            for(int i = 0; i < 100; i++)
            {
                if (n == array[i])
                {
                    Console.WriteLine($"Trovato {array[i]} in posizione {i}");
                }
            }
            Console.WriteLine("Ricerca finita.");
        }

        private static void RiempiArray(ref int[]numeri)
        {
            Random r = new Random();
            for (int n =0; n < 100; n++)
            {
                numeri[n] = r.Next(0,100);
            }
        }
    }
}
