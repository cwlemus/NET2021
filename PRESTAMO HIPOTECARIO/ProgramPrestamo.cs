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
            Console.WriteLine("Ingrese el numero de clientes a atender:");
            int numClientes = int.Parse(Console.ReadLine());
            ClientePrestamo cliente;
            ClientePrestamo[] clientes = new ClientePrestamo[numClientes];

            //se genera instancia inicial y se ingresa informacion general
            //ClientePrestamo clienteBanco = new ClientePrestamo();
            //se especifica tipo de cliente y se realizan los calculos
            //clienteBanco = clienteBanco.generarInstancia(tipoCliente, nombre, telefono);
            //se procede a imprimir la informacion
            //Console.WriteLine(clienteBanco.ToString());

            for (int i = 0; i < clientes.Length; i++)
            {
                cliente= new ClientePrestamo();
                clientes[i] = cliente.GenerarInstancia(cliente.TipoCliente,cliente.Nombre,cliente.Telefono);
            }

            //aplicando polimorfismo
            foreach (var c in clientes)
            {
                Console.WriteLine(c.ToString()); 
            }

            Console.ReadLine();
        }   
    }
}
