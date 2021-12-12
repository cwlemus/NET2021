using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2
{
    class ProgramPrestamo
    {
        static void Main(string[] args)
        {
            int tipoCliente = 0;
            string nombre = "", telefono = "";            
            ClientePrestamo clienteBanco = new ClientePrestamo();            
            clienteBanco = clienteBanco.generarInstancia(tipoCliente, nombre, telefono);
            Console.WriteLine(clienteBanco.ToString());
            Console.ReadLine();
        }   
    }
}
