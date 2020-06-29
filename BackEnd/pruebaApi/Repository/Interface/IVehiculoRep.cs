using pruebaApi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IVehiculoRep
    {
        IEnumerable<Vehiculo> GetAllVehiculos();
    }
}
