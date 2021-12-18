using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2.MENEJO_ERRORES
{
    class PrincipalError
    {
        public static void Main()
        {
            try
            {
                string s = null;
                MiClase mC = new MiClase();
                mC.MiFun(s);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("{0} Argumento no valido",e);

                Console.ReadLine();
            }
        }
    }
}
