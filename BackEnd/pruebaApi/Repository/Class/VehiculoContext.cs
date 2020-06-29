using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaApi.Model
{
    public class VehiculoContext : DbContext
    {
        public VehiculoContext(DbContextOptions<VehiculoContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Marca> Marca { get; set; }
    }
}
