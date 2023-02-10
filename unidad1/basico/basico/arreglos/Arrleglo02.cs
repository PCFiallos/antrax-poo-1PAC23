using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Arrleglo02
    {
        public Arrleglo02()
        {
            bool continuar = true;


                while (continuar) {
                Random random = new Random();
                Console.WriteLine("indique el tamano del arreglo");
                int tan = int.Parse(Console.ReadLine());    

                int[] numeros = new int[tan];

                for (int i = 0; i < tan; i++)
                {
                    numeros[i] = random.Next(1, 100);
                    Console.WriteLine("numeros[" + i + "] = " + numeros[i]);

                }
                Console.WriteLine("desea continuar");
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
