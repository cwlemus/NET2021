using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET011112S2.INTERFACES
{
    public interface IVehiculo
    {
        int InsertarVehiculo(Vehiculo v);
        int BorrarVehiculo(int codigo);
        Vehiculo[] GetAllVehiculos();
        Vehiculo[] GetVehiculoByNombre(string nombre);
    }
}
