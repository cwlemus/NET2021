using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    public  class PersonaPol
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        private string variable;
        public class PersonaB
        {
            public void MetodoB()
            {
                PersonaPol e=new PersonaPol();
                e.variable="";
            }
        }
        
        public override string ToString()
        {
            return string.Format("estoy en clase persona...");
        }
    }
}
