using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int [7];
            int diaENCONTRADO = -1;

            for(int i = 0; i < temp.Length; i++)
            {
                Console.Write($"Ingrese temperatura del día {i+1}: ");
                temp[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] > 30 && diaENCONTRADO == -1)
                {
                    diaENCONTRADO = i;
                }
            }

            if (diaENCONTRADO != -1)
            {
                Console.WriteLine("Primera alerta en día " + (diaENCONTRADO + 1));
            }
            else
            {
                Console.WriteLine("No hubo alerta de temperatura");
            }
        }
    }
}
