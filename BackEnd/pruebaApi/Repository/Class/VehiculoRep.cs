using pruebaApi.Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Class
{
    public class VehiculoRep: IVehiculoRep
    {
        private readonly VehiculoContext _vehiculoContext;
        public VehiculoRep(VehiculoContext context)
        {
            _vehiculoContext = context;
        }

        public IEnumerable<Vehiculo> GetAllVehiculos()
        {
            return _vehiculoContext.Vehiculo.ToList();
        }
    }
}
