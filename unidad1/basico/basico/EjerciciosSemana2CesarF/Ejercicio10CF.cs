using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.EjerciciosSemana2CesarF
{
    internal class Ejercicio10CF
    {
        public Ejercicio10CF()
        {
            int contador = 1;
            while (contador <= 100) //true
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }

            Console.ReadLine();
        }
    }
}
       