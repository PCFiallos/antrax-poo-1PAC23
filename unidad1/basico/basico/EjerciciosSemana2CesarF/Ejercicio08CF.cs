using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.EjerciciosSemana2CesarF
{
    internal class Ejercicio08CF
    {
        public Ejercicio08CF()
        {
            float factorial = 1;
            Console.WriteLine("Ingresa un numero: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El factoriak es: " + factorial);
        }
    }
}
