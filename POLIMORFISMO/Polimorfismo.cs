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
            PersonaPol[] personas = new PersonaPol[3];
            personas[0] = new PersonaPol();
            personas[1] = new ClientePol();
            personas[2] = new Proveedor();
            
            foreach (var p in personas)
            {
                imprimir(p);
            }            
            Console.ReadLine();
        }
        public static void imprimir(PersonaPol p)
        {
            Console.WriteLine(p);
        }


    }
}
