using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2.MENEJO_ERRORES
{
    public class MiClase
    {
        public int Dato { get; set; }
        public void MiFun(string s)
        {
            if (s == null)
                throw new ArgumentNullException();
        }
    }
}
