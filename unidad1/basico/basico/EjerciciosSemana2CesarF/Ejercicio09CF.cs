using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.EjerciciosSemana2CesarF
{
    internal class Ejercicio09CF
    {
        public Ejercicio09CF()
        {

            string continuar = "si";

            while (continuar.ToLower() != "no")
            {
                Console.WriteLine("¿Desea continuar ejecutando? (si/no)");
                continuar = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Programa finalizado");
        }
    }