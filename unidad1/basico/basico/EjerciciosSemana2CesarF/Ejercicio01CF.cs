using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.EjerciciosSemana2CesarF
{
    internal class Ejercicio01CF
    {
        public Ejercicio01CF()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Programa determina si un numero digitado es positivo, negativo o cero.");
             
                Console.WriteLine("____________________________________________________________\n");

                Console.Write("Ingrese un dato numerico: ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine("El numero ingresado es Positivo.");
                }
                if (num < 0)
                {
                    Console.WriteLine("El numero ingresado es negativo.");
                }
                if (num == 0)
                {
                    Console.WriteLine("El numero ingresado es CERO.");
                }

                Console.WriteLine("¿Desea continuar la operacion? (S/N)");
                
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

