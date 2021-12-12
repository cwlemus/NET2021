using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    class Polimorfismo
    {
        public static void Main()
        {
            Persona[] personas = new Persona[3];
            personas[0] = new Persona();
            personas[1] = new Cliente();
            personas[2] = new Proveedor();
            
            foreach (var p in personas)
            {
                imprimir(p);
            }            
            Console.ReadLine();
        }
        public static void imprimir(Persona p)
        {
            Console.WriteLine(p);
        }


    }
}
