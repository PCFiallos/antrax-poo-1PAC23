using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.EjerciciosSemana2CesarF
{
    internal class Ejercicio05CF
    {
        public Ejercicio05CF()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Pizza o Homburguesa");
                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

                Console.WriteLine("¿Que desea de comer?");
                Console.WriteLine("\n1. Hamburguesa\n2. Pizza\n\n");
                Console.Write("Seleccione su opcion: ");
                int eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        Console.WriteLine("El precio de las Hamburguesas es: \n" +
                            "Hamburguesa des con Papas suizas amarillas ------------------------- L.95\n" +
                            "Hamburguesa de pollo con papas francesas -------------------- L.90");
                        break;
                    
                    
                    case 2:
                        Console.WriteLine("El precio de las pizzas es:\n" +
                            "Pizza de Jamon con pollo ------------------------- L.300\n" +
                            "Pizza de Pepperonni y aiguaste -----------==--------- L.350\n" +
                            "Pizza estilo italiano -------------------- L.1200\n");
                        break;
                    default:
                        Console.WriteLine("Eso no estar en nuestro menu");
                        break;
                }
                Console.WriteLine("¿Desea revisar el menu nuevamente? (S: si /N: no)");
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

