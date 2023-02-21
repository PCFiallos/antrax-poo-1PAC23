using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.EjerciciosSemana2CesarF
{
    internal class Ejercicio02CF
    {
        public Ejercicio02CF()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Programa que determina que numeor es mayor.");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++\n");

                Console.Write("Ingrese el Primer numero: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo numero: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine("El numero pramario es mayor que el numero secuendario.");
                }
                else if (num2 > num1)
                {
                    Console.WriteLine("El numero secundario es mayor que el numero perimario.");
                }
                else
                {
                    Console.WriteLine("Ambos numeros tienen el mismo valor numerico.");
                }

                Console.WriteLine("¿Desea continuar?----------------------- (S/N)");
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


