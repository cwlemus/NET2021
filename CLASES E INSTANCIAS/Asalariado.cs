using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    public class Asalariado :Persona
    {
        public decimal Salario { get; set; }
        public override string ToString()
        {
            return "Estoy en clase Empleado Asalariado...";
        }
        public void imprimirPadre()
        {
            Console.WriteLine(base.ToString());
            Console.WriteLine(this.ToString());
        }
    }
}
