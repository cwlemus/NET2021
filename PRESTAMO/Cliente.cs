using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    public class Cliente : Persona
    {
        
        public string TipoCliente { get; set; }

        public override string ToString()
        {
            return "Estoy en clase Cliente...";
        }
    }
}
