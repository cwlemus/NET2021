using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    public class Estudiante
    {
        public Estudiante()
        {
        }
        public Estudiante(int codigo)
        {
            this.Codigo = codigo;
        }

        public Estudiante(int codigo,string nombre,string apellido,decimal pagoMensual,int cum)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            PagoMensual = pagoMensual;
            Cum = cum;
            CalcularPagoMensual();
        }

        public void CalcularPagoMensual()
        {            
            if (Cum>9)
            {
                PagoMensual -= Descuento();
            }
        }

        public decimal Descuento()
        {
            return PagoMensual * 0.80m;
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

       
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal PagoMensual { get; set; }
        public int Cum { get; set; }
    }
}
