using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2.INTERFACES
{
    public class ServiceVehiculo : IVehiculo
    {
        string sql;
        public int BorrarVehiculo(int codigo)
        {
            sql = string.Format("delete from Vehiculo where={0}", codigo);
            //ejecuto la consulta
            return 1;
        }

        public Vehiculo[] GetAllVehiculos()
        {
            sql = string.Format("select * from Vehiculo");
            //ejecuto consulta
            return new Vehiculo[]
            {
                new Vehiculo
                {
                    Codigo=1,
                    Descripcion="vehiculo importado",
                    Capacidad=4,
                    Modelo="Sedan",
                    Precio=5600.90m
                },
                 new Vehiculo
                {
                    Codigo=2,
                    Descripcion="vehiculo de agencia",
                    Capacidad=4,
                    Modelo="Sedan",
                    Precio=5800.90m
                }
            };
        }

        public Vehiculo[] GetVehiculoByNombre(string nombre)
        {
            sql = string.Format("select * from Vehiculo where nombre = {0}",nombre);
            //ejecuto consulta
            return new Vehiculo[]
            {
                new Vehiculo
                {
                    Codigo=1,
                    Descripcion="vehiculo importado",
                    Capacidad=4,
                    Modelo="Sedan",
                    Precio=5600.90m
                }
            };
        }

        public int InsertarVehiculo(Vehiculo v)
        {
            sql = string.Format("insert into Vehiculo values({0},'{1}',{2},{3},{4})",
                v.Codigo, v.Descripcion, v.Capacidad, v.Precio);
            return 1;
        }
    }
}
