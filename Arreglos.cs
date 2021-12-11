using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    public class Arreglos
    {
        public static void Main()
        {
            //inicializacion 
            decimal[] numeros = new decimal[3];
            decimal sumatoria = 0m;

            //lectura
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(string.Format("Ingrese valor {0}",(i+1)));
                numeros[i] = decimal.Parse(Console.ReadLine());
                sumatoria += numeros[i];
            }

            //despliegue
            foreach (var item in numeros)
            {
                Console.WriteLine(string.Format("El valor es {0}",item));
            }
            Console.WriteLine("El promedio de todo es: "+(sumatoria/numeros.Length));
            Console.ReadLine();
        }
    }
}
