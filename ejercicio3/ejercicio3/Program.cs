using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] codigos = new int[5];

            for (int i = 0; i < codigos.Length; i++)
            {
                Console.Write($"Código {i + 1}: ");
                codigos[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Código a buscar: ");
            int buscado = int.Parse(Console.ReadLine());

            int posicion = -1;

            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == buscado)
                {
                    posicion = i;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"Código encontrado en indice {posicion}");
            }
            else
            {
                Console.WriteLine("Código no encontrado");
            }
        }
    }
}
