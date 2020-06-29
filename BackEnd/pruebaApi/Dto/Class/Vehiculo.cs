using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaApi.Model
{
    [Table("Vehiculo", Schema = "dbo")]

    public class Vehiculo
    {
        [Key]
        public int ID { get; set; }
        public string Patente { get; set; }
        public int IdMarca { get; set; }
        public string Modelo { get; set; }
        public int Puertas { get; set; }
        public string Titular { get; set; }

        [ForeignKey("IdMarca")]
        public virtual Marca Marca { get; set; }

    }
}
