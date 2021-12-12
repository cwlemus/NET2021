using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    public class ClientePrestamo
    {
        #region atributos
        public int TipoCliente { get; set; }
        public string Nombre { get; set; }
        public double CuotaMensual { get; set; }
        public int NumeroCuotas { get; set; }
        public string Telefono { get; set; }
        public double MontoAFinanciar { get; set; }
        public double PorcentajePrima { get; set; }
        public double Prima { get; set; }
        public double Ingresos { get; set; }
        public double InteresMensual { get; set; }
        public int NumeroSalarios { get; set; }
        public int Anyos { get; set; }

        #endregion
        #region Metodos

        public ClientePrestamo()
        {
            genearMenu();
        }
        public void genearMenu()
        {
            Console.WriteLine("Bienvenido al sistema de gestion de propiedades Hipotecarias ");
            Console.WriteLine("Seleccione el tipo de empleado");
            Console.WriteLine("1- Cliente Asalariado");
            Console.WriteLine("2- Cliente por servicio");
            Console.WriteLine("3- Cliente Comerciante");
            TipoCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono:");
            Telefono = Console.ReadLine();
        }

        public ClientePrestamo(string nombre, string telefono)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;

        }
        public void CalcularMontoMaximoAprobado()
        {
            double montoRetorno = 0d;
            montoRetorno = Ingresos * NumeroSalarios;
            double prima = PorcentajePrima * Ingresos;
            montoRetorno -= prima;
            this.MontoAFinanciar = Math.Round(montoRetorno, 2);
        }
        public void CalcularCuotaMensual(double monto)
        {
            double intMes = ((InteresMensual / 100) / 12);
            double dividendo = (intMes * Math.Pow((1 + intMes), NumeroCuotas));
            double divisor = (Math.Pow((1 + intMes), NumeroCuotas) - 1);
            this.CuotaMensual = Math.Round((monto * (dividendo / divisor)), 2);
        }
        public void CalcularPrima()
        {
            this.Prima = Math.Round((PorcentajePrima * Ingresos), 2);
        }

        public override string ToString()
        {
            string cadena = string.Format("\nEstimado {0} le detallamos información de su credito hipotecario\nEl monto maximo que puede aprobarse es ($): {1} \nPrima minima a cancelar es ($): {2} \nLa Cuota mensual a cancelar sera ($): {3} \nPara un periodo de ($): {4} años\n",this.Nombre.ToUpper(),MontoAFinanciar,Prima,CuotaMensual,Anyos);
            return cadena;
        }
        public ClientePrestamo generarInstancia(int tipo,string nombre,string telefono)
        {
            ClientePrestamo c = null;
            switch (TipoCliente)
            {
                case 1:
                    c = new Asalariado(nombre, telefono);
                    break;
                case 2:
                    c = new PorServicio(nombre, telefono);
                    break;
                case 3:
                    c = new Comerciante(nombre, telefono);
                    break;
                default:
                    break;
            }
            return c;
        }

        #endregion
    }
}
