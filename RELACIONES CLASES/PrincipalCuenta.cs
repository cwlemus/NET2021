using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2.RELACIONES_CLASES
{
    class PrincipalCuenta
    {
        public static void Main()
        {
            Cuenta cuenta = new Cuenta();
            Console.WriteLine("ingrese numero de cuenta: ");
            cuenta.NumeroCuenta = int.Parse(Console.ReadLine());
            Console.WriteLine(cuenta);
            Console.ReadLine();

        }
    }
}
