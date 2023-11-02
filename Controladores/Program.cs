using Ejercicio4C;
using Ejercicio4C.Servicios;

namespace Ejercicio4C
{
    class program 
    { 
        public static void Main(string[] args)
        {
            PedirI pI = new PedirC();
            double a = pI.pedir();
            double b = pI.pedir();

            MultiplicacionI mI = new MultiplicacionC();
            mI.multi(a, b);
        }
    }
}