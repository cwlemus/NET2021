using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2.MENEJO_ERRORES
{
    class ExceptionTest
    {
        static double GuardarDivision(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }   
        static void Main()
        {
            double a = 98, b = 3;
            double resultado = 0;
            try
            {
                resultado = GuardarDivision(a, b);
                Console.WriteLine("{0} divido por {1} = {2}",a,b,resultado);
            }
            catch (Exception)
            {
                Console.WriteLine("Se disparó division entre cero");
            }
            Console.ReadLine();
        }
    }
}
