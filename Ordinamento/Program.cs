using MetodiOrdinamenti;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Ordinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensioni = { 10, 20, 50, 100, 500, 1000, 2000, 5000, 10000, 20000, 30000, 40000, 50000 };
            using (StreamWriter w = new StreamWriter("stat.csv", false, Encoding.UTF8))
            {
                w.WriteLine("Algoritmo ; Dimensione ; Tempo");
                foreach (int dim in dimensioni)
                {
                    // 1. Crea array
                    int[] numeri = new int[dim];
                    // 2. Genera casuali 
                    Random r = new Random();
                    for (int i = 0; i < dim; i++)
                        numeri[i] = r.Next();
                    // 3. Parte cronometro
                    Stopwatch s = new Stopwatch();
                    // 4. Ordina
                    BubbleSort.Bubble_Sort(numeri);
                    InsertSort
                }
            }
        }
    }
}
