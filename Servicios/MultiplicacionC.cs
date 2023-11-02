using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4C.Servicios
{
    internal class MultiplicacionC :MultiplicacionI
    {
    
            public  void multi(double d, double i)
            {
                bool cerrar = false;
                while (!cerrar)
                {
                    if (cerrar) { Console.WriteLine("cierre de aplicacion"); }
                    else
                    {
                        double resu = d * i;
                        Console.WriteLine("el resultado es:  " + d + "+" + i + "=" + resu);
                    }
                }
            }
    }
}
