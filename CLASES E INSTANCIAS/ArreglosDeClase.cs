using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    public class ArreglosDeClase
    {
        public static void Main()
        {
            int[] Numeros = new int[3];

            //inicalizamos
            Estudiante[] estudiantes = new Estudiante[3];
            decimal sumatoria = 0.00m;

            //ingreso de datos
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine(string.Format("Ingrese informacion de estudiante {0}",(i+1)));
                Console.WriteLine("Ingrese Codigo: ");
                Estudiante est = new Estudiante();
                est.Codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Nombre: ");
                est.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido: ");
                est.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Pago Mensual: ");
                est.PagoMensual = decimal.Parse(Console.ReadLine());
                sumatoria += est.PagoMensual;
                estudiantes[i] = est;
                Console.Clear();
            }

            Console.WriteLine("Informacion de estudiantes");

            //despliegue
            foreach (var item in estudiantes)
            {
                Console.WriteLine("Codigo: "+item.Codigo);
                Console.WriteLine(string.Format("Nombre: {0} {1}",item.Nombre,item.Apellido));
                Console.WriteLine(string.Format("Pago: ${0}",item.PagoMensual));

            }

            Console.WriteLine(string.Format("Promedio de pagos: ${0:0.00}",(sumatoria/estudiantes.Length)));
            Console.ReadLine();
        }
    }
}
