using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
   public class Comerciante:ClientePrestamo
    {
        public Comerciante(string nombre, string telefono) : base(nombre, telefono)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            Console.WriteLine("Ingrese monto facturado mensual ($): ");
            double montoFacturadoMensual = double.Parse(Console.ReadLine());
            this.Ingresos = (montoFacturadoMensual*0.25);
            this.Ingresos = base.CalcularDescuentosLey();
            this.PorcentajePrima = 0.15d;
            this.NumeroSalarios = 15;
            this.InteresMensual = 7.5;
            this.Anyos = 25;
            this.NumeroCuotas = Anyos * 12;
            this.CalcularMontoMaximoAprobado();
            this.CalcularPrima();
            this.CalcularCuotaMensual(this.MontoAFinanciar);            
        }
        
    }
}
