using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.EjerciciosSemana2CesarF
{
    internal class Ejercicio07CF
    {
        public Ejercicio07CF()
        {

            bool continuar = true;

            while (continuar)
            {
                int suma = 0;

                for (int i = 1; i <= 10; i++)
                {
                    suma += i;
                    Console.WriteLine(i);
                }

                Console.WriteLine("Presione para continuar a la suma\n");
                
                Console.ReadKey();
                Console.WriteLine("La suma de los numeros del 1 al 10 es: " + suma);

                Console.WriteLine("¿Desea intentar nuevamente? (S: si /N: no)");
               
                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta != "S")
                {
                    continuar = false;
                }
                Console.Clear();
            }

        }
    }
}
