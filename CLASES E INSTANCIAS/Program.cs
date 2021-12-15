using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiente1 = new Estudiante();
            Estudiante estudiente2 = null;
            Estudiante estudiante3 = new Estudiante();
            Estudiante estudiante4 = new Estudiante(1,"Maria","Perez",100.89m,10);
            estudiente1.Nombre = "Carlos";
            estudiente2 = estudiente1;
            estudiente2.Nombre = "Jose";
            estudiente2 = null;
            
            //Console.WriteLine(estudiente2.Nombre);
            Console.WriteLine(estudiente1.Nombre);
            Console.WriteLine(estudiante4.PagoMensual);
            Console.ReadLine();

        }
    }    
}
