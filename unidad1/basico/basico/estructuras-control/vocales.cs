using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{

    internal class vocales
    {
        public vocales()
        {
            Console.WriteLine("Nombre segun la vocal");
            Console.WriteLine("---------------");
            Console.WriteLine("ingrese una vocal");
            char vocal = Console.ReadLine()[0];
            switch (vocal)
            {
                case 'a':
                    Console.WriteLine("Abel, Angel, Andrea, Antonia");
                    break;
                case 'e':
                    Console.WriteLine("Ërick, Estevan, Edgardo, Eduardo, Ericka, Esmeralda");
                    break;
                case 'i':
                    Console.WriteLine("Isis, Isidoro,Ivan, Iris");
                    break;
                case 'o':
                    Console.WriteLine("Omar, Oscar, Orfilia, Ovidio, Octavio");
                    break;
                case 'u':
                    Console.WriteLine("Ulises, Ursula, Uriel, Ubaldo, Uriana");
                    break;


                default:
                    Console.WriteLine("La Vocal no es valida");
                    break;
            }
        }
    }
}
