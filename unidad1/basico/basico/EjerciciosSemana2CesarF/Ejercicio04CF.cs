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
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("QUE DIA DE LA SEMANA ES");
                
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5");

                Console.Write("Ingrese uno de los 7 dias de la semana: ");
               
                int numeroDiaSemana = int.Parse(Console.ReadLine());

                switch (numeroDiaSemana)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        break;
                    case 3:
                        Console.WriteLine("Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                    default:
                        Console.WriteLine("ERORR ESTE NO ES UN DIA DE LA SEMANA");
                        break;
                }
                Console.WriteLine("¿Desea Intentar nuevamente? (S/N)");
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
