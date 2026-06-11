using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] asistencia = new int[5];
            bool existeCero;
            int indiceModificar, nuevoValor;
            existeCero = false;
            for (int i = 0; i < asistencia.Length; i++)
            {
                Console.Write($"Asistencia sesión {i + 1}: ");
                asistencia[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nAsistencias registradas:");
            for (int i = 0; i < asistencia.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {asistencia[i]}");
            }

            for (int i = 0; i < asistencia.Length; i++)
            {
                if (asistencia[i] == 0)
                {
                    existeCero = true;
                }
            }
            if (existeCero)
            {
                Console.WriteLine("Alerta: existe una sesión con 0 asistentes");
            }
            else
            {
                Console.WriteLine("No hay sesión con 0 asistentes");
            }
            Console.Write("\nÍndice a modificar: ");
            indiceModificar = int.Parse(Console.ReadLine());

            if (indiceModificar >= 0 && indiceModificar < asistencia.Length)
            {
                Console.Write("Nuevo valor: ");
                nuevoValor = int.Parse(Console.ReadLine());
                asistencia[indiceModificar] = nuevoValor;
            }
            else
            {
                Console.WriteLine("Índice no válido");
            }
            Console.WriteLine("\nAsistencias actualizadas:");
            for (int i = 0; i < asistencia.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {asistencia[i]}");
            }
        }
    }
}
