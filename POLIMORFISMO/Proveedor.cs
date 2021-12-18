using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    public class Proveedor : PersonaPol
    {        
        public string NumeroRegistro { get; set; }
        public int Codigo { get; set; }
        public override string ToString()
        {
            Codigo = 1;
            return string.Format("estoy en clase proveedor con el codigo "+Codigo);
        }
    }
}
