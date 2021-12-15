using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    public class Estudiante
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Cum { get; set; }
        public decimal PagoMensual { get; set; }
        public Estudiante()
        {

        }
        public Estudiante(int codigo, string nombre, string apellido, decimal cum, decimal pagoMensual)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Cum = cum;
            PagoMensual = pagoMensual;
        }
    }
}
