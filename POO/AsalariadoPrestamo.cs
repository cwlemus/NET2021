using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    public class AsalariadoPrestamo : ClientePrestamo
    {
        public AsalariadoPrestamo(string nombre, string telefono) 
        {
            Console.WriteLine("Ingrese su salario: ");
            this.Ingresos = double.Parse(Console.ReadLine());
            this.Nombre = nombre;
            this.Telefono = telefono;            
            this.PorcentajePrima = 0.10d;
            this.NumeroSalarios = 17;
            this.InteresMensual = 6.5;
            this.Anyos = 30;
            this.NumeroCuotas = Anyos * 12;
            this.CalcularMontoMaximoAprobado();
            this.CalcularPrima();
            this.CalcularCuotaMensual(this.MontoAFinanciar);
        }
    }
}
