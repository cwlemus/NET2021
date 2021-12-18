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
            #region Estudiantes
            //Estudiante estudiente1 = new Estudiante();
            //Estudiante estudiente2 = null;
            //Estudiante estudiante3 = new Estudiante();
            //Estudiante estudiante4 = new Estudiante(1, "Maria", "Perez", 100.89m, 10);
            //estudiente1.Nombre = "Carlos";
            //estudiente2 = estudiente1;
            //estudiente2.Nombre = "Jose";
            //estudiente2 = null;
            ////Console.WriteLine(estudiente2.Nombre);
            ////Console.WriteLine(estudiente1.Nombre);
            //Console.WriteLine(estudiante4.PagoMensual);
            //estudiante4.CalcularCuotaMensual();
            //Console.WriteLine("mensualidad con descuento: " + estudiante4.PagoMensual);
            //Console.ReadLine();
            #endregion
            #region Personas
            Persona p = new Persona();
            Cliente c = new Cliente();
            Asalariado a = new Asalariado();
            
            Console.WriteLine(p.ToString());
            Console.WriteLine(c.ToString());
            a.imprimirPadre();
            Console.ReadLine();
            #endregion
        }
    }    
}
