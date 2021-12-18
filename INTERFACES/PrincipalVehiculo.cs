using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2.INTERFACES
{
    class PrincipalVehiculo
    {
        public static void Main()
        {
            ServiceVehiculo s = new ServiceVehiculo();
            foreach (var item in s.GetAllVehiculos())
            {
                Console.WriteLine("Descripcion: " + item.Descripcion);
                Console.WriteLine("Precio: " + item.Precio);
            }

            Console.ReadLine();
        }
    }
}
