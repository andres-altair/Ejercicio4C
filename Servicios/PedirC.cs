using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4C.Servicios
{
    internal class PedirC : PedirI
    {
        public double pedir()
        { 
            {
                Console.WriteLine("escribe un numero ");
                double a = Convert.ToDouble(Console.ReadLine());
                return a;
            }
          
        }
    }
}

