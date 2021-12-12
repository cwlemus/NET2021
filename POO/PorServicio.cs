using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
   public class PorServicio:ClientePrestamo
    {
        public int NumeroHorasMensuales { get; set; }
        public double ValorHora { get; set; }
        public PorServicio(string nombre, string telefono) : base(nombre, telefono)
        {
            Console.WriteLine("Ingrese promedio de horas trabajadas al mes: ");
            this.ValorHora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese promedio de valor por hora trabajadas al mes ($): ");
            this.NumeroHorasMensuales = int.Parse(Console.ReadLine());
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Ingresos = (this.NumeroHorasMensuales*this.ValorHora);
            this.PorcentajePrima = 0.20d;
            this.NumeroSalarios = 10;
            this.InteresMensual = 7.0;
            this.Anyos = 20;
            this.NumeroCuotas = Anyos * 12;
            this.CalcularMontoMaximoAprobado();
            this.CalcularPrima();
            this.CalcularCuotaMensual(this.MontoAFinanciar);
        }
    }
}
