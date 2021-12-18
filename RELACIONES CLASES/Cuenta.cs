using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2.RELACIONES_CLASES
{
    public class Cuenta
    {
        public int NumeroCuenta { get; set; }
        public ClienteCuenta Cliente { get; set; }
        public decimal Saldo { get; set; }

        public Cuenta()
        {     
            Cliente = new ClienteCuenta();
            Console.WriteLine("Ingrese datos del cliente");
            try
            {              
                Console.WriteLine("Ingrese codigo del cliente");
                Cliente.Codigo = int.Parse(Console.ReadLine());                          
            }
            catch (Exception e)
            {
                Cliente.Codigo = 0;
                Console.WriteLine(e.Message); 
            }
            Console.WriteLine("Ingrese nombre del cliente");
            Cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese direcccion del cliente");
            Cliente.Direccion = Console.ReadLine();

        }
        
        public override string ToString()
        {

            return string.Format("Cuenta numero: {0}\n\tCodigo {1}\n\tCliente {2}\n\tDireccion {3}", NumeroCuenta,Cliente.Codigo,Cliente.Nombre,Cliente.Direccion);
        }
    }
}
