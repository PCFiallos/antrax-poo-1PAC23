using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class ListarNumero01
    {
        public ListarNumero01()
        {
            /*
             * while (cond){...........}
             */
            Console.WriteLine("Listar numero hasta ");
            int limite = int.Parse(Console.ReadLine());
            int i = 1;
            while (i<=limite) 
            {
                Console.WriteLine(i);
                i++; //Se EJECUTA luego de la interacion
                //++i Se ejecuta antes de la iteracion
                // i= i +1;   i= i -1; --i; 

               
            }

            Console.WriteLine("desea continuar");
           
        }
    }
}
