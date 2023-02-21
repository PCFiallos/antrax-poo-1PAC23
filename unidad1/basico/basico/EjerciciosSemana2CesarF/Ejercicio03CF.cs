using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.EjerciciosSemana2CesarF
{
    internal class Ejercicio04CF
    {
        public Ejercicio04CF()
        {
            Console.WriteLine("Cual es su Genero genetico que tiene en el DNI?");
            Console.WriteLine("==================================================\n");

            Console.WriteLine("¿Cual es su GENERO?");
            
            
            Console.Write("Escriba 1 si eres Hombre o 2 si eres Mujer: ");
            
            int genero = int.Parse(Console.ReadLine());

            if (genero == 1)
            {
                Console.WriteLine("Eres hombre (GeneroMasculino)");
            }
            else if (genero == 2)
            {
                Console.WriteLine("Eres mujer (GeneroFemenino)");
            }
            else
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXGenero no programadoXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            }
        }
    }
}
