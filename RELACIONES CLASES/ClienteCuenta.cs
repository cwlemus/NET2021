using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2.RELACIONES_CLASES
{
    public class ClienteCuenta
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Cuenta[] Cuentas { get; set; }
    }
}
